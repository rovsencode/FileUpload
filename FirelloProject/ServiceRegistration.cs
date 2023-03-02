using FirelloProject.DAL;
using FirelloProject.Services.Basket;
using FirelloProject.Services.Product;
using Microsoft.EntityFrameworkCore;

namespace FirelloProject
{
    public static class ServiceRegistration
    {
        public static void FirelloServiceRegistration(this IServiceCollection services)
        {
          
            services.AddHttpContextAccessor();

            services.AddScoped<IBasketProductCount, BasketProductCount>();
            services.AddScoped<IProduct,ProductServices>();

        } 
    }
}

