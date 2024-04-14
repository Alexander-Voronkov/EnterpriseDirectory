using System.Reflection;

namespace Domain;

public static class DomainAssemblyInfo
{
    public static Assembly Assembly { get; } = typeof(Employee).Assembly;
}