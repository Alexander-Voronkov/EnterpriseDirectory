namespace EnterpriseDirectory.Services;

public interface IDataManipulationService
{
    Task Export<T>(
        List<T> dataToBeExported,
        string destination,
        CancellationToken token = default);

    Task<List<T>> Import<T>(
        string source,
        CancellationToken token = default);
}