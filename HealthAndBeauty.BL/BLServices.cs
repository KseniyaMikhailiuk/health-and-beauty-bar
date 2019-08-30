using HealthAndBeauty.BL.Contracts;
using HealthAndBeauty.BL.Services;
using Microsoft.Extensions.DependencyInjection;

namespace HealthAndBeauty.BL
{
    public static class BLServices
    {
        public static void AddServices(IServiceCollection services)
        {
            services.AddScoped<ICenterService, CenterService>();
            services.AddScoped<ICategoryService, CategoryService>();
        }
    }
}
