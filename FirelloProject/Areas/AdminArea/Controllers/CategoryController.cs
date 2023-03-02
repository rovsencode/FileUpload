using FirelloProject.DAL;
using FirelloProject.Models;
using FirelloProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FirelloProject.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public CategoryController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            return View(_appDbContext.Categories.ToList());

        }

        public IActionResult Detail(int id)
        {
            Category category=_appDbContext.Categories.SingleOrDefault(c=>c.ID==id);
            if (category == null) return NotFound();
            return View(category);
        }
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(CategoryCreateVM category)
        {
            if (!ModelState.IsValid) return View();


            Category newCategory = new() { 
            Name= category.Name,
            Description= category.Description,
            };

            _appDbContext.Categories.Add(newCategory);
            _appDbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
