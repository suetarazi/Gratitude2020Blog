using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Data;
using Blog.Models;
using Blog.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        private IPost _post;

        public HomeController(IPost post)
        {
            _post = post;
        }

        public IActionResult Index()
        {
            var posts = _post.GetAllPosts();
            return View(posts);
        }

        public IActionResult Post(int id)
        {
            var post = _post.GetPostById(id);
            return View(post);
        }

        [HttpGet]
        public IActionResult Edit()
        {
            return View(new Post());
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Post post)
        {
            await _post.AddPost(post);

            return RedirectToAction("Index");
        }
    }
}
