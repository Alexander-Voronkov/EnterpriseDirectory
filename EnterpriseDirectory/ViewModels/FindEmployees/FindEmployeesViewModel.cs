using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EnterpriseDirectory.Attributes;
using EnterpriseDirectory.Models;
using FluentValidation;
using Infrastructure;
using Microsoft.Extensions.Logging;
using System.Collections.ObjectModel;
using System.Reflection;

namespace EnterpriseDirectory.ViewModels.FindEmployees;

public partial class FindEmployeesViewModel : ObservableObject
{
    private readonly ILogger _logger;
    private readonly IValidator _validator;
    private readonly ApplicationDbContext _context;
    private readonly Dictionary<string, List<string>> _errors;
    private int totalErrors = 1;

    public bool HasErrors => this.totalErrors > 0;

    public FindEmployeesViewModel(
        ILogger<FindEmployeesViewModel> logger,
        IValidator validator,
        ApplicationDbContext context)
    {
        _logger = logger;
        _validator = validator;
        _context = context;
        FindEmployeeCommand = new AsyncRelayCommand(FindEmployee, CanFind);
        InitCommand = new AsyncRelayCommand(Initialize);
    }

    #region Commands

    public IAsyncRelayCommand FindEmployeeCommand { get; }

    public IAsyncRelayCommand InitCommand { get; }

    #endregion

    #region Command methods

    private async Task FindEmployee()
    {

    }

    private Task Initialize()
    {
        var items = typeof(EmployeeDto)
            .GetProperties()
            .Select(x => 
                (
                    x.GetCustomAttributes(typeof(FindCriteriaAttribute)).First() as FindCriteriaAttribute,
                    x
                )
            );

        foreach (var item in items)
        {
            PropertiesCriterias.Add(item.Item1?.CriteriaName);
        }

        return Task.CompletedTask;
    }

    #endregion

    #region Command execution conditions

    private bool CanFind()
    {
        return !HasErrors;
    }

    #endregion

    #region Observable properties

    [ObservableProperty]
    public string selectedProperty;
    public ObservableCollection<string> PropertiesCriterias { get; set; }

    [ObservableProperty]
    public bool isLoading;

    #endregion
}