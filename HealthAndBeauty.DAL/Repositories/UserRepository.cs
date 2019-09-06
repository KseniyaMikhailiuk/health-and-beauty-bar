using HealthAndBeauty.DAL.Contracts;
using HealthAndBeauty.DB.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Umwa.DB;

namespace HealthAndBeauty.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly HBContext _context;

        public UserRepository(HBContext context)
        {
            _context = context;
        }

        public async Task<int> CreateAsync(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return user.Id;
        }

        public Task<int> DeleteAsync(User user)
        {
            throw new NotImplementedException();
        }

        public async Task<User> FindByEmailAsync(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task<User> FindByIdAsync(int userId)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Id == userId);
        }

        public Task<User> FindByNameAsync(string normalizedUserName)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task UpdateAsync(User user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
        }
    }
}
