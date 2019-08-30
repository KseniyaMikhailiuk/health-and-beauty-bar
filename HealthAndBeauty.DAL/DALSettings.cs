using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthAndBeauty.DAL
{
    public class DALSettings
    {
        private readonly IConfiguration _configuration;

        public string DefaultConnection => _configuration.GetConnectionString(nameof(DefaultConnection));


        public DALSettings(IConfiguration configuration)
        {
            _configuration = configuration;
        }
    }
}
