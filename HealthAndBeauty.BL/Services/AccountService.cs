using System.Threading.Tasks;
using HealthAndBeauty.BL.Contracts;
using HealthAndBeauty.BL.Models;
using HealthAndBeauty.DAL.Contracts;
using HealthAndBeauty.DB.Entities;
using Mapster;

namespace HealthAndBeauty.BL.Services
{
    public class AccountService : IAccountService
{
        private readonly IUserRepository _repository;

        public AccountService(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task LoginAsync(LoginModel user)
        {

        }

        public async Task RegisterAsync(RegisterModel registerModel)
        {
            await _repository.CreateAsync(registerModel.Adapt<User>());
        }
    }
}
