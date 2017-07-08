using Microsoft.AspNetCore.Mvc;

namespace Fibon.Api.Controllers
{
    [Route("[controller]")]
    public class FibonacciController : Controller
    {
        [HttpGet("{number}")]
        public IActionResult Get(int number)
        {
            return Content(0.ToString());
        }

        [HttpPost("{number}")]
        public IActionResult Post(int number)
        {
            return Accepted($"fibonacci/{number}", null);
        }
    }
}
