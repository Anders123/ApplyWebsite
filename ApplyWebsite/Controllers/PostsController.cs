using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplyWebsite.EfModel;
using ApplyWebsite.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

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

        public async Task<IActionResult> Apply(int id)
        {
            var post = await Db.Post.FirstOrDefaultAsync(x=>x.Id == id);
            if (post != null)
            {
                // 1. User must log in if not already logged in
                var value = HttpContext.Session.GetString("Person");
                if (string.IsNullOrEmpty(value))
                {
                    var person = new SignedInPerson("Anders Hundborg", "anders.hundborg@outlook.dk", 1);

              
                    var serialisedDate = JsonConvert.SerializeObject(person);
                    HttpContext.Session.SetString("Person", serialisedDate);
                }
                else
                {
                    var person = JsonConvert.DeserializeObject<Person>(value);
                }

                // 2. Add post to briefcase
                // 3. Start interview
            }
            return View("Apply", post);
        }
    }
}