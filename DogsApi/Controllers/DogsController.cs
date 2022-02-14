using Declarations;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogsApi.Controllers
{
    [Route("api/dogs")]
    [ApiController]
    public class DogsController : ControllerBase
    {
        private readonly IRepositoryManager repository;

        public DogsController(IRepositoryManager _repository)
        {
            repository = _repository;
        }

        [HttpGet]
        [Route("ping")]
        public IActionResult Ping()
        {
            return Ok("Dogs house service. Version 1.0.1");
        }

        [HttpGet]
        public IActionResult GetDogs()
        {
            try
            {
                var dogs = repository.Dog.GetAllDogs(trackChanges: false);
                return Ok(dogs);
            } catch(Exception e)
            {
                return StatusCode(500, "Internel server error"); 
            }
        }

        [HttpPost]
        public IActionResult Dog([FromBody] Dog dog)
        {
            return Ok();
        }
    }
}
