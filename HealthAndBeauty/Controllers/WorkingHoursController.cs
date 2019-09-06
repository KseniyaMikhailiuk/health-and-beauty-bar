using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthAndBeauty.BL.Contracts;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HealthAndBeauty.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkingHoursController : Controller
    {
        private readonly IWorkingHoursService _service;

        public WorkingHoursController(IWorkingHoursService service)
        {
            _service = service;
        }
    }
}
