using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstAssigment.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstAssigment.Controllers
{
    public class CategoryController : Controller
    {
        private First_AssigmentContext temp = null;
        public CategoryController(First_AssigmentContext temp1)
        {
            temp = temp1;
        }
        [HttpGet]
        public IActionResult add_Category()
        {
            return View();
        }
        [HttpPost]
        public IActionResult add_Category(Category category)
        {
            temp.Category.Add(category);
            temp.SaveChanges();
            return View();
        }
        public IActionResult list_Category()
        {
            var list = temp.Category.ToList();
            return View(list);
        }
    }
}