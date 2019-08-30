using HealthAndBeauty.DB.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HealthAndBeauty.DAL.Contracts
{
    public interface ICenterRepository
    {
        Task<IReadOnlyCollection<Center>> GetAllAsync();
    }
}
