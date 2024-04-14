using EnterpriseDirectory.Services;
using EnterpriseDirectory.ViewModels.AddEmployees;
using EnterpriseDirectory.ViewModels.EmployeeStatistics;
using EnterpriseDirectory.ViewModels.FindEmployees;
using EnterpriseDirectory.ViewModels.ModifyEmployees;
using EnterpriseDirectory.ViewModels.ShowEmployees;
using EnterpriseDirectory.Views;
using FluentValidation;
using Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OfficeOpenXml;
using Serilog;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;

namespace EnterpriseDirectory;
public partial class App : Application
{
    public static IHost AppHost { get; private set; }
    private readonly Mutex _mutex;

    public App()
    {
        if(Mutex.TryOpenExisting(Assembly.GetExecutingAssembly().FullName, out _mutex) == true)
        {
            this.Shutdown();
            return;
        }

        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

        AppHost = Host.CreateDefaultBuilder()
            .ConfigureAppConfiguration(configBuilder =>
            {
                configBuilder.AddJsonFile("appsettings.json");
                configBuilder.AddJsonFile("logging.json");
            })
            .ConfigureServices((hostContext, services) =>
            {
                services.AddInfrastructure(hostContext.Configuration.GetConnectionString("Default"));

                // logging
                services.AddSerilog(logger =>
                {
                    logger.ReadFrom.Configuration(hostContext.Configuration);
                });

                // views
                services.AddSingleton<MainWindow>();
                services.AddTransient<AddNewEmployee>();
                services.AddTransient<Statistics>();
                services.AddTransient<ModifyEmployee>();
                services.AddTransient<FindEmployee>();

                // view models
                services.AddTransient<ShowEmployeesViewModel>();
                services.AddTransient<AddEmployeeViewModel>();
                services.AddTransient<FindEmployeesViewModel>();
                services.AddTransient<ModifyEmployeeViewModel>();
                services.AddTransient<StatisticsViewModel>();

                // services
                services.AddAutoMapper(Assembly.GetExecutingAssembly());
                services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
                services.AddTransient<IDataManipulationService, ExcelService>();
                services.AddTransient<IDataManipulationService, JsonService>();
                services.AddTransient<IDataManipulationService, XmlService>();
            })
            .Build();
    }

    protected override async void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);
        await AppHost.StartAsync();

        var logger = AppHost.Services.GetService<ILogger>();

        Application.Current.DispatcherUnhandledException += (sender, args) => 
        {
            logger.Error(args.Exception.Message);
            MessageBox.Show(
                args.Exception.Message, 
                "Помилка",
                MessageBoxButton.OK,
                MessageBoxImage.Error);
        }; 

        var entry = AppHost.Services.GetRequiredService<MainWindow>();
        entry.Show();
    }

    protected override async void OnExit(ExitEventArgs e)
    {
        await AppHost.StopAsync();
        base.OnExit(e);
        this.Shutdown();
    }
}