using System.Collections.Generic;

namespace HealthAndBeauty.DB.Entities
{
    public class Service
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public ICollection<CenterService> CenterServices { get; set; }
    }
}
