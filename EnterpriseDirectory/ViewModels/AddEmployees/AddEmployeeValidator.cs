using FluentValidation;

namespace EnterpriseDirectory.ViewModels.AddEmployees;

public class AddEmployeeValidator : AbstractValidator<AddEmployeeViewModel>
{
    public AddEmployeeValidator()
    {
        RuleFor(x => x.FirstName)
            .NotEmpty()
            .WithMessage("Введіть своє ім'я")
            .MaximumLength(100)
            .WithMessage("Ім'я не може містити більше 100 символів");

        RuleFor(x => x.LastName)
            .NotEmpty()
            .WithMessage("Введіть своє прізвище")
            .MaximumLength(100)
            .WithMessage("Прізвище не може містити більше 100 символів");

        RuleFor(x => x.Patronymic)
            .NotEmpty()
            .WithMessage("Введіть по-батьковіВведіть по-батькові")
            .MaximumLength(100)
            .WithMessage("По-батькові не може містити більше 100 символів");

        RuleFor(x => x.BirthDate)
            .Must(x => x is not null && (DateTime.UtcNow.Subtract(x.Value).TotalDays/365.25) >= 18)
            .WithMessage("Введіть дату народження");

        RuleFor(x => x.Address)
            .NotEmpty()
            .WithMessage("Введіть адресу")
            .MaximumLength(200)
            .WithMessage("Адреса не може містити більше 200 символів");

        RuleFor(x => x.Email)
            .EmailAddress()
            .WithMessage("Введіть реальну електронну адресу")
            .MaximumLength(200)
            .WithMessage("Електронна адреса не може містити більше 200 символів");

        RuleFor(x => x.PhoneNumber)
            .NotEmpty()
            .WithMessage("Введіть номер телефону")
            .Matches(@"^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$")
            .WithMessage("Введіть дійсний номер телефону")
            .MaximumLength(20)
            .WithMessage("Номер телефону не може містити більше 20 символів");

        RuleFor(x => x.Salary)
            .GreaterThan(0)
            .WithMessage("Введіть зарплату у гривнях, яка більше 0");

        RuleFor(x => x.Status)
           .NotEmpty()
           .WithMessage("Введіть статус");

        RuleFor(x => x.Position)
            .NotEmpty()
            .WithMessage("Введіть посаду")
            .MaximumLength(100)
            .WithMessage("Посада не може містити більше 100 символів");
    }
}