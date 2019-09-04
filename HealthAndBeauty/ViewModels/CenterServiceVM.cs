namespace HealthAndBeauty.ViewModels
{
    public class CenterServiceVM
    {
        public int Id { get; set; }
        public int CenterId { get; set; }
        public int ServiceId { get; set; }
        public ServiceVM Service { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }
    }
}
