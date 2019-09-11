using System.Collections.Generic;

namespace HealthAndBeauty.BL.Models
{
    public class CenterModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string MainImageUrl { get; set; }

        public int CenterTypeId { get; set; }

        public IReadOnlyCollection<WorkingHoursModel> WorkingHours { get; set; }
    }
}
