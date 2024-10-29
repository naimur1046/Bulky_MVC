using BulkyBookWebRazor_Temp.Data;
using BulkyBookWebRazor_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyBookWebRazor_Temp.Pages.Categories
{
   
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        [BindProperty]
        public Category? Category { get; set; }

        public DeleteModel(ApplicationDbContext db)
        {
            _db = db;
        }

        

        public void OnGet(int?Id)
        {
            if(Id !=null && Id !=0)
            {
                Category = _db.Categories.Find(Id);
            }
        }
        public IActionResult OnPost()
        {

            Category? category = _db.Categories.Find(Category.Id);

            if (category == null)
            {
                return NotFound();
            }
            _db.Categories.Remove(category);
            TempData["success"] = "Category Deleted Successfully";
            _db.SaveChanges();
            
            return RedirectToPage("Index");


        }

    }
}
