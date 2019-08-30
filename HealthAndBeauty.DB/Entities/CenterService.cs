namespace HealthAndBeauty.DB.Entities
{
    public class CenterService
    {
        public int CenterId { get; set; }
        public int ServiceId { get; set; }
        public Center Center { get; set; }
        public Service Service { get; set; }
    }
}
