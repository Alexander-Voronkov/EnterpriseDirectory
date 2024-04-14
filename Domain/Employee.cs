namespace Domain;

public class Employee
{
    /// <summary>
    /// Унікальний ідентифікатор
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// Ім'я
    /// </summary>
    public string FirstName { get; set; }

    /// <summary>
    /// Прізвище
    /// </summary>
    public string LastName { get; set; }

    /// <summary>
    /// По-батькові
    /// </summary>
    public string Patronymic { get; set; }

    /// <summary>
    /// Адреса
    /// </summary>
    public string Address { get; set; }

    /// <summary>
    /// Номер телефону
    /// </summary>
    public string PhoneNumber { get; set; }

    /// <summary>
    /// Зарплата
    /// </summary>
    public decimal? Salary { get; set; }

    /// <summary>
    /// Валюта
    /// </summary>
    public string Currency { get; set; }

    /// <summary>
    /// Посада
    /// </summary>
    public string Position { get; set; }

    /// <summary>
    /// Статус
    /// </summary>
    public string Status { get; set; }

    /// <summary>
    /// Емейл
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Дата народження
    /// </summary>
    public DateTime? BirthDate { get; set; }

    /// <summary>
    /// Час прийняття
    /// </summary>
    public DateTime? AcceptedOn { get; set; }

    /// <summary>
    /// Час звільнення
    /// </summary>
    public DateTime? FiredOn { get; set; }

    /// <summary>
    /// Час додавання
    /// </summary>
    public DateTime? CreatedOn { get; set; }

    /// <summary>
    /// Останній час зміни
    /// </summary>
    public DateTime? LastUpdatedOn { get; set;}
}