using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HealthAndBeauty.BL.Contracts
{
    public interface IWorkingHoursService
    {
        Task UpdateRangeAsync();
        Task EditAsync(int centerId, int weekdayId);
        Task DeleteAsync(int centerId, int weekdayId);
    }
}
