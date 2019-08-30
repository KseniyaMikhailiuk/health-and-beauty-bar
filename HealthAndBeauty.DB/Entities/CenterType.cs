using System.Collections.Generic;

namespace HealthAndBeauty.DB.Entities
{
    public class CenterType
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Center> Centers { get; set; }
    }
}
