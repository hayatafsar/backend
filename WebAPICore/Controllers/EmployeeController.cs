using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPICore.IServices;
using WebAPICore.Models;

namespace WebAPICore.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService employeeService;
        public EmployeeController(IEmployeeService employee)
        {
            employeeService = employee;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Employee/GetEmployee")]
        public IActionResult GetEmployee()
        {
            return Ok(employeeService.GetEmployee());
        }
        [HttpPost]
        [Route("[action]")]
        [Route("api/Employee/AddEmployee")]
        public IActionResult AddEmployee([FromBody] Employee employee)
        {
            var obj=employeeService.AddEmployee(employee);
            if(obj != null)
            {
                return Ok(obj);
            }
            return null;
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/Employee/EditEmployee")]
        public Employee EditEmployee([FromBody] Employee employee)
        {
            return employeeService.UpdateEmployee(employee);
        }
        [HttpDelete]
        [Route("[action]")]
        [Route("api/Employee/DeleteEmployee")]
        public Employee DeleteEmployee([FromHeader] int id)
        {
            return employeeService.DeleteEmployee(id);
        }
        [HttpGet]
        [Route("[action]")]
        [Route("api/Employee/GetEmployeeId")]
        public Employee GetEmployeeId([FromHeader] int id)
        {
            return employeeService.GetEmployeeById(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Employee/GetPost")]
        public TblUserPost GetPost([FromHeader] Guid userguid)
        {
          return employeeService.GetPost(userguid);
        }
    }
}
