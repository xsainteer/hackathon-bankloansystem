using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities;

namespace BankLoanSystem.Entities;

public class AdditionalInfo : Entity<Guid>
{
    public string TypeOfEmployment { get; set; }
    public decimal Wage { get; set; }
    public int ExperienceInMonths { get; set; }
    public List<string> Properties  { get; set; }
    //could have been credit history, but that's too difficult
    public List<string> SocialPrograms { get; set; }
}