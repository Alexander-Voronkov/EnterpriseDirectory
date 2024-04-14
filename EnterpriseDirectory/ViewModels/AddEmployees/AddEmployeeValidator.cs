using FluentValidation;

namespace EnterpriseDirectory.ViewModels.AddEmployees;

public class AddEmployeeValidator : AbstractValidator<AddEmployeeViewModel>
{
    public AddEmployeeValidator()
    {
        RuleFor(x => x.FirstName)
            .NotEmpty()
            .MaximumLength(100)
            .WithMessage("Введіть своє ім'я");

        RuleFor(x => x.LastName)
            .NotEmpty()
            .MaximumLength(100)
            .WithMessage("Введіть своє прізвище");

        RuleFor(x => x.Patronymic)
            .NotEmpty()
            .MaximumLength(100)
            .WithMessage("Введіть по-батькові");

        RuleFor(x => x.BirthDate)
            .Must(x => x is not null && (DateTime.UtcNow.Subtract(x.Value).TotalDays/365.25) >= 18)
            .WithMessage("Введіть дату народження");

        RuleFor(x => x.Address)
            .NotEmpty()
            .MaximumLength(200)
            .WithMessage("Введіть адресу");

        RuleFor(x => x.Email)
            .EmailAddress()
            .MaximumLength(200)
            .WithMessage("Введіть електронну адресу");

        RuleFor(x => x.PhoneNumber)
            .NotEmpty()
            .Matches(@"^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$")
            .WithMessage("Введіть номер телефону")
            .MaximumLength(20);

        RuleFor(x => x.Salary)
            .GreaterThan(0)
            .WithMessage("Введіть зарплату");

        RuleFor(x => x.Position)
            .NotEmpty()
            .MaximumLength(100)
            .WithMessage("Введіть посаду");

        RuleFor(x => x.Currency)
            .NotEmpty()
            .MaximumLength(10)
            .WithMessage("Введіть валюту, у якій виплачується зарплата");
    }
}