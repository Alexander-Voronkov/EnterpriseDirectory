using AutoMapper;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Domain;
using EnterpriseDirectory.Attributes;
using EnterpriseDirectory.Models;
using FluentValidation;
using Infrastructure;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection;
using System.Windows.Media.Animation;
using System.Xml;
using static Dapper.SqlMapper;
using static MaterialDesignThemes.Wpf.Theme.ToolBar;

namespace EnterpriseDirectory.ViewModels.FindEmployees;

public partial class FindEmployeesViewModel : ObservableObject
{
    private readonly ILogger _logger;
    private readonly IMapper _mapper;
    private readonly ApplicationDbContext _context;

    public FindEmployeesViewModel(
        ILogger<FindEmployeesViewModel> logger,
        IMapper mapper,
        ApplicationDbContext context)
    {
        _logger = logger;
        _mapper = mapper;
        _context = context;
        PropertiesCriterias = new();
        FoundValues = new();
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
        IsLoading = true;
        FoundValues.Clear();

        try
        {
            if (_selectedProperty.PropertyInfo.PropertyType == typeof(string)
                || Nullable.GetUnderlyingType(_selectedProperty.PropertyInfo.PropertyType) == typeof(string))
            {
                var parameter = Expression.Parameter(typeof(Employee), "x");

                var property = typeof(Employee).GetProperty(SelectedProperty.PropertyInfo.Name);

                var propertyAccess = Expression.Property(parameter, property);

                var value = Expression.Constant(Convert.ChangeType(SearchText, _selectedProperty.PropertyInfo.PropertyType));
                var containsMethod = typeof(string).GetMethod("Contains", new[] { typeof(string) });
                var containsExpression = Expression.Call(propertyAccess, containsMethod, value);

                var lambda = Expression.Lambda<Func<Employee, bool>>(containsExpression, parameter);

                var filteredEntities = await _context.Employees
                    .Where(lambda)
                    .ToListAsync();

                foreach (var entity in filteredEntities)
                {
                    FoundValues.Add(_mapper.Map<EmployeeDto>(entity));
                }
            }
            else if (_selectedProperty.PropertyInfo.PropertyType == typeof(DateTime)
                || Nullable.GetUnderlyingType(_selectedProperty.PropertyInfo.PropertyType) == typeof(DateTime))
            {
                var parameter = Expression.Parameter(typeof(Employee), "x");

                var property = typeof(Employee).GetProperty(SelectedProperty.PropertyInfo.Name);

                var startValue = Expression.Constant(Convert.ChangeType(StartDate, Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType));
                var endValue = Expression.Constant(Convert.ChangeType(EndDate, Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType));

                var greaterThanOrEqual = Expression.GreaterThanOrEqual(Expression.Convert(Expression.Property(parameter, property), Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType), startValue);
                var lessThanOrEqual = Expression.LessThanOrEqual(Expression.Convert(Expression.Property(parameter, property), Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType), endValue);

                var betweenExpression = Expression.AndAlso(greaterThanOrEqual, lessThanOrEqual);

                var lambda = Expression.Lambda<Func<Employee, bool>>(betweenExpression, parameter);

                var filteredEntities = await _context.Employees
                    .Where(lambda)
                    .ToListAsync();

                foreach (var entity in filteredEntities)
                {
                    FoundValues.Add(_mapper.Map<EmployeeDto>(entity));
                }
            }
            else if (_selectedProperty.PropertyInfo.PropertyType == typeof(decimal)
                || _selectedProperty.PropertyInfo.PropertyType == typeof(int)
                || _selectedProperty.PropertyInfo.PropertyType == typeof(double)
                || _selectedProperty.PropertyInfo.PropertyType == typeof(float)
                || Nullable.GetUnderlyingType(_selectedProperty.PropertyInfo.PropertyType) == typeof(decimal)
                || Nullable.GetUnderlyingType(_selectedProperty.PropertyInfo.PropertyType) == typeof(int)
                || Nullable.GetUnderlyingType(_selectedProperty.PropertyInfo.PropertyType) == typeof(double)
                || Nullable.GetUnderlyingType(_selectedProperty.PropertyInfo.PropertyType) == typeof(float))
            {
                var parameter = Expression.Parameter(typeof(Employee), "x");

                var property = typeof(Employee).GetProperty(SelectedProperty.PropertyInfo.Name);

                var startValue = Expression.Constant(Convert.ChangeType(MinValue, property.PropertyType));
                var endValue = Expression.Constant(Convert.ChangeType(MaxValue, property.PropertyType));

                var greaterThanOrEqual = Expression.GreaterThanOrEqual(Expression.Property(parameter, property), startValue);
                var lessThanOrEqual = Expression.LessThanOrEqual(Expression.Property(parameter, property), endValue);

                var betweenExpression = Expression.AndAlso(greaterThanOrEqual, lessThanOrEqual);

                var lambda = Expression.Lambda<Func<Employee, bool>>(betweenExpression, parameter);

                var filteredEntities = await _context.Employees
                    .Where(lambda)
                    .ToListAsync();

                foreach (var entity in filteredEntities)
                {
                    FoundValues.Add(_mapper.Map<EmployeeDto>(entity));
                }
            }
        }
        catch (Exception ex)
        {
            _logger.LogCritical(ex.Message);
        }

        IsLoading = false;
    }

    private Task Initialize()
    {
        IsLoading = true;

        var items = typeof(EmployeeDto)
            .GetProperties();

        foreach (var item in items)
        {
            var attributes = item.GetCustomAttributes(typeof(FindCriteriaAttribute));

            if (!attributes.Any())
            { 
                continue; 
            }

            var criteria = new FindCriteria
            {
                DisplayName = (attributes.FirstOrDefault() as FindCriteriaAttribute)?.CriteriaName,
                PropertyInfo = item,
            };

            if(criteria is not null)
                PropertiesCriterias.Add(criteria);
        }

        IsLoading = false;

        return Task.CompletedTask;
    }

    #endregion

    #region Command execution conditions

    private bool CanFind()
    {
        return SelectedProperty != null;
    }

    #endregion

    #region Observable properties

    private FindCriteria _selectedProperty;
    public FindCriteria SelectedProperty
    {
        get => _selectedProperty;
        set
        {
            SetProperty(ref _selectedProperty, value);

            if (_selectedProperty.PropertyInfo.PropertyType == typeof(string)
                || Nullable.GetUnderlyingType(_selectedProperty.PropertyInfo.PropertyType) == typeof(string))
            {
                IsTextSelected = true;
                IsNumberSelected = false;
                IsDateSelected = false;
                IsBoolSelected = false;
            }
            else if (_selectedProperty.PropertyInfo.PropertyType == typeof(DateTime) 
                || Nullable.GetUnderlyingType(_selectedProperty.PropertyInfo.PropertyType) == typeof(DateTime))
            {
                IsDateSelected = true;
                IsTextSelected = false;
                IsNumberSelected = false;
                IsBoolSelected = false;
            }
            else if (_selectedProperty.PropertyInfo.PropertyType == typeof(decimal)
                || _selectedProperty.PropertyInfo.PropertyType == typeof(int)
                || _selectedProperty.PropertyInfo.PropertyType == typeof(double)
                || _selectedProperty.PropertyInfo.PropertyType == typeof(float)
                || Nullable.GetUnderlyingType(_selectedProperty.PropertyInfo.PropertyType) == typeof(decimal)
                || Nullable.GetUnderlyingType(_selectedProperty.PropertyInfo.PropertyType) == typeof(int)
                || Nullable.GetUnderlyingType(_selectedProperty.PropertyInfo.PropertyType) == typeof(double)
                || Nullable.GetUnderlyingType(_selectedProperty.PropertyInfo.PropertyType) == typeof(float))
            {
                IsNumberSelected = true;
                IsDateSelected = false;
                IsTextSelected = false;
                IsBoolSelected = false;
            }
            else if(_selectedProperty.PropertyInfo.PropertyType == typeof(bool)
                || Nullable.GetUnderlyingType(_selectedProperty.PropertyInfo.PropertyType) == typeof(bool))
            {
                IsBoolSelected = true;
                IsDateSelected = false;
                IsNumberSelected = false;
                IsTextSelected = false;
            }

            FindEmployeeCommand.NotifyCanExecuteChanged();
        }
    }

    [ObservableProperty]
    public bool isDateSelected;

    [ObservableProperty]
    public bool isTextSelected;

    [ObservableProperty]
    public bool isNumberSelected;

    [ObservableProperty]
    public bool isBoolSelected;

    [ObservableProperty]
    public decimal maxValue;

    [ObservableProperty]
    public decimal minValue;

    [ObservableProperty]
    public string searchText; 
    
    [ObservableProperty]
    public bool boolValue;

    [ObservableProperty]
    public DateTime startDate;

    [ObservableProperty]
    public DateTime endDate;

    public ObservableCollection<FindCriteria> PropertiesCriterias { get; set; }

    public ObservableCollection<EmployeeDto> FoundValues { get; set; }

    [ObservableProperty]
    public bool isLoading;

    #endregion
}