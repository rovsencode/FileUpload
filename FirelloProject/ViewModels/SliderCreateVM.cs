using Microsoft.AspNetCore.Http;
using Microsoft.Build.Framework;


namespace FirelloProject.ViewModels
{
    public class SliderCreateVM
    {

        [Required(ErrorMessage)]
        public IFormFile Photo { get; set; }
    }
}
