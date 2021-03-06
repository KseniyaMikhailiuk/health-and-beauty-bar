﻿using HealthAndBeauty.BL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HealthAndBeauty.BL.Contracts
{
    public interface IWorkingHoursService
    {
        Task CreateRangeAsync(WorkingHoursModel[] workingHours);
        Task UpdateRangeAsync(WorkingHoursModel[] workingHours);
        Task<IReadOnlyCollection<WorkingHoursModel>> GetAllByCenterIdAsync(int centerId);
    }
}
