using Final_Project.Data;
using Final_Project.Interfaces;
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
        //COLTON DALTON
        private readonly ILogger<MountainsController> _logger;
        private readonly IMountainsContextDAO _context;

        public MountainsController(ILogger<MountainsController> logger, IMountainsContextDAO context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.GetAllMountains());
        }

        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            var mountain = _context.GetMountainById(id);
            if(mountain == null)
            {
                return NotFound(id);
            }
            return Ok(_context.GetMountainById(id));
        }

        [HttpDelete]
        public IActionResult DeleteById(int id)
        {
            var mountain = _context.RemoveMountainById(id);
            if (mountain == null)
            {
                return NotFound(id);
            }
            if (string.IsNullOrEmpty(mountain.Name)) 
            {
                return StatusCode(500, "An error occurred while processing your request.");
            }
            return Ok();

        }

        //post
        //put
        //delete
    }
}
