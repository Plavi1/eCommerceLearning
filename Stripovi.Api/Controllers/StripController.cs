using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stripovi.Data.Models;
using Stripovi.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stripovi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StripController : ControllerBase
    {
        private readonly IStripRepository stripRepository;

        public StripController(IStripRepository stripRepository)
        {
            this.stripRepository = stripRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetStripovi()
        {
            try
            {
                return Ok( await stripRepository.GetStripovi());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
            
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Strip>> GetStrip(int id)
        {
            try
            {
                var result = await stripRepository.GetStrip(id);

                if(result == null)
                {
                    return NotFound();
                }
                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                    "Error retrieving data from the database");
            }
        }
        [HttpPost]
        public async Task<ActionResult<Strip>> CreateStrip(Strip strip)
        {
            try
            {
                if(strip == null)
                {
                    return BadRequest();
                }
                var createdStrip = await stripRepository.AddStrip(strip);
                return CreatedAtAction(nameof(GetStrip), new {id=createdStrip.IdStripa}, createdStrip); 
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                                    "Error retrieving data from the database");
            }
        }







    }
}
