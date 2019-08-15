using HealthAndBeauty.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HealthAndBeauty.DAL
{
    public static class DALServices
    {
        public static void AddServices(IServiceCollection services, IConfiguration configuration)
        {
            DALSettings settings = new DALSettings(configuration);
            services.AddDbContext<HBContext>(options =>
                options.UseSqlServer(settings.ConnectionString, x => x.MigrationsHistoryTable("MigrationHistory", "dbo"))
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
