using System.Threading.Tasks;
using HealthAndBeauty.BL.Contracts;
using HealthAndBeauty.BL.Models;
using HealthAndBeauty.ViewModels;
using Mapster;
using Microsoft.AspNetCore.Mvc;

namespace HealthAndBeauty.Controllers
{
    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        private readonly IAccountService _service;

        public AccountController(IAccountService service)
        {
            _service = service;
        }

        public async Task<IActionResult> RegisterAsync(RegisterVM registerInfo)
        {
            await _service.RegisterAsync(registerInfo.Adapt<RegisterModel>());

            return Ok();
        }
    }
}
