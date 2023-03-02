using FirelloProject.DAL;
//using FirelloProject.Migrations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using FirelloProject.Models;
using Newtonsoft.Json;
using FirelloProject.ViewModels;

namespace FirelloProject.ViewComponents
{
    public class HeaderViewComponent:ViewComponent
    {
        private readonly AppDbContext _appDbContext;

        public HeaderViewComponent(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            Bio bio = _appDbContext.Bios.FirstOrDefault();
            return View(await Task.FromResult(bio));
        }
    }
}
