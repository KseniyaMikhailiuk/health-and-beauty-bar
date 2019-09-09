using HealthAndBeauty.DB.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HealthAndBeauty.DAL.Contracts
{
    public interface IWorkingHoursRepository
    {
        Task UpdateRangeAsync();
        Task EditAsync(int centerId, int weekdayId);
        Task DeleteAsync(int centerId, int weekdayId);
        Task<WorkingHours> GetAllByCenterIdAsync(int centerId);
    }
}
