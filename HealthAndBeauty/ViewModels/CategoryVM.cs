using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthAndBeauty.ViewModels
{
    public class CategoryVM
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IReadOnlyCollection<ServiceVM> Services { get; set; } 
    }
}
