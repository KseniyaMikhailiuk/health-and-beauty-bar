using System;
using System.ComponentModel.DataAnnotations;

namespace HealthAndBeauty.ViewModels
{
    public class WorkingHoursVM
    {
        [EnumDataType(typeof(DayOfWeek))]
        public DayOfWeek WeekDayId { get; set; }
        public int CenterId { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public bool IsClosed { get; set; }
    }
}
