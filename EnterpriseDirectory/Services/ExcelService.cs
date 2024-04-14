using EnterpriseDirectory.Attributes;
using Infrastructure;
using Microsoft.Extensions.Logging;
using OfficeOpenXml;
using System.IO;

namespace EnterpriseDirectory.Services;

public class ExcelService : IDataManipulationService
{
    private readonly ILogger _logger;

    public ExcelService(
        ILogger<ExcelService> logger)
    {
        _logger = logger;
    }

    public async Task Export<T>(
        List<T> dataToBeExported,
        string destination,
        CancellationToken token = default)
    {
        _logger.LogInformation($"{nameof(Export)} of {typeof(T).Name} has just been started.");

        using (var package = new ExcelPackage())
        {
            var worksheet = package.Workbook.Worksheets.Add("Employees");

            var propertyCount = 0;
            var properties = typeof(T).GetProperties();

            foreach (var property in properties)
            {
                worksheet.Cells[1, 1 + propertyCount++].Value = property.Name;
            }

            for (var i = 0; i < dataToBeExported.Count(); i++)
            {
                for (var q = 0; q < properties.Length; q++)
                {
                    worksheet.Cells[i + 2, q + 1].Value = properties[q].GetValue(dataToBeExported[i])?.ToString();
                }
            }

            FileInfo excelFile = new FileInfo(destination);
            await package.SaveAsAsync(excelFile, token);
        }
    }

    public Task<List<T>> Import<T>(
        string filePath,
        CancellationToken token = default)
    {
        _logger.LogInformation($"{nameof(Import)} of {typeof(T).Name} has just been started.");

        var importedData = new List<T>();

        using (var package = new ExcelPackage(new FileInfo(filePath)))
        {
            var worksheet = package.Workbook.Worksheets[0];
            var rowCount = worksheet.Dimension.Rows;
            var colCount = worksheet.Dimension.Columns;
            var properties = typeof(T).GetProperties();

            for (var row = 2; row <= rowCount; row++)
            {
                var importedItem = Activator.CreateInstance<T>();

                for (var col = 1; col <= colCount; col++)
                {
                    var propertyName = worksheet.Cells[1, col].Value.ToString();
                    var property = properties.FirstOrDefault(p => p.Name == propertyName);

                    if (property.CustomAttributes.Any(x => x.AttributeType == typeof(ExportIgnoreAttribute)))
                        continue;

                    if (property != null)
                    {
                        var cellValue = worksheet.Cells[row, col].Value;
                        if (cellValue != null)
                        {
                            var convertedValue = Convert.ChangeType(
                                cellValue, 
                                Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType);
                            property.SetValue(importedItem, convertedValue);
                        }
                    }
                }

                importedData.Add(importedItem);
            }
        }

        return Task.FromResult(importedData);
    }
}