using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthAndBeauty.BL.Contracts;
using HealthAndBeauty.BL.Models;
using HealthAndBeauty.ViewModels;
using Mapster;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HealthAndBeauty.Controllers
{
    [Route("api/centers/{centerId}/working-hours")]
    [ApiController]
    public class WorkingHoursController : Controller
    {
        private readonly IWorkingHoursService _service;

        public WorkingHoursController(IWorkingHoursService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllByCenterIdAsync(int centerId)
        {
            var workingHours = await _service.GetAllByCenterIdAsync(centerId);

            return Ok(workingHours.Adapt<IReadOnlyCollection<WorkingHoursVM>>());
        }

        [HttpPost]
        public async Task<IActionResult> UpdateRangeAsync(WorkingHoursVM[] workingHours)
        {
            await _service.UpdateRangeAsync(workingHours.Adapt<WorkingHoursModel[]>());

            return Ok();
        }
    }
}
