using System;

namespace HealthAndBeauty.DB.Entities
{
    public class WorkingHours
    {
        public int WeekDayId { get; set; }
        public int CenterId { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        public Center Center { get; set; }
    }
}
