using HealthAndBeauty.BL.Models;
using System.Threading.Tasks;

namespace HealthAndBeauty.BL.Contracts
{
    public interface IAccountService
    {
        Task LoginAsync(LoginModel user);
        Task RegisterAsync(RegisterModel registerModel);
    }
}
