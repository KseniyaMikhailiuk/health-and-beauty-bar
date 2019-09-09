using HealthAndBeauty.DAL.Contracts;
using HealthAndBeauty.DB.Entities;
using Mapster;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using HealthAndBeauty.DB;

namespace HealthAndBeauty.DAL.Repositories
{
    public class CenterRepository : ICenterRepository
    {
        private readonly HBContext _context;

        public CenterRepository(HBContext context)
        {
            _context = context;
        }

        public async Task<int> CreateAsync(Center center)
        {
            _context.Centers.Add(center);
            await _context.SaveChangesAsync();
            return center.Id;
        }

        public async Task UpdateAsync(Center center)
        {        
            _context.Update(center);

            await _context.SaveChangesAsync();
        }

        public async Task<IReadOnlyCollection<Center>> GetAllAsync()
        {
            return await _context
                .Centers
                .Include(c => c.WorkingHours)
                .ToListAsync();
        }

        public async Task<Center> GetByIdAsync(int id)
        {
            return await _context
                .Centers
                .Include(c => c.WorkingHours)
                .FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
