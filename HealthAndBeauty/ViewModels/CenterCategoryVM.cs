using System.Collections.Generic;

namespace HealthAndBeauty.ViewModels
{
    public class CenterCategoryVM: CategoryVM
    {
        public new IReadOnlyCollection<CenterServiceVM> Services { get; set; }
    }
}
