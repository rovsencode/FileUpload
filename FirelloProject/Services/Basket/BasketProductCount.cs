using FirelloProject.ViewModels;
using Microsoft.Extensions.FileProviders;
using Newtonsoft.Json;

namespace FirelloProject.Services.Basket
{
    public class BasketProductCount : IBasketProductCount
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public BasketProductCount(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public int CalculateBasketProductCount()
        {
            //string basket = _httpContextAccessor.HttpContext.Request.Cookies["basket"];

            //var products = JsonConvert.DeserializeObject<List<BasketVM>>(basket);

            //return products.Sum(p => p.BasketCount);
            return 0;





        }
    }
}
