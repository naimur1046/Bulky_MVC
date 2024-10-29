using BulkyBook.DataAccess.Data;
using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BulkyBookWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {

        private readonly ApplicationDbContext _db;
        private readonly IUnitOfWork _unitOfWork;
        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }
        public IActionResult Index()
        {
            List<Category> objCategoryList = _unitOfWork.Category.GetAll().ToList();
            return View(objCategoryList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (category.Name.ToString() == category.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "Here two field has same value");
            }

            if (ModelState.IsValid)
            {
                _unitOfWork.Category.Add(category);
                _unitOfWork.Save();
                TempData["success"] = "Category Created Successfully";
                return RedirectToAction("Index", "Category");
            }

            return View();

        }

        public IActionResult Edit(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }

            Category categoryFromDb = _unitOfWork.Category.Get(u => u.Id == Id);
            //Category? categoryFromDb1 = _db.Categories.FirstOrDefault(u => u.Id == Id);
            //Category? categoryFromDb2 = _db.Categories.Where(u=>u.Id==Id).FirstOrDefault();

            if (categoryFromDb == null)
            {
                return NotFound(categoryFromDb);
            }

            return View(categoryFromDb);
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {


            if (ModelState.IsValid)
            {
                _unitOfWork.Category.Update(category);
                _unitOfWork.Save();
                TempData["success"] = "Category Updated Successfully";
                return RedirectToAction("Index", "Category");
            }
            return View();

        }

        public IActionResult Delete(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }

            Category categoryFromDb = _unitOfWork.Category.Get(u => u.Id == Id);
            //Category? categoryFromDb1 = _db.Categories.FirstOrDefault(u => u.Id == Id);
            //Category? categoryFromDb2 = _db.Categories.Where(u=>u.Id==Id).FirstOrDefault();

            if (categoryFromDb == null)
            {
                return NotFound(categoryFromDb);
            }

            return View(categoryFromDb);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? Id)
        {

            Category? category = _unitOfWork.Category.Get(u => u.Id == Id);

            if (category == null)
            {
                return NotFound();
            }
            _unitOfWork.Category.Remove(category);
            _unitOfWork.Save();
            TempData["success"] = "Category Deleted Successfully";
            return RedirectToAction("Index", "Category");


        }
    }
}
