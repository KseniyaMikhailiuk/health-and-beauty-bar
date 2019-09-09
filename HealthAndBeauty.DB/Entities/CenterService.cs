namespace HealthAndBeauty.DB.Entities
{
    public class CenterService
    {
        public int Id { get; set; }
        public int CenterId { get; set; }
        public int ServiceId { get; set; }
        public Center Center { get; set; }
        public Service Service { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }
    }
}
