using HealthAndBeauty.DB.Entities;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HealthAndBeauty.DAL.Contracts
{
    interface IUserRepository
    {
        Task<IdentityResult> CreateAsync(User user);
        Task<IdentityResult> DeleteAsync(User user);
        Task<User> FindByIdAsync(string userId);
        Task<User> FindByNameAsync(string normalizedUserName);
        Task<User> FindByEmailAsync(string normalizedEmail);
        Task<IdentityResult> UpdateAsync(User user);
        Task<IEnumerable<User>> GetAllUsers();
    }
}
