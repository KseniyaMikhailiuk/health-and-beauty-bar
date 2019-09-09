using System.Collections.Generic;
using System.Threading.Tasks;
using HealthAndBeauty.BL.Contracts;
using HealthAndBeauty.BL.Models;
using HealthAndBeauty.ViewModels;
using Mapster;
using Microsoft.AspNetCore.Mvc;

namespace HealthAndBeauty.Controllers
{
    [Route("api/centers/{centerId}/services")]
    [ApiController]
    public class CenterServicesController : Controller
    {
        private readonly ICenterServiceService _service;

        public CenterServicesController(ICenterServiceService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync(int centerId)
        {
            return Ok((await _service.GetAllGroupedByCategoryAsync(centerId)).Adapt<IReadOnlyCollection<CenterCategoryVM>>());
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(CenterServiceVM centerService)
        {
            return Ok(await _service.CreateAsync(centerService.Adapt<CenterServiceModel>()));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync(CenterServiceVM centerService)
        {
            await _service.UpdateAsync(centerService.Adapt<CenterServiceModel>());

            return Ok();
        }
    }
}
