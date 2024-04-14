using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services, 
        string connectionString)
    {
        services.AddDbContextPool<ApplicationDbContext>((sp, options) =>
        {
            options.UseSqlite(connectionString, sqliteOptions =>
            {
                sqliteOptions.MigrationsAssembly(InfrastructureAssemblyInfo.Assembly.FullName);
            });

            options.AddInterceptors(sp.GetServices<ISaveChangesInterceptor>());
        });

        return services;
    }
}