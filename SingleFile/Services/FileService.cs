using Microsoft.AspNetCore.Http;
using SingleFile.Models;
using SingleFile.Services.Interfaces;
using System.Threading.Tasks;

namespace SingleFile.Services
{
    public class FileService : IFileService
    {
        public async Task<File> CreateFile(IFormFile file)
        {
            return await Task.FromResult(new File());
        }
    }
}
