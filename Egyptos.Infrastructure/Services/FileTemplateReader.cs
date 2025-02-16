using Egyptos.Domain.Interfaces;

namespace Egyptos.Infrastructure.Services;

public class FileTemplateReader(string templatePath) : ITemplateReader
{
    public string ReadTemplate(string templateName)
    {
        var templateFullPath = Path.Combine(templatePath, templateName);
        using var streamReader = new StreamReader(templateFullPath);
        return streamReader.ReadToEnd();
    }
}
