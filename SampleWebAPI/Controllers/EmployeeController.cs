using SampleWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using SampleWebAPI.Repositories;

namespace EmployeeDetailsApp.Controllers
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

        public void UpdateEmployee(EmpDetails emp)
        {
             _repo.UpdateEmployee(emp);
        }
        [HttpGet]
        [Route("GetEmployee/{id}")]
        public IActionResult GetEmployee(int id)
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
        public IActionResult DeleteEmployee(int id)
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