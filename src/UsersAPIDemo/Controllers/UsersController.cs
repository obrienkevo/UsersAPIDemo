using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using UsersAPIDemo.Models;
using UsersAPIDemo.Repository;

namespace UsersAPIDemo.Controllers
{
    [Route("api/[controller]")] // 'controller' wildcard - takes the name of our Controller
    [ApiController] // Provides: Attribute routing; Automatic HTTP Error responses; Default Binding sources
    public class UsersController : ControllerBase // Our Controller class inherits from ControllerBase, which does NOT provide View support.
    {
        private readonly IUserAPIRepo _userRepository;
        public UsersController(IUserAPIRepo userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet] // Verb with Route should be unique.
        public ActionResult<IEnumerable<User>> GetAllUsers()
        {
            //return new string[] {"test kob"};
            var users = _userRepository.GetAllUsers();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public ActionResult<User> GetSingleUser(int id)
        {
            //return "KOB123";
            var user = _userRepository.GetUserById(id);
            return user;
        }
    }
}