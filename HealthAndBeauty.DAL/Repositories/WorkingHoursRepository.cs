using HealthAndBeauty.DAL.Contracts;
using HealthAndBeauty.DB.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using HealthAndBeauty.DB;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HealthAndBeauty.DAL.Repositories
{
    public class WorkingHoursRepository : IWorkingHoursRepository
    {
        private readonly HBContext _context;

        public WorkingHoursRepository(HBContext context)
        {
            _context = context;
        }

        public async Task<IReadOnlyCollection<WorkingHours>> GetAllByCenterIdAsync(int centerId)
        {
            return await _context.WorkingHours.Where(wh => wh.CenterId == centerId).ToListAsync();
        }

        public async Task UpdateRangeAsync(WorkingHours[] workingHours)
        {
            _context.WorkingHours.UpdateRange(workingHours);

            await _context.SaveChangesAsync();
        }

        public async Task CreateRangeAsync(WorkingHours[] workingHours)
        {
            _context.WorkingHours.AddRange(workingHours);

            await _context.SaveChangesAsync();
        }
    }
}
