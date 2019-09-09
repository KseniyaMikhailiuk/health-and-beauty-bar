using HealthAndBeauty.DAL.Contracts;
using HealthAndBeauty.DAL.Repositories;
using HealthAndBeauty.DB.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Umwa.DB;

namespace HealthAndBeauty.DAL
{
    public static class DALServicies
    {
        public static void AddServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ICenterRepository, CenterRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICenterTypeRepository, CenterTypeRepository>();
            services.AddScoped<ICenterServiceRepository, CenterServiceRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            
            var settings = new DALSettings(configuration);
            services.AddDbContext<HBContext>(options => 
                options.UseSqlServer(settings.DefaultConnection, x => x.MigrationsHistoryTable("Umwa_MigrationHistory", "dbo"))
            );

            UpdateDatabase(services);
        }

        private static void UpdateDatabase(IServiceCollection services)
        {
            using (var serviceScope = services.BuildServiceProvider().GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                using (var context = serviceScope.ServiceProvider.GetService<HBContext>())
                {
                    context.Database.Migrate();
                }
            }
        }
    }
}
