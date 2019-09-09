using System;

namespace HealthAndBeauty.ViewModels
{
    public class WorkingHoursVM
    {
        public int WeekDayId { get; set; }
        public int CenterId { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
    }
}
