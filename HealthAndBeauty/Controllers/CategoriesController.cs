using System.Collections.Generic;
using System.Threading.Tasks;
using HealthAndBeauty.BL.Contracts;
using HealthAndBeauty.ViewModels;
using Mapster;
using Microsoft.AspNetCore.Mvc;

namespace HealthAndBeauty.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : Controller
    {
        private readonly ICategoryService _service;
        public CategoriesController(ICategoryService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok((await _service.GetAllAsync()).Adapt<IReadOnlyCollection<CategoryVM>>());
        }
    }
}
