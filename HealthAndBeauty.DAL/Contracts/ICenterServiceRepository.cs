using HealthAndBeauty.DB.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HealthAndBeauty.DAL.Contracts
{
    public interface ICenterServiceRepository
    {
        Task<IReadOnlyCollection<CenterService>> GetAllAsync(int centerId);
        Task<int> CreateAsync(CenterService centerService);
        Task UpdateAsync(CenterService centerService);
        Task<CenterService> GetByIdAsync(int id);
    }
}
