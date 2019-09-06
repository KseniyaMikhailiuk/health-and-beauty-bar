using System.Collections.Generic;

namespace HealthAndBeauty.DB.Entities
{
    public class Center
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string MainImageUrl { get; set; }

        public int CenterTypeId { get; set; }

        public CenterType CenterType { get; set; }

        public ICollection<CenterService> CenterServices { get; set; }

        public ICollection<WorkingHours> WorkingHours { get; set; }
    }
}
