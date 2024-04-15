using AutoMapper;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using Domain;
using EnterpriseDirectory.Messages;
using FluentValidation;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections;
using System.ComponentModel;
using System.Windows;

namespace EnterpriseDirectory.ViewModels.ModifyEmployees;

public partial class ModifyEmployeeViewModel : ObservableObject, INotifyDataErrorInfo, IRecipient<ModifyEmployeeMessage>
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
        WeakReferenceMessenger.Default.Register(this);

        _validator = validator;
        _context = context;
        _mapper = mapper;
        _logger = logger;
        _errors = new();
        ModifyEmployeeCommand = new AsyncRelayCommand(ModifyEmployee, CanModify);
    }

    private int _employeeId;
    public int Id => _employeeId;

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

    private DateTime? acceptanceDate;
    public DateTime? AcceptanceDate
    {
        get => acceptanceDate;
        set
        {
            SetProperty(ref acceptanceDate, value);
            Validate(nameof(AcceptanceDate));
        }
    }

    private DateTime? firedOn;
    public DateTime? FiredOn
    {
        get => firedOn;
        set
        {
            SetProperty(ref firedOn, value);
            Validate(nameof(FiredOn));
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

        var employeeToModify = await _context.Employees.FirstAsync(x => x.Id == Id);

        employeeToModify.Position = Position;
        employeeToModify.Status = Status;
        employeeToModify.Email = Email;
        employeeToModify.BirthDate = BirthDate;
        employeeToModify.FirstName = FirstName;
        employeeToModify.PhoneNumber = PhoneNumber;
        employeeToModify.LastName = LastName;
        employeeToModify.Patronymic = Patronymic;
        employeeToModify.FiredOn = FiredOn;
        employeeToModify.AcceptedOn = AcceptanceDate;
        employeeToModify.Salary = Salary;

        var entity = _context.Employees.Update(employeeToModify);
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

    private void Validate(string propertyName = null)
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

    private Task HandleMessage(ModifyEmployeeMessage message)
    {
        IsLoading = true;

        _employeeId = message.Value.Id;
        BirthDate = message.Value.BirthDate;
        AcceptanceDate = message.Value.AcceptedOn;
        Email = message.Value.Email;
        PhoneNumber = message.Value.PhoneNumber;
        FirstName = message.Value.FirstName;
        LastName = message.Value.LastName;
        Patronymic = message.Value.Patronymic;
        Address = message.Value.Patronymic;
        Position = message.Value.Position;
        Status = message.Value.Status;
        Salary = message.Value.Salary;
        FiredOn = message.Value.FiredOn;

        IsLoading = false;

        return Task.CompletedTask;
    }

    public async void Receive(ModifyEmployeeMessage message)
    {
        await HandleMessage(message);
    }
}
