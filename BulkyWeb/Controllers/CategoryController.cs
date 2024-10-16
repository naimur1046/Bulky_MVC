using BulkyWeb.Data;
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
            if (category.Name.ToString() == category.DisplayOrder.ToString()) {
                ModelState.AddModelError("name","Here two field has same value");
            }

            if (ModelState.IsValid)
            {
                _db.Categories.Add(category);
                _db.SaveChanges();
                return RedirectToAction("Index", "Category");
            }
            return View();

        }

        public IActionResult Edit(int?Id)
        {
            if(Id==null|| Id==0)
            {
                return NotFound();
            }

            Category categoryFromDb = _db.Categories.Find(Id);
            Category? categoryFromDb1 = _db.Categories.FirstOrDefault(u => u.Id == Id);
            Category? categoryFromDb2 = _db.Categories.Where(u=>u.Id==Id).FirstOrDefault();

            if (categoryFromDb==null)
            {
                return NotFound(categoryFromDb);
            }

            return View();
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (category.Name.ToString() == category.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "Here two field has same value");
            }

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
