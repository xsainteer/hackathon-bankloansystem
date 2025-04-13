using System.Threading.Tasks;
using BankLoanSystem.Entities;
using Volo.Abp.Application.Services;

namespace BankLoanSystem.Interfaces;

public interface IScoringCalculationService : IApplicationService
{
    Task<decimal> GetDataReturnData(AdditionalInfo ai, LoanRequest request);
}