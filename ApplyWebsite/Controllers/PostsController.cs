using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ApplyWebsite.EfModel;
using ApplyWebsite.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using WebApiCommon;

namespace ApplyWebsite.Controllers
{
    public class PostsController : BaseController
    {
        public PostsController(ApplyDbContext db) : base(db)
        {
        }

        public async Task<IActionResult> Index()
        {
            var posts = await Db.Post.Select(x => x).Take(10).ToListAsync();
            return View(posts);
        }

        public async Task<IActionResult> SignIn(string name, string email, string applyModel)
        {
            var viewModel = JsonConvert.DeserializeObject<ApplyViewModel>(applyModel);

            // Call web api to sign in
            using (var client = new HttpClient())
            {
                var url = new Uri($"http://localhost:62341/Person/SignIn?name={name}&email={email}", UriKind.Absolute);
                HttpResponseMessage response = await client.PostAsync(url, null);

                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsStringAsync();
                    var signInStatus = JsonConvert.DeserializeObject<SigninStatus>(data);
                    viewModel.SignedInPerson = new SignedInPerson(name, email, signInStatus.PersonId);
                }
            }
            return View("Apply", viewModel);
        }


        /// <summary>
        /// Apply to post directly from the list of posts.
        /// </summary>
        /// <param name="id">Id of the post to apply for.</param>
        /// <returns></returns>
        public async Task<IActionResult> Apply(int id)
        {
            var post = await Db.Post.FirstOrDefaultAsync(x=>x.Id == id);
            ApplyViewModel viewModel = null;
            if (post != null)
            {
                // Create a new view model
                 viewModel = new ApplyViewModel {Post = post};


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
    }
}