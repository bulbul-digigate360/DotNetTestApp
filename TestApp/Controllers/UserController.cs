using Microsoft.AspNetCore.Mvc;

namespace TestApp.Controllers
{


    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        [HttpGet(Name = "GetUsers")]
        public IActionResult Index()
        {
            return Ok("User works:: ");

        }
    }
}
