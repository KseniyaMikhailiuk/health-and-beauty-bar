using System;
using System.Threading.Tasks;
using HealthAndBeauty.BL.Contracts;
using HealthAndBeauty.BL.Models;
using HealthAndBeauty.DB.Entities;
using Mapster;
using Microsoft.AspNetCore.Identity;

namespace HealthAndBeauty.BL.Services
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<User> _userManager;

        public AccountService(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task LoginAsync(LoginModel user)
        {
        }

        public async Task RegisterAsync(RegisterModel registerModel)
        {
            var result = await _userManager.CreateAsync(registerModel.Adapt<User>(), registerModel.Password);

            if (!result.Succeeded)
            {
                throw new Exception();
            }
        }
    }
}
