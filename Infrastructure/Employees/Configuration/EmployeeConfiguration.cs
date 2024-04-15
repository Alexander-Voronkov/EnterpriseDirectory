using Bogus;
using Domain;
using Humanizer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Employees.Configuration;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.ToTable("Employees");

        builder.HasKey(e => e.Id);

        builder.Property(e => e.FirstName)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(e => e.LastName)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(e => e.Patronymic)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(e => e.Position)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(e => e.Address)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(e => e.Email)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(e => e.CreatedOn)
            .IsRequired()
            .HasDefaultValueSql("Date('now')");

        builder.Property(e => e.PhoneNumber)
            .IsRequired()
            .HasMaxLength(20);

        builder.Property(e => e.Salary)
            .IsRequired();

        builder.Property(e => e.BirthDate)
            .IsRequired();

        builder.Property(e => e.FiredOn)
            .IsRequired(false);

        builder.HasIndex(e => new
        {
            e.CreatedOn,
            e.FirstName,
            e.LastName,
            e.Patronymic
        });

        var index = 1;

        var faker = new Faker<Employee>("uk")
            .RuleFor(x => x.Id, x => index++)
            .RuleFor(x => x.Address, x => x.Address.FullAddress())
            .RuleFor(x => x.BirthDate, x => x.Date.Past(80))
            .RuleFor(x => x.AcceptedOn, x => x.Date.Past(5))
            .RuleFor(x => x.Email, x => x.Internet.Email())
            .RuleFor(x => x.FiredOn, x => x.Date.Past(5).OrNull(x))
            .RuleFor(x=>x.FirstName, x => x.Name.FirstName())
            .RuleFor(x=>x.LastName, x => x.Name.LastName())
            .RuleFor(x=>x.Patronymic, x => x.Name.Suffix())
            .RuleFor(x=>x.PhoneNumber, x => x.Phone.PhoneNumber())
            .RuleFor(x=>x.Position, x => x.PickRandom(new string[] {"Директор", "Секретар", "Програміст", "Прибиральник", "Бухгалтер"}))
            .RuleFor(x=>x.Salary, x => x.Finance.Amount(1000, 20000))
            .RuleFor(x=>x.Currency, x => x.Finance.Currency().Code)
            .RuleFor(x=>x.Status, x => x.Random.Word());

        var employees = faker.Generate(500);        

        builder.HasData(employees);
    }
}