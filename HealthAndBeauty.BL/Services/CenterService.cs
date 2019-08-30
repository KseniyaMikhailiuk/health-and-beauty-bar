using HealthAndBeauty.BL.Contracts;
using HealthAndBeauty.BL.Models;
using HealthAndBeauty.DAL.Contracts;
using Mapster;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HealthAndBeauty.BL.Services
{
    public class CenterService : ICenterService
    {
        private readonly ICenterRepository _repository;

        public CenterService(ICenterRepository repository)
        {
            _repository = repository;
        }

        public async Task<IReadOnlyCollection<CenterModel>> GetAllAsync()
        {
            return (await _repository.GetAllAsync()).Adapt<IReadOnlyCollection<CenterModel>>();
        }
    }
}
