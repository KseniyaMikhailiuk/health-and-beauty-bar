using System.Collections.Generic;

namespace HealthAndBeauty.ViewModels
{
    public class CenterVM
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string MainImageUrl { get; set; }

        public int CenterTypeId { get; set; }

        public IReadOnlyCollection<WorkingHoursVM> WorkingHours { get; set; }
    }
}
