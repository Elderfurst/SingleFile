using Microsoft.AspNetCore.Http;
using SingleFile.Models;
using System.Threading.Tasks;

namespace SingleFile.Services.Interfaces
{
    public interface IFileService
    {
        Task<File> CreateFile(IFormFile file);
    }
}
