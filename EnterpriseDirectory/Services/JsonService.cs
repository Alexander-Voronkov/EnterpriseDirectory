using Microsoft.Extensions.Logging;
using System.IO;
using System.Text.Json;

namespace EnterpriseDirectory.Services;

public class JsonService : IDataManipulationService
{
    private readonly ILogger _logger;

    public JsonService(ILogger<JsonService> logger)
    {
        _logger = logger;
    }

    public async Task Export<T>(List<T> dataToBeExported, string destination, CancellationToken token = default)
    {
        _logger.LogInformation($"{nameof(Export)} of {typeof(T).Name} has just been started.");

        using (var fileStream = new FileStream(destination, FileMode.Create))
        {
            await JsonSerializer.SerializeAsync(
                fileStream, 
                dataToBeExported, 
                options: new JsonSerializerOptions { WriteIndented = true }, 
                cancellationToken: token);
        }
    }

    public async Task<List<T>> Import<T>(string filePath, CancellationToken token = default)
    {
        _logger.LogInformation($"{nameof(Import)} of {typeof(T).Name} has just been started.");

        using (var fileStream = new FileStream(filePath, FileMode.Open))
        {
            return await JsonSerializer.DeserializeAsync<List<T>>(
                fileStream, 
                cancellationToken: token);
        }
    }
}