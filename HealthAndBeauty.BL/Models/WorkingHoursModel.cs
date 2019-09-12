using System;

namespace HealthAndBeauty.BL.Models
{
    public class WorkingHoursModel
    {
        public int WeekDayId { get; set; }
        public int CenterId { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public bool IsClosed { get; set; }
    }
}
