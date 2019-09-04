using HealthAndBeauty.DAL.Contracts;
using HealthAndBeauty.DB.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Umwa.DB;

namespace HealthAndBeauty.DAL.Repositories
{
    public class CenterServiceRepository: ICenterServiceRepository
    {
        private readonly HBContext _context;

        public CenterServiceRepository(HBContext context)
        {
            _context = context;
        }

        public async Task<int> CreateAsync(CenterService centerService)
        {
            _context.CenterServices.Add(centerService);
            await _context.SaveChangesAsync();
            return centerService.Id;
        }

        public async Task<IReadOnlyCollection<CenterService>> GetAllAsync(int centerId)
        {
            return await _context
                .CenterServices
                .Include(sc => sc.Service)
                    .ThenInclude(s => s.Category)
                .Where(sc => sc.CenterId == centerId)
                .ToListAsync(); 
        }

        public async Task<CenterService> GetByIdAsync(int id)
        {
            return await _context
                .CenterServices
                .Include(s => s.Service)
                .FirstOrDefaultAsync(cs => cs.Id == id);
        }

        public async Task UpdateAsync(CenterService centerService)
        {
            _context.CenterServices.Update(centerService);
            await _context.SaveChangesAsync();
        }
    }
}
