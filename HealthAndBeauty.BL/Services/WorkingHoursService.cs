using HealthAndBeauty.BL.Contracts;
using HealthAndBeauty.BL.Models;
using HealthAndBeauty.DAL.Contracts;
using HealthAndBeauty.DB.Entities;
using Mapster;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HealthAndBeauty.BL.Services
{
    public class WorkingHoursService : IWorkingHoursService
    {
        private readonly IWorkingHoursRepository _repository;

        public WorkingHoursService(IWorkingHoursRepository repository)
        {
            _repository = repository;
        }

        public async Task<IReadOnlyCollection<WorkingHoursModel>> GetAllByCenterIdAsync(int centerId)
        {
            return (await _repository.GetAllByCenterIdAsync(centerId)).Adapt<IReadOnlyCollection<WorkingHoursModel>>();
        }

        public async Task UpdateRangeAsync(WorkingHoursModel[] workingHours)
        {
            await _repository.UpdateRangeAsync(workingHours.Adapt<WorkingHours[]>());
        }
    }
}
