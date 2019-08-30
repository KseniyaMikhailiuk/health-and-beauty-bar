using HealthAndBeauty.BL.Contracts;
using HealthAndBeauty.BL.Models;
using HealthAndBeauty.DAL.Contracts;
using Mapster;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HealthAndBeauty.BL.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;

        public CategoryService(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<IReadOnlyCollection<CategoryModel>> GetAllAsync()
        {
            return (await _repository.GetAllAsync()).Adapt<IReadOnlyCollection<CategoryModel>>();
        }
    }
}
