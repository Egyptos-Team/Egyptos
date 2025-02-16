using Microsoft.AspNetCore.Http;

namespace Egyptos.Application.Services.Interfaces;

public interface IFileService
{
    public Task<string> UploadAsync(IFormFile file,string folderName);
}
