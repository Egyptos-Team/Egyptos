using Microsoft.AspNetCore.Http;

namespace Egyptos.Application.Services.Interfaces;

public interface IFileService
{
    public Task<string> UploadAsync(IFormFile file,string folderName);
    public Task<bool> DeleteAsync(string filePath);
}
