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
    public class SportsTeamsController : ControllerBase
    {
        //Alex Gajic
        private readonly ILogger<SportsTeamsController> _logger;
        private readonly ISportsContextDAO _context;

        public SportsTeamsController(ILogger<SportsTeamsController> logger, SportsContextDAO context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.GetAllTeams());
        }

        [HttpGet("Id")]
        public IActionResult GetById(int Id)
        {
            var team = _context.GetTeamById(Id);
            if (team == null)
                return NotFound(Id);

            return Ok(_context.GetTeamById(Id));
        }
    }
}