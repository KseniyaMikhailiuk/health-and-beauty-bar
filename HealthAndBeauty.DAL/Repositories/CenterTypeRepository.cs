using HealthAndBeauty.DAL.Contracts;
using HealthAndBeauty.DB.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using HealthAndBeauty.DB;

namespace HealthAndBeauty.DAL.Repositories
{
    public class CenterTypeRepository: ICenterTypeRepository
    {
        private readonly HBContext _context;

        public CenterTypeRepository(HBContext context)
        {
            _context = context;
        }

        public async Task<IReadOnlyCollection<CenterType>> GetAllAsync()
        {
            return await _context.CenterTypes.ToListAsync();
        }
    }
}
