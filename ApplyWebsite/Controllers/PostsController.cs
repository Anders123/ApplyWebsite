using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ApplyWebsite.EfModel;
using ApplyWebsite.Helpers;
using ApplyWebsite.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using WebApiCommon;
using Interview = WebApiCommon.Interview;

namespace ApplyWebsite.Controllers
{
    public class PostsController : BaseController
    {
        /// <summary>
        /// In memory cache.
        /// </summary>
        private readonly IMemoryCache _cache;
        private const string PostsCacheId = "PostsCacheId";

        /// <summary>
        /// Settings for calling the web API.
        /// </summary>
        private readonly WebApiSettingsForApplyProcess _webApiSettings;

        public PostsController(ApplyDbContext db, IOptions<WebApiSettingsForApplyProcess> webApiSettingsForApplyProcess, IMemoryCache memCache) : base(db)
        {
            _webApiSettings = webApiSettingsForApplyProcess.Value;
            _cache = memCache;
        }

        /// <summary>
        /// Show a list of posts to apply for or add to briefcase.
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Index()
        {   // Try to get posts from the cache
            List<Post> posts = null;
            
            if (!_cache.TryGetValue(PostsCacheId, out posts))
            {
                posts = await Db.Post.Select(x => x).Take(10).ToListAsync();
                var offset24Hours = new DateTimeOffset(DateTime.Now.ToUniversalTime()).AddSeconds(60*20); // 20 min
                _cache.Set(PostsCacheId, posts, offset24Hours);
            }

            return View(posts);
        }
        
        /// <summary>
        /// Apply to post directly from the list of posts.
        /// </summary>
        /// <param name="id">Id of the post to apply for.</param>
        /// <returns></returns>
        public async Task<IActionResult> Apply(int id)
        {
            var post = await Db.Post.FirstOrDefaultAsync(x => x.Id == id);
            ApplyViewModel viewModel = null;
            if (post != null)
            {
                // Create a new view model
                viewModel = new ApplyViewModel { Post = post };


                // 1. User must log in if not already logged in
                //var value = HttpContext.Session.GetString("Person");
                //if (string.IsNullOrEmpty(value))
                //{
                //    var person = new SignedInPerson("Anders Hundborg", "anders.hundborg@outlook.dk", 1);


                //    var serialisedDate = JsonConvert.SerializeObject(person);
                //    HttpContext.Session.SetString("Person", serialisedDate);
                //}
                //else
                //{
                //    var person = JsonConvert.DeserializeObject<Person>(value);
                //}

                // 2. Add post to briefcase
                // 3. Start interview
            }
            return View("Apply", viewModel);
        }


        /// <summary>
        /// User sign in.
        /// </summary>
        /// <param name="name">Full name.</param>
        /// <param name="email">Email address.</param>
        /// <param name="applyModel">The view model.</param>
        /// <returns></returns>
        public async Task<IActionResult> SignIn(string name, string email, string applyModel)
        {
            var viewModel = JsonConvert.DeserializeObject<ApplyViewModel>(applyModel);
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email))
            {
                ViewModelError.AddViewModelError(ModelState, "ControllerError", "Please provide name and email");
                return View("Apply", viewModel);
            }
       
            using (var client = new HttpClient())
            {
                // sign in
                var response = await client.PostAsync(UrlBuilder.SignInUri(_webApiSettings.BaseUrl, name, email), null);

                // Sign in succeded
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsStringAsync();
                    var signInStatus = JsonConvert.DeserializeObject<SigninStatus>(data);
                    viewModel.SignedInPerson = new SignedInPerson(name, email, signInStatus.PersonId);

                    // 1. Create a new briefcase (for the single post) or get existing briefcase
                    response = await client.PostAsync(UrlBuilder.BriefcaseAddPostUri(_webApiSettings.BaseUrl, 0, viewModel.SignedInPerson.PersonId, viewModel.Post.Id), null);
                    if (response.IsSuccessStatusCode)
                    {
                        var briefcaseId = await response.Content.ReadAsStringAsync();
                        viewModel.BriefcaseId = int.Parse(briefcaseId);
                    }
                    else
                    {
                        // Try to get existing brieafcase id for person
                        var briefcase = Db.Briefcase.FirstOrDefault(x => x.PersonId == viewModel.SignedInPerson.PersonId);
                        if (briefcase != null)
                        {
                            viewModel.BriefcaseId = briefcase.Id;
                        }
                        else
                        {
                            ViewModelError.AddViewModelError(ModelState, "ControllerError", "An error occurred, please try again");
                            return View("Apply", viewModel);
                        }
                    }

                    // 2. Create the interview
                    response = await client.PostAsync(UrlBuilder.InterviewCreateUri(_webApiSettings.BaseUrl, viewModel.BriefcaseId, null), null);
                    if (response.IsSuccessStatusCode)
                    {
                        data =  await response.Content.ReadAsStringAsync();
                        viewModel.Interview = JsonConvert.DeserializeObject<Interview>(data);
                        viewModel.CurrentStep = 0;
                    }
                    else
                    {
                        ViewModelError.AddViewModelError(ModelState, "ControllerError", "An error occurred, please try again");
                        return View("Apply", viewModel);
                    }
                }
                // Failed
                else
                {
                    ViewModelError.AddViewModelError(ModelState, "ControllerError", "An error occurred, please try again");
                    return View("Apply", viewModel);
                }
            }

            return View("Step", viewModel);
        }

        /// <summary>
        /// Perform a step in the interview wizard.
        /// </summary>
        /// <param name="applyModel"></param>
        /// <returns></returns>
        public async Task<IActionResult> Step(string applyModel, string applyModelTmp)
        {
            ModelState.Clear();
            var viewModel = JsonConvert.DeserializeObject<ApplyViewModel>(applyModelTmp);

            var next = Request.Form["Next"];
            var previous = Request.Form["Previous"];
            if (next.Count > 0)
            {
                if (viewModel.CurrentStep < viewModel.Interview.Questions.Count - 1)
                {
                    viewModel.CurrentStep += 1;
                }
            }
            else if (previous.Count > 0)
            {
                if (viewModel.CurrentStep > 0)
                {
                    viewModel.CurrentStep -= 1;
                }
            }

            return View("Step", viewModel);
        }

    }
}