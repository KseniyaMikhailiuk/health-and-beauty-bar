namespace HealthAndBeauty.BL.Models
{
    public class CenterServiceModel
    {
        public int Id { get; set; }
        public int CenterId { get; set; }
        public int ServiceId { get; set; }
        public ServiceModel Service { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }
    }
}
