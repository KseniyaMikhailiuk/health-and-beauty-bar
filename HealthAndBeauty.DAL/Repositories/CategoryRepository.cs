using HealthAndBeauty.DAL.Contracts;
using HealthAndBeauty.DB.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Umwa.DB;

namespace HealthAndBeauty.DAL.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly HBContext _context;

        public CategoryRepository(HBContext context)
        {
            _context = context;
        }

        public async Task<IReadOnlyCollection<Category>> GetAllAsync()
        {
            return await _context
                .Categories
                .Include(c => c.Services)
                .ToListAsync();
        }
    }
}
