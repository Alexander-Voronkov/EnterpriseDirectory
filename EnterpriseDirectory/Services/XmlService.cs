using Microsoft.Extensions.Logging;
using System.IO;
using System.Xml.Serialization;

namespace EnterpriseDirectory.Services;

public class XmlService : IDataManipulationService
{
    private readonly ILogger _logger;

    public XmlService(ILogger<XmlService> logger)
    {
        _logger = logger;
    }

    public async Task Export<T>(List<T> dataToBeExported, string destination, CancellationToken token = default)
    {
        _logger.LogInformation($"{nameof(Export)} of {typeof(T).Name} has just been started.");

        using (var fileStream = new FileStream(destination, FileMode.Create))
        {
            var serializer = new XmlSerializer(typeof(List<T>));
            serializer.Serialize(fileStream, dataToBeExported);
            await fileStream.FlushAsync(token);
        }
    }

    public Task<List<T>> Import<T>(string filePath, CancellationToken token = default)
    {
        _logger.LogInformation($"{nameof(Import)} of {typeof(T).Name} has just been started.");

        using (var fileStream = new FileStream(filePath, FileMode.Open))
        {
            var serializer = new XmlSerializer(typeof(List<T>));
            var result = serializer.Deserialize(fileStream) as List<T>;

            return Task.FromResult(result);
        }
    }
}