using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebAPI.Model;
using System.Text.Json;
using WebAPI.Data;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private IUserService UserService;
        public UserController(IUserService userService){
            this.UserService = userService;
        }

        [HttpGet]
        public ActionResult<User> validateUser([FromQuery] string username, [FromQuery] string password){
            try {
                User usr = UserService.ValidateUser(username,password);
                string jsonUser = JsonSerializer.Serialize(usr);
                return StatusCode(200,jsonUser);
            } catch (Exception e){
                return StatusCode(401,e.Message);
            }
        }
    }
}