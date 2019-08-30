using HealthAndBeauty.DAL.Contracts;
using HealthAndBeauty.DB.Entities;
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

        public async Task<IReadOnlyCollection<Center>> GetAllAsync()
        {
            return await _context.Centers.ToListAsync();
        }
    }
}
