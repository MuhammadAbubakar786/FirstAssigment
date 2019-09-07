using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstAssigment.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstAssigment.Controllers
{
    public class PostController : Controller
    {
        private First_AssigmentContext temp = null;
        public PostController(First_AssigmentContext temp1)
        {
            temp = temp1;
        }
        [HttpGet]
        public IActionResult add_Post()
        {
            return View();
        }
        [HttpPost]
        public IActionResult add_Post(Post post)
        {
            temp.Post.Add(post);
            temp.SaveChanges();
            return View();
        }
        public IActionResult list_Posts()
        {
            var list = temp.Post.ToList();
            return View(list);
        }
    }
}