using EnterpriseDirectory.Attributes;

namespace EnterpriseDirectory.Models;

public class EmployeeDto
{
    /// <summary>
    /// Унікальний ідентифікатор
    /// </summary>
    [FindCriteriaAttribute("Унікальний ідентифікатор")]
    public int Id { get; set; }

    /// <summary>
    /// Ім'я
    /// </summary>
    [FindCriteriaAttribute("Ім'я")]
    public string FirstName { get; set; }

    /// <summary>
    /// Прізвище
    /// </summary>
    [FindCriteriaAttribute("Прізвище")]
    public string LastName { get; set; }

    /// <summary>
    /// По-батькові
    /// </summary>
    [FindCriteriaAttribute("По-батькові")]
    public string Patronymic { get; set; }

    /// <summary>
    /// Адреса
    /// </summary>
    [FindCriteriaAttribute("Адреса")]
    public string Address { get; set; }

    /// <summary>
    /// Номер телефону
    /// </summary>
    [FindCriteriaAttribute("Номер телефону")]
    public string PhoneNumber { get; set; }

    /// <summary>
    /// Зарплата
    /// </summary>
    [FindCriteriaAttribute("Зарплата")]
    public decimal? Salary { get; set; }

    /// <summary>
    /// Посада
    /// </summary>
    [FindCriteriaAttribute("Посада")]
    public string Position { get; set; }

    /// <summary>
    /// Чи звільнений
    /// </summary>
    [ExportIgnore]
    public bool IsFired => FiredOn is not null;

    /// <summary>
    /// Статус
    /// </summary>
    [FindCriteriaAttribute("Статус")]
    public string Status { get; set; }

    /// <summary>
    /// Емейл
    /// </summary>
    [FindCriteriaAttribute("Емейл")]
    public string Email { get; set; }

    /// <summary>
    /// Дата народження
    /// </summary>
    [FindCriteriaAttribute("Дата народження")]
    public DateTime? BirthDate { get; set; }

    /// <summary>
    /// Час прийняття
    /// </summary>
    [FindCriteriaAttribute("Час прийняття")]
    public DateTime? AcceptedOn { get; set; }

    /// <summary>
    /// Час звільнення
    /// </summary>
    [FindCriteriaAttribute("Час звільнення")]
    public DateTime? FiredOn { get; set; }

    /// <summary>
    /// Час додавання
    /// </summary>
    [FindCriteriaAttribute("Час додавання")]
    public DateTime? CreatedOn { get; set; }

    /// <summary>
    /// Останній час зміни
    /// </summary>
    [FindCriteriaAttribute("Останній час зміни")]
    public DateTime? LastUpdatedOn { get; set; }
}