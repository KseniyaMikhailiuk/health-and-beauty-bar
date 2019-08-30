using System.Collections.Generic;

namespace HealthAndBeauty.BL.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IReadOnlyCollection<ServiceModel> Services { get; set; }
    }
}
