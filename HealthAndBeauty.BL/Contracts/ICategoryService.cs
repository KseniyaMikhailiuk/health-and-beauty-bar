using HealthAndBeauty.BL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HealthAndBeauty.BL.Contracts
{
    public interface ICategoryService
    {
        Task<IReadOnlyCollection<CategoryModel>> GetAllAsync();
    }
}
