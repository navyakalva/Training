using SampleWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using SampleWebAPI.Repositories;

namespace SampleWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        
        private readonly IEmpRepository _repo;
        public EmployeeController(IEmpRepository repo)
        {
            _repo = repo;
        }
        [HttpPut]
        [Route("UpdateEmployee")]

        public IActionResult UpdateEmployee(EmpDetails emp)
        {
             
             try
            {
               _repo.UpdateEmployee(emp);
                return Ok();
            }
            catch(Exception e)
            {
                return Ok(e.InnerException.Message);
            }
        }
        [HttpGet]
        [Route("GetEmployee/{id}")]
        public IActionResult GetEmployee(string id)
        {
            try
            {
                return Ok(_repo.GetEmployee(id));
            }
            catch(Exception e)
            {
                return NotFound(e.Message);
            }
        }
        [HttpDelete]
        [Route("DeleteEmployee/{id}")]
        public IActionResult DeleteEmployee(string id)
        {
            try
            {
                _repo.DeleteEmployee(id);
                return Ok();
            }
            catch(Exception e)
            {
                return Ok(e.InnerException.Message);
            }
        }
        [HttpPost]
        [Route("AddEmployee")]
        public IActionResult AddEmployee(EmpDetails emp)
        {
            try
            {
                _repo.AddEmployee(emp);
                return Ok();
            }
            catch(Exception e)
            {
                return Ok(e.InnerException.Message);
            }
        }
    
    }
}
