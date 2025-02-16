using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;

namespace Egyptos.Application.Services.Implementations;

public class FileService(IHostEnvironment hostEnvironment) : IFileService
{

    public async Task<string> UploadAsync(IFormFile file,string folderName)
    {
        var  webRootPath = Path.Combine(hostEnvironment.ContentRootPath, "wwwroot", folderName);
        var extension = Path.GetExtension(file.FileName).ToLower();
        var fileName = $"{Guid.NewGuid()}{extension}";

        if (!Directory.Exists(webRootPath))
            Directory.CreateDirectory(webRootPath);

        var path = Path.Combine(webRootPath, fileName);

        try
        {
            await using var stream = new FileStream(path, FileMode.Create);
            await file.CopyToAsync(stream);
        }
        catch (Exception ex)
        {
            throw new Exception($"File upload failed: {ex.Message}");
        }

        return fileName;
    }
}
