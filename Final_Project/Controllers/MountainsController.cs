using Final_Project.Data;
using Final_Project.Interfaces;
using Final_Project.Models;
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
            var result = _context.RemoveMountainById(id);
            if (result == null)
            {
                return NotFound(id);
            }
            if (result == 0) 
            {
                return StatusCode(500, "An error occurred while processing your request.");
            }
            return Ok();

        }

        [HttpPut]
        public IActionResult Put(Mountain mountain)
        {
            var result = _context.UpdateMountain(mountain);
            if (result == null)
            {
                return NotFound(mountain.Id);
            }
            if (result == 0)
            {
                return StatusCode(500, "An error occurred while processing your request.");
            }
            return Ok();

        }

        [HttpPost]
        public IActionResult Post(Mountain mountain)
        {
            var result = _context.Add(mountain);
            if(result == null)
            {
                return StatusCode(500, "Mountain already exists.");
            }
            if(result == 0)
            {
                return StatusCode(500, "An error occurred processing your request.");
            }
            return Ok();
        }

        //post
        //put
        //delete
    }
}
