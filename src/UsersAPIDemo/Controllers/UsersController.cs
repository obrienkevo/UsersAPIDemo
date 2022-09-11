using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace UsersAPIDemo.Controllers
{
    [Route("api/[controller]")] // 'controller' wildcard - takes the name of our Controller
    [ApiController] // Provides: Attribute routing; Automatic HTTP Error responses; Default Binding sources
    public class UsersController : ControllerBase // Our Controller class inherits from ControllerBase, which does NOT provide View support.
    {
        [HttpGet] // Verb with Route should be unique
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] {"test kob"};
        }

        [HttpGet]
        public ActionResult<string> GetSingleUser()
        {
            return "KOB123";
        }
    }
}