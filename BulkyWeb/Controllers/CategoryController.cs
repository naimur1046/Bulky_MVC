﻿using BulkyWeb.Data;
using BulkyWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Controllers
{
    public class CategoryController : Controller
    {

        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext applicationDbContext) { 
            _db = applicationDbContext;
          
        }
        public IActionResult Index()
        {
             List<Category> objCategoryList= _db.Categories.ToList();
            return View(objCategoryList);
        }

        public IActionResult Create() { 
         return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Add(category);
                _db.SaveChanges();
                return RedirectToAction("Index", "Category");
            }
            return View();

        }
    }
}
