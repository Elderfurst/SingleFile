using Microsoft.AspNetCore.Mvc;

namespace SingleFile.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthCheckController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "All good";
        }
    }
}