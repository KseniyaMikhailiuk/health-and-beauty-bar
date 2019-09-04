using HealthAndBeauty.DB.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HealthAndBeauty.DAL.Contracts
{
    public interface ICenterRepository
    {
        Task<IReadOnlyCollection<Center>> GetAllAsync();
        Task<int> CreateAsync(Center center);
        Task UpdateAsync(Center center);
        Task<Center> GetByIdAsync(int id);
    }
}
