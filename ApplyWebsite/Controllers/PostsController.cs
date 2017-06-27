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

namespace ApplyWebsite.Controllers
{
    public class PostsController : BaseController
    {
        /// <summary>
        /// In memory cache.
        /// </summary>
        private readonly IMemoryCache _cache;
        private const string _postsCacheId = "PostsCacheId";

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
            
            if (!_cache.TryGetValue(_postsCacheId, out posts))
            {
                posts = await Db.Post.Select(x => x).Take(10).ToListAsync();
                var offset24Hours = new DateTimeOffset(DateTime.Now.ToUniversalTime()).AddSeconds(60*20); // 20 min
                _cache.Set(_postsCacheId, posts, offset24Hours);
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

            // Call web api to sign in
            using (var client = new HttpClient())
            {
                // TODO: url encode name and email
                var url = new Uri($"{_webApiSettings}Person/SignIn?name={name}&email={email}", UriKind.Absolute);
                HttpResponseMessage response = await client.PostAsync(url, null);

                // Sign in succeded
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsStringAsync();
                    var signInStatus = JsonConvert.DeserializeObject<SigninStatus>(data);
                    viewModel.SignedInPerson = new SignedInPerson(name, email, signInStatus.PersonId);

                    // 1. Create a new briefcase (for the single post) 
                    url = new Uri($"{_webApiSettings}Briefcase/0/AddPost?briefcaseTypeId=1&personId={viewModel.SignedInPerson.PersonId}&postId={viewModel.Post.Id}", UriKind.Absolute);
                    response = await client.PostAsync(url, null);


                }
                // Failed
                else
                {
                    ViewModelError.AddViewModelError(ModelState, "ControllerError", "An error occurred, please try again");
                    return View("Apply", viewModel);
                }
            }
            return View("Apply", viewModel);
        }


    }
}