using FirelloProject.DAL;
using FirelloProject.Models;
using FirelloProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FirelloProject.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class SliderController : Controller
    {
        private readonly AppDbContext _appDbContext;
        private readonly IWebHostEnvironment _env;
            public SliderController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            return View(_appDbContext.Slider.ToList());
        }

        public IActionResult Create()
        {

            return View();

        }
        [HttpPost]
        public IActionResult Create(SliderCreateVM sliderCreateVM)
        {
            if (sliderCreateVM.Photo == null)
            {
                ModelState.AddModelError("Photo", "Bosh qoyma ");
                return View();
            }
            if (!sliderCreateVM.Photo.ContentType.Contains("image"))
            {
                ModelState.AddModelError("Photo", "only image ");
                return View();
            }
            if (sliderCreateVM.Photo.Length / 1024 > 500)
            {
                ModelState.AddModelError("Photo", "olcu boyukdur ");
                return View();

            }

            string fileName = Guid.NewGuid().ToString() + sliderCreateVM.Photo.FileName;
            string fullPath = Path.Combine(_env.WebRootPath, "img",fileName);

            using (FileStream stream = new FileStream(fullPath, FileMode.Create))
            {
                sliderCreateVM.Photo.CopyTo(stream);
            }
            Slider newSlider = new();
            newSlider.ImageUrl = fileName;

            _appDbContext.Slider.Add(newSlider);
            _appDbContext.SaveChanges();
           return RedirectToAction("Index");

        }



    }
}

