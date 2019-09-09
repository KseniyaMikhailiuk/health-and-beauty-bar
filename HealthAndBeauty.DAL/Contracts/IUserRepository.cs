using HealthAndBeauty.DB.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HealthAndBeauty.DAL.Contracts
{
    public interface IUserRepository
    {
        Task<int> CreateAsync(User user);
        Task<int> DeleteAsync(User user);
        Task<User> FindByIdAsync(int userId);
        Task<User> FindByNameAsync(string normalizedUserName);
        Task<User> FindByEmailAsync(string email);
        Task UpdateAsync(User user);
        Task<IEnumerable<User>> GetAllAsync();
    }
}
