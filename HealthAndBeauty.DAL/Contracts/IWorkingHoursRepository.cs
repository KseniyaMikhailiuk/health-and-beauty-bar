using HealthAndBeauty.DB.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HealthAndBeauty.DAL.Contracts
{
    public interface IWorkingHoursRepository
    {
        Task CreateRangeAsync(WorkingHours[] workingHours);
        Task UpdateRangeAsync(WorkingHours[] workingHours);
        Task<IReadOnlyCollection<WorkingHours>> GetAllByCenterIdAsync(int centerId);
    }
}
