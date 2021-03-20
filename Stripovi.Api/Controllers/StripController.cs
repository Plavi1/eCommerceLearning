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

        [HttpGet("{search}/{naziv}")]  //mozes i bez ovog /{naziv}, ali posto je jedna stavka bolje je ovako
        public async Task<ActionResult<IEnumerable<Strip>>> Search(string naziv)
        {
            try
            {
               var result = await stripRepository.Search(naziv);

                if (result.Any())
                {
                    return Ok(result);
                }
                return NotFound();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                    "Error retrieving data from the database");
            }
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
        [HttpPut("{id:int}")]
        public async Task<ActionResult<Strip>> UpdateStrip(int id, Strip strip)
        {
            try
            {
                if(id != strip.IdStripa)
                {
                    return BadRequest("Strip ID mismatch");
                }
                var stripToUpdate = await stripRepository.GetStrip(id);
                if(stripToUpdate == null)
                {
                    return NotFound($"Strip with Id={id} not found");
                }
                return await stripRepository.UpdateStrip(strip);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                          "Error updating data");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Strip>> DeleteStrip(int id)
        {
            try
            {
                var stripToDelete = await stripRepository.GetStrip(id);
                if(stripToDelete == null)
                {
                    return NotFound($"Strip with Id={id} not found");
                }
                return await stripRepository.DeleteStrip(id);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                          "Error deleting data");
            }
        }







    }
}
