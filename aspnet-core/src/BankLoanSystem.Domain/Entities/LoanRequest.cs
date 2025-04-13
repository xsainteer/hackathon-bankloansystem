using System;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Identity;

namespace BankLoanSystem.Entities;

public class LoanRequest : Entity<Guid>
{
    public Guid UserId { get; set; }
    public decimal Amount { get; set; }
    public int TermInMonths { get; set; }
    public decimal InterestRate { get; set; }
    public string Type { get; set; }
    public decimal Scoring { get; set; }
    public bool IsApproved { get; set; } = false;
}