using Logistics.Models;
using LogisticsWeb.DataAccess.Data;
using Microsoft.AspNetCore.Mvc;

namespace LogisticsWeb.Controllers
{
    public class CategoryController : Controller
    {
        private ApplicationDbContext _context;

        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Category> objCategoryList = _context.Categories.ToList();
            return View(objCategoryList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category obj)
        {
            //if (obj.Name.ToLower() == obj.DisplayOrder.ToString()) {
            //    ModelState.AddModelError("name", "Name cannot be like as Display Order");
            //}
            //if (obj.Name.ToLower() == "test")
            //{
            //    ModelState.AddModelError("", "Test is invalid value");
            //}
            if (ModelState.IsValid) {
                _context.Categories.Add(obj);
                _context.SaveChanges();
                TempData["success"] = "Categort is created succesfully";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Category? categoryFromDB = _context.Categories.Find(id);
            if (categoryFromDB == null) { 
                return NotFound();
            }
            return View(categoryFromDB);
        }

        [HttpPost]
        public IActionResult Edit(Category obj)
        {
            if (ModelState.IsValid)
            {
                _context.Categories.Update(obj);
                _context.SaveChanges();
                TempData["success"] = "Categort is updated succesfully";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Category? categoryFromDB = _context.Categories.Find(id);
            if (categoryFromDB == null)
            {
                return NotFound();
            }
            return View(categoryFromDB);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {
            Category? category = _context.Categories.Find(id);
            if (category == null) {
                return NotFound();
            }
            _context.Categories.Remove(category);
            _context.SaveChanges();
            TempData["success"] = "Categort is deleted succesfully";
            return RedirectToAction("Index");
        }
    }
}
