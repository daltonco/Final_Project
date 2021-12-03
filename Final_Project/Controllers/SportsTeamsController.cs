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

        public SportsTeamsController(ILogger<SportsTeamsController> logger, ISportsContextDAO context)
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

        [HttpDelete]
        public IActionResult Delete(int Id) {

            var result = _context.RemoveTeamById(Id);

            if (result == null)
                return NotFound(Id);

            if (result == 0)
                return StatusCode(500, "An error occured while processing your code");

            return Ok();

        }

        [HttpPut]
        public IActionResult Put(Teams team)
        {
            var result = _context.UpdateTeam(team);

            if (result == null)
                return NotFound(team.Id);

            if (result == 0)
                return StatusCode(500, "An error occured while processing your code");

            return Ok();

        }
        [HttpPost]
        public IActionResult Post (Teams team)
        {
            var result = _context.Add(team);

            if (result == null)
                return StatusCode(500, "Team Already Exists");

            if (result == 0)
                return StatusCode(500, "An error occurred");

            return Ok();
        }
    }
    }