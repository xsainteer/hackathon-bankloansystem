using System;
using Volo.Abp.Domain.Entities;

namespace BankLoanSystem.Entities;

public class Passport : Entity<Guid>
{
    public string Surname { get; init; }
    public string Name { get; init; }
    public string Patronymic { get; init; }
    public string Sex { get; init; }
    public DateTime DateOfBirth { get; init; }
    public int PersonalNumber { get; init; }
    public string ID {get; init;}
    public string IssuingAuthority { get; init; }
    public DateTime IssueDate { get; init; }
    public DateTime ExpirationDate { get; init; }
    public string PlaceOfBirth { get; init; }
    public AdditionalInfo AdditionalInfo { get; init; }
}