using AutoMapper;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Domain;
using EnterpriseDirectory.ViewModels.AddEmployees;
using FluentValidation;
using Infrastructure;
using Microsoft.Extensions.Logging;
using System.Collections;
using System.ComponentModel;
using System.Windows;

namespace EnterpriseDirectory.ViewModels.ModifyEmployees;

public partial class ModifyEmployeeViewModel : ObservableObject, INotifyDataErrorInfo
{
    private readonly IValidator _validator;
    private readonly IMapper _mapper;
    private readonly ILogger _logger;
    private readonly ApplicationDbContext _context;
    private readonly Dictionary<string, List<string>> _errors;
    private int totalErrors;

    public bool HasErrors => this.totalErrors > 0;
    public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

    public ModifyEmployeeViewModel(
        IValidator<ModifyEmployeeViewModel> validator,
        IMapper mapper,
        ILogger<ModifyEmployeeViewModel> logger,
        ApplicationDbContext context)
    {
        _validator = validator;
        _context = context;
        _mapper = mapper;
        _logger = logger;
        _errors = new();
        ModifyEmployeeCommand = new AsyncRelayCommand(ModifyEmployee, CanModify);
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

    private DateTime birthDate;
    public DateTime BirthDate
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

    private decimal salary;
    public decimal Salary
    {
        get => salary;
        set
        {
            SetProperty(ref salary, value);
            Validate(nameof(Salary));
        }
    }

    private string currency;
    public string Currency
    {
        get => currency;
        set
        {
            SetProperty(ref currency, value);
            Validate(nameof(Currency));
        }
    }

    private DateTime acceptanceDate;
    public DateTime AcceptanceDate
    {
        get => acceptanceDate;
        set
        {
            SetProperty(ref acceptanceDate, value);
            Validate(nameof(AcceptanceDate));
        }
    }

    private DateTime firedOn;
    public DateTime FiredOn
    {
        get => firedOn;
        set
        {
            SetProperty(ref firedOn, value);
            Validate(nameof(FiredOn));
        }
    }

    #endregion

    #region Commands
    public IAsyncRelayCommand ModifyEmployeeCommand { get; }

    #endregion

    #region Commands` methods
    private async Task ModifyEmployee()
    {
        var res = MessageBox.Show(
            "Ви впевнені, що хочете змінити цього співробітника?",
            "Попередження",
            MessageBoxButton.YesNoCancel,
            MessageBoxImage.Warning);

        if (res != MessageBoxResult.Yes)
        {
            return;
        }

        IsLoading = true;

        var entity = _context.Update(_mapper.Map<Employee>(this));
        await _context.SaveChangesAsync();

        IsLoading = false;

        _logger.LogInformation($"An employee with id: {entity.Entity.Id} has just been successfully updated.");
        MessageBox.Show(
            $"Змінено співробітника: {entity.Entity.FirstName} {entity.Entity.LastName}",
            "Успіх",
            MessageBoxButton.OK,
            MessageBoxImage.Information);
    }

    #endregion

    #region Commands` execution conditions
    private bool CanModify()
    {
        return !HasErrors;
    }
    #endregion

    public void Validate(string propertyName = null)
    {
        var context = new ValidationContext<ModifyEmployeeViewModel>(this);

        var validationResult = _validator.Validate(context);

        _errors.Clear();
        totalErrors = 0;

        if (!validationResult.IsValid)
        {
            foreach (var error in validationResult.Errors)
            {
                totalErrors++;
                if (_errors.ContainsKey(error.PropertyName))
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
    }

    public IEnumerable GetErrors(string propertyName)
    {
        if (_errors.TryGetValue(propertyName, out var errors))
        {
            return errors;
        }
        else
        {
            return Enumerable.Empty<string>();
        }
    }
}
