namespace EnterpriseDirectory.Models;

public class ChartStatisticsDto
{
    public string Position { get; set; }

    public string OldestWorkerPerPosition { get; set; }

    public string YoungestWorkerPerPosition { get; set; }

    public int EmployeePerPositionCount { get; set; }

    public decimal AvgSalary { get; set; }

    public decimal MinSalary { get; set; }

    public decimal MaxSalary { get; set; }

    public int WorkingCount { get; set; }

    public int FiredCount { get; set; }

    public string MostLoyalEmployee { get; set; }

    public string OldestWorkerOverall { get; set; }

    public int OverallEmployeeCount { get; set; }

    public int LessTwentyYearsCount { get; set; }

    public int LessTwentyFiveYearsCount { get; set; }

    public int LessThirtyYearsCount { get; set; }

    public int LessFortyYearsCount { get; set; }

    public int MoreFortyYearsCount { get; set; }

    public int NewEmployeeCount { get; set; }

    public int Year1Unemployment { get; set; }
    
    public int Year2Unemployment { get; set; }

    public int Year3Unemployment { get; set; }
}
