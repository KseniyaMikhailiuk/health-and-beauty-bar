using System.Collections.Generic;

namespace HealthAndBeauty.BL.Models
{
    public class CenterCategoryModel: CategoryModel
    {
        public new IReadOnlyCollection<CenterServiceModel> Services { get; set; }
    }
}
