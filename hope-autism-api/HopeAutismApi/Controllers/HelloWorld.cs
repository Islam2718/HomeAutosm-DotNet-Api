using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HopeAutismApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloWorld : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello World");
        }
    }
}
