using HealthAndBeauty.BL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HealthAndBeauty.BL.Contracts
{
    public interface ICenterTypeService
    {
        Task<IReadOnlyCollection<CenterTypeModel>> GetAllAsync();
    }
}
