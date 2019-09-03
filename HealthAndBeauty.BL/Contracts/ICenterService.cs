using HealthAndBeauty.BL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HealthAndBeauty.BL.Contracts
{
    public interface ICenterService
    {
        Task<IReadOnlyCollection<CenterModel>> GetAllAsync();
        Task<int> CreateAsync(CenterModel center);
    }
}
