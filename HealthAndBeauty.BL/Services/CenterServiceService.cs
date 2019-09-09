using HealthAndBeauty.BL.Contracts;
using HealthAndBeauty.BL.Models;
using HealthAndBeauty.DAL.Contracts;
using Mapster;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities = HealthAndBeauty.DB.Entities;

namespace HealthAndBeauty.BL.Services
{
    public class CenterServiceService: ICenterServiceService
    {
        private readonly ICenterServiceRepository _repository;

        public CenterServiceService(ICenterServiceRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> CreateAsync(CenterServiceModel centerService)
        {
            return await _repository.CreateAsync(centerService.Adapt<Entities.CenterService>());
        }

        public async Task<IEnumerable<CenterCategoryModel>> GetAllGroupedByCategoryAsync(int centerId)
        {
            var services = await _repository.GetAllAsync(centerId);
            var groupedServices = services.GroupBy(
                service => new { service.Service.CategoryId, service.Service.Category.Name }, 
                (s, array) => new CenterCategoryModel()
                {
                    Id = s.CategoryId,
                    Name = s.Name,
                    Services = array.Adapt<IReadOnlyCollection<CenterServiceModel>>()
                }
            );
            return groupedServices;
        }

        public async Task UpdateAsync(CenterServiceModel centerService)
        {
            var centerServiceEntity = await _repository.GetByIdAsync(centerService.Id);

            centerServiceEntity = centerService.Adapt(centerServiceEntity);

            await _repository.UpdateAsync(centerServiceEntity);
        }
    }
}
