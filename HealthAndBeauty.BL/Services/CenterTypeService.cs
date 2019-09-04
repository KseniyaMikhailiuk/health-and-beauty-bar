using HealthAndBeauty.BL.Contracts;
using HealthAndBeauty.BL.Models;
using HealthAndBeauty.DAL.Contracts;
using Mapster;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HealthAndBeauty.BL.Services
{
    public class CenterTypeService: ICenterTypeService
    {
        private readonly ICenterTypeRepository _repository;

        public CenterTypeService(ICenterTypeRepository repository)
        {
            _repository = repository;
        }

        public async Task<IReadOnlyCollection<CenterTypeModel>> GetAllAsync()
        {
            return (await _repository.GetAllAsync()).Adapt<IReadOnlyCollection<CenterTypeModel>>();
        }
    }
}
