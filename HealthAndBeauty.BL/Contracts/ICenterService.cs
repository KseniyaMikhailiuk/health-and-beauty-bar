using HealthAndBeauty.BL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HealthAndBeauty.BL.Contracts
{
    public interface ICenterService
    {
        Task<IReadOnlyCollection<CenterModel>> GetAllAsync();
        Task<int> CreateAsync(CenterModel center);
        Task UpdateAsync(CenterModel center);
        Task<CenterModel> GetByIdAsync(int id);
    }
}
