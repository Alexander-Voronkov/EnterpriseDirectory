using AutoMapper;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Domain;
using FluentValidation;
using FluentValidation.Internal;
using Infrastructure;
using Microsoft.Extensions.Logging;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Windows;

namespace EnterpriseDirectory.ViewModels.AddEmployees;
public partial class AddEmployeeViewModel : ObservableObject, INotifyDataErrorInfo
{
    private readonly IValidator _validator;
    private readonly IMapper _mapper;
    private readonly ILogger _logger;
    private readonly ApplicationDbContext _context;
    private readonly Dictionary<string, List<string>> _errors;
    private int totalErrors = 1;

    public bool HasErrors => this.totalErrors > 0;
    public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

    public AddEmployeeViewModel(
        IValidator<AddEmployeeViewModel> validator,
        IMapper mapper,
        ILogger<AddEmployeeViewModel> logger,
        ApplicationDbContext context)
    {
        _validator = validator;
        _context = context;
        _mapper = mapper;
        _logger = logger;
        _errors = new();
        CreateNewEmployeeCommand = new AsyncRelayCommand(SaveEmployee, CanSave);
    }

    #region Observable properties

    [ObservableProperty]
    public bool isLoading;

    private string firstName;
    public string FirstName
    {
        get => firstName;
        set
        {
            SetProperty(ref firstName, value);
            Validate(nameof(FirstName));
        }
    }

    private DateTime? birthDate;
    public DateTime? BirthDate
    {
        get => birthDate;
        set
        {
            SetProperty(ref birthDate, value);
            Validate(nameof(BirthDate));
        }
    }

    private string lastName;
    public string LastName
    {
        get => lastName;
        set
        {
            SetProperty(ref lastName, value);
            Validate(nameof(LastName));
        }
    }

    private string status;
    public string Status
    {
        get => status;
        set
        {
            SetProperty(ref status, value);
            Validate(nameof(Status));
        }
    }

    private string patronymic;
    public string Patronymic
    {
        get => patronymic;
        set
        {
            SetProperty(ref patronymic, value);
            Validate(nameof(Patronymic));
        }
    }

    private string address;
    public string Address
    {
        get => address;
        set
        {
            SetProperty(ref address, value);
            Validate(nameof(Address));
        }
    }

    private string position;
    public string Position
    {
        get => position;
        set
        {
            SetProperty(ref position, value);
            Validate(nameof(Position));
        }
    }

    private string phoneNumber;
    public string PhoneNumber
    {
        get => phoneNumber;
        set
        {
            SetProperty(ref phoneNumber, value);
            Validate(nameof(PhoneNumber));
        }
    }

    private string email;
    public string Email
    {
        get => email;
        set
        {
            SetProperty(ref email, value);
            Validate(nameof(Email));
        }
    }

    private decimal? salary;
    public decimal? Salary
    {
        get => salary;
        set
        {
            SetProperty(ref salary, value);
            Validate(nameof(Salary));
        }
    }

    #endregion

    #region Commands
    public IAsyncRelayCommand CreateNewEmployeeCommand { get; }

    #endregion

    #region Commands` methods
    private async Task SaveEmployee()
    {
        var res = MessageBox.Show(
            "Ви впевнені, що хочете додати нового співробітника?",
            "Попередження",
            MessageBoxButton.YesNoCancel,
            MessageBoxImage.Warning);

        if(res != MessageBoxResult.Yes)
        {
            return;
        }

        IsLoading = true;

        var entity = await _context.AddAsync(_mapper.Map<Employee>(this));
        await _context.SaveChangesAsync();

        IsLoading = false;

        _logger.LogInformation($"A new employee with id: {entity.Entity.Id} has just been successfully saved.");
        MessageBox.Show(
            $"Додано нового співробітника: {entity.Entity.FirstName} {entity.Entity.LastName}",
            "Успіх",
            MessageBoxButton.OK,
            MessageBoxImage.Information);
    }

    #endregion

    #region Commands` execution conditions
    private bool CanSave()
    {
        return !HasErrors;
    }
    #endregion

    public void Validate(string propertyName = null)
    {
        var context = new ValidationContext<AddEmployeeViewModel>(this);

        var validationResult = _validator.Validate(context);

        _errors.Clear();
        totalErrors = 0;

        if (!validationResult.IsValid)
        {
            foreach (var error in validationResult.Errors)
            {
                totalErrors++;
                if(_errors.ContainsKey(error.PropertyName))
                {
                    _errors[error.PropertyName].Add(error.ErrorMessage);
                }
                else
                {
                    _errors[error.PropertyName] = [error.ErrorMessage];
                }
            }
        }

        if (propertyName != null)
        {
            ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
        }

        CreateNewEmployeeCommand.NotifyCanExecuteChanged();
    }

    public IEnumerable GetErrors(string propertyName)
    {
        if(_errors.TryGetValue(propertyName, out var errors))
        {
            return errors;
        }
        else
        {
            return Enumerable.Empty<string>();
        }
    }
}