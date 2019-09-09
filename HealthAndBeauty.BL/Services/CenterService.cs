using HealthAndBeauty.BL.Contracts;
using HealthAndBeauty.BL.Models;
using HealthAndBeauty.DAL.Contracts;
using HealthAndBeauty.DB.Entities;
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

        public async Task<int> CreateAsync(CenterModel center)
        {
            return await _repository.CreateAsync(center.Adapt<Center>());
        }

        public async Task UpdateAsync(CenterModel center)
        {
            Center centerEntity = await _repository.GetByIdAsync(center.Id);
            centerEntity = center.Adapt(centerEntity);
            await _repository.UpdateAsync(centerEntity);
        }

        public async Task<IReadOnlyCollection<CenterModel>> GetAllAsync()
        {

            return (await _repository.GetAllAsync()).Adapt<IReadOnlyCollection<CenterModel>>();
        }

        public async Task<CenterModel> GetByIdAsync(int id)
        {
            return (await _repository.GetByIdAsync(id)).Adapt<CenterModel>();
        }
    }
}
