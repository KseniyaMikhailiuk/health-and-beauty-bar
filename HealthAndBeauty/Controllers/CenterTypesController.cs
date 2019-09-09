using System.Collections.Generic;
using System.Threading.Tasks;
using HealthAndBeauty.BL.Contracts;
using HealthAndBeauty.ViewModels;
using Mapster;
using Microsoft.AspNetCore.Mvc;

namespace HealthAndBeauty.Controllers
{
    [Route("api/center-types")]
    [ApiController]
    public class CenterTypesController : Controller
    {
        private readonly ICenterTypeService _service;

        public CenterTypesController(ICenterTypeService service)
        {
            _service = service;
        }

        public async Task<IActionResult> GetAllAsync()
        {
            return Ok((await _service.GetAllAsync()).Adapt<IReadOnlyCollection<CenterTypeVM>>());
        }
    }
}
