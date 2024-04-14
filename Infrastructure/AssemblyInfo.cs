using System.Reflection;

namespace Infrastructure;

public static class InfrastructureAssemblyInfo
{
    public static Assembly Assembly { get; } = typeof(ApplicationDbContext).Assembly;
}