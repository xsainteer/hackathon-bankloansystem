using System.Threading.Tasks;
using BankLoanSystem.Entities;
using Volo.Abp;
using Volo.Abp.Application.Services;

namespace BankLoanSystem.Interfaces;

[RemoteService(false)]
public interface ILoanService : IApplicationService
{
   Task<decimal> AddRequestAsync(LoanRequest request); 
}