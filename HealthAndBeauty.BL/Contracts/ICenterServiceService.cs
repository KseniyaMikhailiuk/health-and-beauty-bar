using HealthAndBeauty.BL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HealthAndBeauty.BL.Contracts
{
    public interface ICenterServiceService
    {
        Task<IEnumerable<CenterCategoryModel>> GetAllGroupedByCategoryAsync(int centerId);
        Task<int> CreateAsync(CenterServiceModel centerService);
        Task UpdateAsync(CenterServiceModel centerService);
    }
}
