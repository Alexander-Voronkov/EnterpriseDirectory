using FluentValidation;

namespace EnterpriseDirectory.ViewModels.FindEmployees;

public class FindEmployeesViewModelValidator : AbstractValidator<FindEmployeesViewModel>
{
    public FindEmployeesViewModelValidator()
    {
        RuleFor(x => x.MinValue)
            .NotEmpty()
            .WithMessage("Введіть мінімальне значення")
            .When(x => x.IsNumberSelected);

        RuleFor(x => x.MaxValue)
            .GreaterThanOrEqualTo(x => x.MinValue)
            .WithMessage("Максимальне значення має бути більшим або дорівнювати мінімальному")
            .NotEmpty()
            .WithMessage("Введіть максимальне значення")
            .When(x => x.IsNumberSelected);

        RuleFor(x => x.StartDate)
            .NotEmpty()
            .WithMessage("Введіть початкову дату")
            .When(x => x.IsDateSelected);

        RuleFor(x => x.EndDate)
            .NotEmpty()
            .WithMessage("Введіть кінцеву дату")
            .GreaterThanOrEqualTo(x => x.StartDate)
            .WithMessage("Кінцева дата має бути більшою або дорівнювати початковій")
            .When(x => x.IsDateSelected);

        RuleFor(x => x.SearchText)
            .NotEmpty()
            .WithMessage("Введіть значення для пошуку")
            .When(x => x.IsTextSelected);
    }
}