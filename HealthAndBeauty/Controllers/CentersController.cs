using HealthAndBeauty.BL.Contracts;
using HealthAndBeauty.BL.Models;
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

        [HttpPost]
        public async Task<IActionResult> CreateAsync(CenterVM center)
        {
            return Ok(await _service.CreateAsync(center.Adapt<CenterModel>()));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(CenterVM center)
        {
            return Ok(await _service.CreateAsync(center.Adapt<CenterModel>()));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            return Ok((await _service.GetByIdAsync(id)).Adapt<CenterVM>());
        }
    }
}
