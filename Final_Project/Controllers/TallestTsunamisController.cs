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
    public class TallestTsunamisController : ControllerBase
    {
        private readonly ILogger<TallestTsunamisController> _logger;
        private readonly ITsunamiContextDAO _context;

        public TallestTsunamisController(ILogger<TallestTsunamisController> logger, ITsunamiContextDAO context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(value: _context.GetAllTsunamis());
        }

        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            var tsunami = _context.GetTsunamiById(id);
            if (tsunami == null)
                return NotFound(id);

            return Ok(tsunami);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var result = _context.RemoveTsunamiById(id);
 
            if (result == null)
                return NotFound(id);

            if (result == 0)
                return StatusCode(500, "An error occurred while processing your request");

            return Ok();

        }

        [HttpPut]

        public IActionResult Put(Tsunami tsunami)
        {
            var result = _context.UpdateTsunami(tsunami);

            if (result == null)
                return NotFound(tsunami.Id);

            if (result == 0)
                return StatusCode(500, "An error occurred while processing your request");

            return Ok();
        }

        [HttpPost]
        public IActionResult Post(Tsunami tsunami)
        {
            var result = _context.Add(tsunami);

            if (result == null)
                return StatusCode(500, "Team already exists");

            if (result == 0)
                return StatusCode(500, "An error occurred while processing your request");

            return Ok();
        }
    }
}
