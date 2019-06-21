using Microsoft.AspNetCore.Mvc;

namespace SingleFile.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelpController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "help message";
        }
    }
}