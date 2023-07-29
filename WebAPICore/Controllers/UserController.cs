using Microsoft.AspNetCore.Authorization;
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
    public class UserController : Controller
    {
        public readonly IUserService userService;
        public UserController(IUserService _userService)
        {

            userService = _userService;
        }


        [HttpGet]
        [Route("[action]")]
        [Route("api/users/GetById")]
       
        public IActionResult GetById([FromHeader] Guid userguid)
        {
            TblUsers objtblUser = new TblUsers();
            objtblUser = userService.GetById(userguid);
            return Ok(objtblUser);
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/user/AddUser")]
        public IActionResult AddUser([FromBody] TblUsers objuser)
        {
            var obj = userService.AddUser(objuser);
            if (obj != null)
            {
                return Ok(obj);
            }
            return null;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/user/GetByUserNamePassword")]

        public IActionResult GetByUserNamePassword([FromHeader] string email, [FromHeader] string password)
        { 
           TblUsers objtblUser = userService.GetByUserNamePassword(email,password);
            if(objtblUser != null)
            {
             return Ok(objtblUser);
            }
            return null;
           
        }
    }
}