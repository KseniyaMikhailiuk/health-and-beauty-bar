using HealthAndBeauty.DAL.Contracts;
using HealthAndBeauty.DB.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using HealthAndBeauty.DB;

namespace HealthAndBeauty.DAL.Repositories
{
    public class WorkingHoursRepository : IWorkingHoursRepository
    {
        private readonly HBContext _context;

        public WorkingHoursRepository(HBContext context)
        {
            _context = context;
        }

        public Task DeleteAsync(int centerId, int weekdayId)
        {
            throw new NotImplementedException();
        }

        public Task EditAsync(int centerId, int weekdayId)
        {
            throw new NotImplementedException();
        }

        public Task<WorkingHours> GetAllByCenterIdAsync(int centerId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateRangeAsync()
        {
            throw new NotImplementedException();
        }
    }
}
