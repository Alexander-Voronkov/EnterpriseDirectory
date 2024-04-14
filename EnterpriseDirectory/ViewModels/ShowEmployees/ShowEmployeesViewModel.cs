using AutoMapper;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Domain;
using EnterpriseDirectory.Models;
using EnterpriseDirectory.Services;
using EnterpriseDirectory.Views;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Win32;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

namespace EnterpriseDirectory.ViewModels.ShowEmployees;

public partial class ShowEmployeesViewModel : ObservableObject
{
    private readonly ApplicationDbContext _context;
    private readonly AddNewEmployee _addNewEmployeeView;
    private readonly ModifyEmployee _modifyEmployeeView;
    private readonly Statistics _employeeStatisticsView;
    private readonly FindEmployee _findEmployeeView;
    private readonly IMapper _mapper;
    private readonly ILogger _logger;
    private readonly IEnumerable<IDataManipulationService> _dataManipulationServices;

    public ShowEmployeesViewModel(
        ApplicationDbContext context,
        IEnumerable<IDataManipulationService> dataManipulationService,
        IMapper mapper,
        ILogger<ShowEmployeesViewModel> logger,
        AddNewEmployee addNewEmployeeView,
        ModifyEmployee modifyEmployeeView,
        Statistics statisticsView,
        FindEmployee findEmployeeView)
    { 
        _context = context;
        _dataManipulationServices = dataManipulationService;
        _mapper = mapper;   
        _logger = logger;
        _addNewEmployeeView = addNewEmployeeView;
        _modifyEmployeeView = modifyEmployeeView;
        _employeeStatisticsView = statisticsView;
        _findEmployeeView = findEmployeeView;

        _employees = new();

        _employees.CollectionChanged += (sender, ea) =>
        {
            DeleteAllEmployeesCommand.NotifyCanExecuteChanged();
            ShowStatisticsCommand.NotifyCanExecuteChanged();
            ExportEmployeesCommand.NotifyCanExecuteChanged();
            FindEmployeeCommand.NotifyCanExecuteChanged();
        };

        RefreshEmployeesCommand = new AsyncRelayCommand(RefreshEmployees);
        DeleteAllEmployeesCommand = new AsyncRelayCommand(DeleteAllEmployees, CanDeleteAll);
        ShowStatisticsCommand = new AsyncRelayCommand(ShowStatistics, CanShowStatistics);
        ImportEmployeesCommand = new AsyncRelayCommand(Import);
        ExportEmployeesCommand = new AsyncRelayCommand(Export, CanExport);
        FireEmployeeCommand = new AsyncRelayCommand(FireSelected, CanFire);
        FindEmployeeCommand = new AsyncRelayCommand(Find, CanFind);
        AddNewEmployeeCommand = new AsyncRelayCommand(AddNew, CanAdd);
        ModifyEmployeeCommand = new AsyncRelayCommand(Modify, CanModify);
        DeleteSelectedCommand = new AsyncRelayCommand(DeleteSelected, CanDeleteSelected);
        RenewEmployeeCommand = new AsyncRelayCommand(Renew, CanRenew);
    }

    #region Commands

    public IAsyncRelayCommand RefreshEmployeesCommand { get; }

    public IAsyncRelayCommand DeleteSelectedCommand { get; }

    public IAsyncRelayCommand DeleteAllEmployeesCommand { get; }

    public IAsyncRelayCommand AddNewEmployeeCommand { get; }

    public IAsyncRelayCommand ModifyEmployeeCommand { get; }

    public IAsyncRelayCommand FindEmployeeCommand { get; }

    public IAsyncRelayCommand ShowStatisticsCommand { get; }

    public IAsyncRelayCommand FireEmployeeCommand { get; }

    public IAsyncRelayCommand ExportEmployeesCommand { get; }

    public IAsyncRelayCommand ImportEmployeesCommand { get; }

    public IAsyncRelayCommand RenewEmployeeCommand { get; }

    #endregion

    #region Command methods

    private async Task RefreshEmployees()
    {
        IsLoading = true;

        _logger.LogInformation("Getting employees for UI...");

        _employees.Clear();

        var employees = await _context.Employees
            .Select(x => _mapper.Map<EmployeeDto>(x))
            .ToListAsync();

        foreach (var employee in employees)
        {
            _employees.Add(employee);
        }

        IsLoading = false;
    }

    private async Task DeleteAllEmployees()
    {
        _logger.LogInformation("Deleting employees...");

        var res = MessageBox.Show(
            "Ви впевнені що хочете видалити усіх співробітників?", 
            "Попередження", 
            MessageBoxButton.YesNoCancel,
            MessageBoxImage.Warning);
        
        if(res != MessageBoxResult.Yes)
        {
            return;
        }

        IsLoading = true;

        _context.Employees.RemoveRange(_context.Employees);
        await _context.SaveChangesAsync();
        _employees.Clear();

        IsLoading = false;
    }

    private Task ShowStatistics()
    {
        _employeeStatisticsView.ShowDialog();
        return Task.CompletedTask;
    }

    private async Task Import()
    {
        var ofd = new OpenFileDialog();
        ofd.Filter = "Excel file (*.xlsx)|*.xlsx|Json file (*.json)|*.json|XML file (*.xml)|*.xml";
        ofd.CheckPathExists = true;
        ofd.CheckFileExists = true;
        var res = ofd.ShowDialog();

        if (res is false)
        {
            return;
        }


        IsLoading = true;

        IDataManipulationService service;

        service = Path.GetExtension(ofd.FileName) switch
        {
            ".xlsx" => _dataManipulationServices.First(x => x is ExcelService),
            ".xml" => _dataManipulationServices.First(x => x is XmlService),
            ".json" => _dataManipulationServices.First(x => x is JsonService),
            _ => null,
        };

        (await service?.Import<EmployeeDto>(ofd.FileName)).ForEach(x =>
        {
            x.Id = 0;
            var addedEntity = _context.Add(_mapper.Map<Employee>(x));
        });

        await _context.SaveChangesAsync();
        await RefreshEmployees();
    }

    private async Task DeleteSelected()
    {
        var res = MessageBox.Show(
            "Ви впевнені, що хочете видалити цього користувача?", 
            "Попередження",
            MessageBoxButton.YesNoCancel,
            MessageBoxImage.Warning);

        if(res != MessageBoxResult.Yes)
        {
            return;
        }

        IsLoading = true;

        var employees = _context.Employees.Where(x => x.Id == SelectedItem.Id);

        _context.Employees.RemoveRange(employees);
        await _context.SaveChangesAsync();

        _logger.LogInformation("Employee has just been deleted successfully {Id}", SelectedItem.Id);
        _employees.Remove(SelectedItem);

        IsLoading = false;
    }

    private async Task Export()
    {
        IsLoading = true;

        var ofd = new SaveFileDialog();
        ofd.Filter = "Excel file (*.xlsx)|*.xlsx|Json file (*.json)|*.json|XML file (*.xml)|*.xml";
        ofd.CheckPathExists = true;
        var res = ofd.ShowDialog();

        if(res is false)
        {
            IsLoading = false;
            return;
        }

        IDataManipulationService service;

        service = Path.GetExtension(ofd.FileName) switch
        {
            ".xlsx" => _dataManipulationServices.First(x => x is ExcelService),
            ".xml" => _dataManipulationServices.First(x => x is XmlService),
            ".json" => _dataManipulationServices.First(x => x is JsonService),
            _ => null,
        };

        await service?.Export(Employees.ToList(), ofd.FileName);

        IsLoading = false;
    }

    private async Task FireSelected()
    {
        var res = MessageBox.Show(
            $"Ви впевнені, що хочете звільнити співробітника: {SelectedItem.FirstName} {SelectedItem.LastName} ?",
            "Інформація",
            MessageBoxButton.YesNoCancel,
            MessageBoxImage.Warning);

        if (res != MessageBoxResult.Yes)
        {
            return;
        }

        IsLoading = true;

        await _context.Employees
            .Where(x => x.Id == SelectedItem.Id)
            .ExecuteUpdateAsync(s => 
                s.SetProperty(x => x.FiredOn, DateTime.UtcNow));

        MessageBox.Show(
            $"Ви звільнили співробітника: {SelectedItem.FirstName} {SelectedItem.LastName}",
            "Інформація",
            MessageBoxButton.OK,
            MessageBoxImage.Information);

        await RefreshEmployees();
    }

    private async Task Renew()
    {
        var res = MessageBox.Show(
            $"Ви впевнені, що хочете поновити співробітника: {SelectedItem.FirstName} {SelectedItem.LastName} ?",
            "Інформація",
            MessageBoxButton.YesNoCancel,
            MessageBoxImage.Warning);

        if (res != MessageBoxResult.Yes)
        {
            return;
        }

        IsLoading = true;

        await _context.Employees
            .Where(x => x.Id == SelectedItem.Id)
            .ExecuteUpdateAsync(s =>
                s.SetProperty(x => x.FiredOn, (DateTime?)null));

        MessageBox.Show(
            $"Ви поновили співробітника: {SelectedItem.FirstName} {SelectedItem.LastName}",
            "Інформація",
            MessageBoxButton.OK,
            MessageBoxImage.Information);

        await RefreshEmployees();
    }

    private async Task Find()
    {
        IsLoading = true;

        IsLoading = false;
    }

    private async Task Modify()
    {
        _logger.LogInformation("Opening modify employee window...");
        _modifyEmployeeView.ShowDialog();
    }

    private async Task AddNew()
    {
        _logger.LogInformation("Opening add new employee window...");
        _addNewEmployeeView.ShowDialog();
    }
    #endregion

    #region Command execution conditions

    private bool CanRenew()
    {
        return SelectedItem is not null;
    }

    private bool CanModify()
    {
        return SelectedItem is not null;
    }

    private bool CanAdd()
    {
        return true;
    }

    private bool CanFire()
    {
        return SelectedItem is not null;
    }

    private bool CanDeleteAll()
    {
        return _employees?.Count > 0;
    }

    private bool CanDeleteSelected()
    {
        return SelectedItem is not null;
    }

    private bool CanFind()
    {
        return _employees?.Count > 0;
    }

    private bool CanExport()
    {
        return _employees?.Count > 0;
    }

    private bool CanShowStatistics()
    {
        return _employees?.Count > 0;
    }

    #endregion

    #region Observable properties

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(
        nameof(DeleteSelectedCommand), 
        nameof(FireEmployeeCommand),
        nameof(ModifyEmployeeCommand),
        nameof(RenewEmployeeCommand))]
    private EmployeeDto selectedItem;

    [ObservableProperty]
    public bool isLoading;

    private ObservableCollection<EmployeeDto> _employees;

    public ReadOnlyObservableCollection<EmployeeDto> Employees { get; private set; }

    #endregion
}