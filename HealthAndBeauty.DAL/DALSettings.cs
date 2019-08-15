using Microsoft.Extensions.Configuration;

namespace HealthAndBeauty.DAL
{
    public class DALSettings
    {
        private readonly IConfiguration _configuration;
        public string ConnectionString => _configuration.GetConnectionString("DefaultConnection");

        public DALSettings(IConfiguration configuration)
        {
            _configuration = configuration;
        }
    }
}
