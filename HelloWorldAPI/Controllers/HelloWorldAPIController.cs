using Microsoft.AspNetCore.Mvc;

namespace HelloWorldAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloWorldAPIController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("Hello World from .Net Core API");
        }
    }
}
