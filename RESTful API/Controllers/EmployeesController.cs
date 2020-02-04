using CoreCodeCamp.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTful.API.Controllers
{
    [Route("api/[Controller]")]
    public class EmployeesController : ControllerBase
    {
        private ICampRepository _repository;
        public EmployeesController(ICampRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
       public async Task<IActionResult> Get()
        {
            try
            {
                var result = await _repository.GetAllCampsAsync();

                return Ok(result);
            }
            catch (Exception e)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError,"Database Failure");
            }
            
        }
    }
}
