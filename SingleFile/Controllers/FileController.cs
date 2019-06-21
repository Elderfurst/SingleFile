using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SingleFile.Services.Interfaces;

namespace SingleFile.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        private readonly IFileService _fileService;

        public FileController(IFileService fileService)
        {
            _fileService = fileService;
        }
        [HttpPost]
        public ActionResult Post(IFormFile file)
        {
            var uploaded = _fileService.CreateFile(file);

            if (uploaded != null)
            {
                return Ok(uploaded);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}