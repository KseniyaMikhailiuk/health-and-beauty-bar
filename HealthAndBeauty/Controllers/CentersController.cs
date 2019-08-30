using HealthAndBeauty.BL.Contracts;
using HealthAndBeauty.ViewModels;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HealthAndBeauty.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CentersController : Controller
    {
        private readonly ICenterService _service;
        public CentersController(ICenterService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok((await _service.GetAllAsync()).Adapt<IReadOnlyCollection<CenterVM>>());
        }
    }
}
