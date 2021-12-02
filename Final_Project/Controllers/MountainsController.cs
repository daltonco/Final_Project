using Final_Project.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MountainsController : ControllerBase
    {
        private readonly ILogger<MountainsController> _logger;
        private readonly MountainsContext _context;

        public MountainsController(ILogger<MountainsController> logger, MountainsContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.TallestMountains.ToList());
        }
    }
}
