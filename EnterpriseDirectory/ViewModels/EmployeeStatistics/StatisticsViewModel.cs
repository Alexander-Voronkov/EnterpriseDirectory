using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EnterpriseDirectory.Models;
using Infrastructure;
using LiveCharts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Dapper;
using Domain;
using System.Collections.ObjectModel;
using LiveCharts.Wpf;
using Bogus;

namespace EnterpriseDirectory.ViewModels.EmployeeStatistics;

public partial class StatisticsViewModel : ObservableObject
{
    private readonly ApplicationDbContext _context;
    private readonly ILogger _logger;
    private const int _dataCountToFetch = 50;
    
    public StatisticsViewModel(
        ApplicationDbContext context,
        ILogger<StatisticsViewModel> logger) 
    {
        _context = context;
        _logger = logger;
        SalaryStatistics = new();
        SalaryStatisticsLabels = new();
        EmploymentStatistics = new();
        FireStatistics = new(); 
        FireStatisticsLabels = new();
        RefreshChartsCommand = new AsyncRelayCommand(RefreshCharts);
    }

    #region Observable properties
    public SeriesCollection SalaryStatistics { get; set; }

    public ObservableCollection<string> SalaryStatisticsLabels { get; set; }

    public SeriesCollection FireStatistics { get; set; }

    public ObservableCollection<string> FireStatisticsLabels { get; set; }

    public SeriesCollection EmploymentStatistics { get; set; }

    [ObservableProperty]
    public int overallEmployeeCount;

    [ObservableProperty]
    public int newEmployeeCount;

    [ObservableProperty]
    public bool isLoading;

    #endregion

    #region Commands
    public IAsyncRelayCommand RefreshChartsCommand { get; }

    #endregion

    private async Task RefreshCharts()
    {
        IsLoading = true;

        await Task.Delay(1000);

        _logger.LogInformation("Refreshing charts...");

        #region Fetch data

        int[] yearsToTakeDataFor = [
            DateTime.UtcNow.Year - 1, 
            DateTime.UtcNow.Year - 2, 
            DateTime.UtcNow.Year - 3];

        var data = await _context.Database
            .GetDbConnection()
            .QueryAsync<ChartStatisticsDto>(
            $"""
                ;WITH CTE AS 
                (SELECT e.{nameof(Employee.Position)} 
                AS {nameof(ChartStatisticsDto.Position)}
                ,
                MIN(CAST(e.{nameof(Employee.Salary)} AS DECIMAL)) 
                AS {nameof(ChartStatisticsDto.MinSalary)}
                ,
                AVG(CAST(e.{nameof(Employee.Salary)} AS DECIMAL)) 
                AS {nameof(ChartStatisticsDto.AvgSalary)}
                ,
                MAX(CAST(e.{nameof(Employee.Salary)} AS DECIMAL)) 
                AS {nameof(ChartStatisticsDto.MaxSalary)}
                ,
                COUNT(*) 
                AS {nameof(ChartStatisticsDto.EmployeePerPositionCount)}
                ,
                (SELECT COUNT(*)
                FROM Employees 
                WHERE {nameof(Employee.FiredOn)} IS NULL)
                AS {nameof(ChartStatisticsDto.WorkingCount)}
                ,
                (SELECT COUNT(*)
                FROM Employees 
                WHERE {nameof(Employee.FiredOn)} IS NOT NULL)
                AS {nameof(ChartStatisticsDto.FiredCount)}
                ,
                (SELECT COUNT(*)
                FROM Employees)
                AS {nameof(ChartStatisticsDto.OverallEmployeeCount)}
                ,
                (SELECT e1.{nameof(Employee.FirstName)} || ' ' || e1.{nameof(Employee.Patronymic)} || ' ' || e1.{nameof(Employee.LastName)} 
                FROM Employees e1 
                WHERE e1.{nameof(Employee.Position)} = e.{nameof(Employee.Position)} 
                ORDER BY e1.{nameof(Employee.BirthDate)} DESC 
                LIMIT 1) 
                AS {nameof(ChartStatisticsDto.YoungestWorkerPerPosition)}
                ,
                (SELECT e1.{nameof(Employee.FirstName)} || ' ' || e1.{nameof(Employee.Patronymic)} || ' ' || e1.{nameof(Employee.LastName)} 
                FROM Employees e1 
                WHERE e1.{nameof(Employee.Position)} = e.{nameof(Employee.Position)} 
                ORDER BY e1.{nameof(Employee.BirthDate)} ASC 
                LIMIT 1) 
                AS {nameof(ChartStatisticsDto.OldestWorkerPerPosition)}
                ,
                (SELECT e1.{nameof(Employee.FirstName)} || ' ' || e1.{nameof(Employee.Patronymic)} || ' ' || e1.{nameof(Employee.LastName)} 
                FROM Employees e1
                ORDER BY e1.{nameof(Employee.BirthDate)} ASC 
                LIMIT 1) 
                AS {nameof(ChartStatisticsDto.OldestWorkerOverall)}
                ,
                (SELECT e1.{nameof(Employee.FirstName)} || ' ' || e1.{nameof(Employee.Patronymic)} || ' ' || e1.{nameof(Employee.LastName)} 
                FROM Employees e1
                WHERE e1.{nameof(Employee.FiredOn)} IS NULL
                ORDER BY ((JULIANDAY(DATE()) - JULIANDAY(e1.{nameof(Employee.AcceptedOn)}))/365.25) DESC
                LIMIT 1) 
                AS {nameof(ChartStatisticsDto.MostLoyalEmployee)}
                ,
                (SELECT COUNT(*) 
                FROM Employees e1
                WHERE e1.{nameof(Employee.FiredOn)} IS NULL
                AND ((JULIANDAY(DATE()) - JULIANDAY(e1.{nameof(Employee.BirthDate)}))/365.25) < 20)
                AS {nameof(ChartStatisticsDto.LessTwentyYearsCount)}
                ,
                (SELECT COUNT(*) 
                FROM Employees e1
                WHERE e1.{nameof(Employee.FiredOn)} IS NULL
                AND ((JULIANDAY(DATE()) - JULIANDAY(e1.{nameof(Employee.BirthDate)}))/365.25) BETWEEN 20 AND 25)
                AS {nameof(ChartStatisticsDto.LessTwentyFiveYearsCount)}
                ,
                (SELECT COUNT(*) 
                FROM Employees e1
                WHERE e1.{nameof(Employee.FiredOn)} IS NULL
                AND ((JULIANDAY(DATE()) - JULIANDAY(e1.{nameof(Employee.BirthDate)}))/365.25) BETWEEN 25 AND 30)
                AS {nameof(ChartStatisticsDto.LessThirtyYearsCount)}
                ,
                (SELECT COUNT(*) 
                FROM Employees e1
                WHERE e1.{nameof(Employee.FiredOn)} IS NULL
                AND ((JULIANDAY(DATE()) - JULIANDAY(e1.{nameof(Employee.BirthDate)}))/365.25) BETWEEN 30 AND 40)
                AS {nameof(ChartStatisticsDto.LessFortyYearsCount)}
                ,
                (SELECT COUNT(*) 
                FROM Employees e1
                WHERE e1.{nameof(Employee.FiredOn)} IS NULL
                AND ((JULIANDAY(DATE()) - JULIANDAY(e1.{nameof(Employee.BirthDate)}))/365.25) > 40)
                AS {nameof(ChartStatisticsDto.MoreFortyYearsCount)}
                ,
                (SELECT COUNT(*) 
                FROM Employees e1
                WHERE e1.{nameof(Employee.FiredOn)} IS NULL
                AND ((JULIANDAY(DATE()) - JULIANDAY(e1.{nameof(Employee.AcceptedOn)}))/365.25) < 1)
                AS {nameof(ChartStatisticsDto.NewEmployeeCount)}
                ,
                (SELECT COUNT(*) 
                FROM Employees e1
                WHERE e1.{nameof(Employee.FiredOn)} IS NOT NULL
                AND strftime('%Y', {nameof(Employee.FiredOn)}) = '{yearsToTakeDataFor[0]}')
                AS {nameof(ChartStatisticsDto.Year1Unemployment)}
                ,
                (SELECT COUNT(*) 
                FROM Employees e1
                WHERE e1.{nameof(Employee.FiredOn)} IS NOT NULL
                AND strftime('%Y', {nameof(Employee.FiredOn)}) = '{yearsToTakeDataFor[1]}')
                AS {nameof(ChartStatisticsDto.Year2Unemployment)}
                ,
                (SELECT COUNT(*) 
                FROM Employees e1
                WHERE e1.{nameof(Employee.FiredOn)} IS NOT NULL
                AND strftime('%Y', {nameof(Employee.FiredOn)}) = '{yearsToTakeDataFor[2]}')
                AS {nameof(ChartStatisticsDto.Year3Unemployment)}

                FROM Employees e
                GROUP BY {nameof(Employee.Position)})

                SELECT * FROM CTE
                LIMIT {_dataCountToFetch}
            """);

        var listData = data.AsList();

        #endregion

        #region Populate Salary Statistics chart

        if (SalaryStatistics.Count > 0)
            SalaryStatistics.Clear();

        if (SalaryStatisticsLabels.Count > 0)
            SalaryStatisticsLabels.Clear();

        var salaryData = listData
            .Take(5)
            .OrderByDescending(x => x.MaxSalary)
            .ToArray();

        SalaryStatistics.AddRange([
            new StackedColumnSeries
            {
                Values = new ChartValues<decimal>(salaryData.Select(x => x.MinSalary)),
                StackMode = StackMode.Values,
                Title = "Мінімальна",
            },
            new StackedColumnSeries
            {
                Values = new ChartValues<decimal>(salaryData.Select(x => x.AvgSalary)),
                StackMode = StackMode.Values,
                Title = "Середня",
            },
            new StackedColumnSeries
            {
                Values = new ChartValues<decimal>(salaryData.Select(x => x.MaxSalary)),
                StackMode = StackMode.Values,
                Title = "Максимальна",
            },
        ]);

        foreach (var item in salaryData)
        {
            SalaryStatisticsLabels.Add(item.Position);
        }

        #endregion

        #region Populate age statistics chart

        if (EmploymentStatistics.Count > 0)
            EmploymentStatistics.Clear();

        var employmentData = listData.First();

        EmploymentStatistics.AddRange([
            new PieSeries
            {
                Values = new ChartValues<int> { employmentData.LessTwentyYearsCount },
                Title = "Менше 20 років",
            },
            new PieSeries
            {
                Values = new ChartValues<int> { employmentData.LessTwentyFiveYearsCount },
                Title = "Між 20 та 25 роками",
            },
            new PieSeries
            {
                Values = new ChartValues<int> { employmentData.LessThirtyYearsCount },
                Title = "Між 25 та 30 роками",
            },
            new PieSeries
            {
                Values = new ChartValues<int> { employmentData.LessFortyYearsCount },
                Title = "Між 30 та 40 роками",
            },
            new PieSeries
            {
                Values = new ChartValues<int> { employmentData.MoreFortyYearsCount },
                Title = "Більше 40 років",
            },
        ]);

        #endregion

        #region Populate new employee statistics chart

        var newEmployeeStatistics = listData.First();

        OverallEmployeeCount = newEmployeeStatistics.OverallEmployeeCount;
        NewEmployeeCount = newEmployeeStatistics.NewEmployeeCount;

        #endregion

        #region Populare employee fire rate by years

        var fireRateData = listData.First();

        if (FireStatistics.Count > 0)
            FireStatistics.Clear();

        if (FireStatisticsLabels.Count > 0)
            FireStatisticsLabels.Clear();

        FireStatistics.AddRange([
            new LineSeries
            {
                Values = new ChartValues<int>([
                    fireRateData.Year1Unemployment, 
                    fireRateData.Year2Unemployment, 
                    fireRateData.Year3Unemployment]),
                Title = "Кількість звільнень",
            }
        ]);

        FireStatisticsLabels.Add(yearsToTakeDataFor[0].ToString());
        FireStatisticsLabels.Add(yearsToTakeDataFor[1].ToString());
        FireStatisticsLabels.Add(yearsToTakeDataFor[2].ToString());

        #endregion

        IsLoading = false;
    }
}