using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using BankLoanSystem.Entities;
using BankLoanSystem.Interfaces;
using Volo.Abp;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Identity;

namespace BankLoanSystem.Services;

[RemoteService(false)]
public class LoanService : ApplicationService, ILoanService
{
    private readonly IRepository<IdentityUser, Guid> _userRepository;
    
    private readonly IScoringCalculationService _scoringCalculation;

    public LoanService(IRepository<IdentityUser, Guid> userRepository, IScoringCalculationService scoringCalculation)
    {
        _userRepository = userRepository;
        _scoringCalculation = scoringCalculation;
    }

    //returning scoring
    public async Task<decimal> AddRequestAsync(LoanRequest request)
    {
        var user = await _userRepository.GetAsync(request.UserId);

        if (!user.ExtraProperties.TryGetValue("Passport", out var extraProperty))
        {
            return 0;
        }
        
        var passportJson = extraProperty?.ToString();

        var loanRequests = user.ExtraProperties.TryGetValue("LoanRequests", out var property) && property != null
            ? JsonSerializer.Deserialize<List<LoanRequest>>(property.ToString() ?? string.Empty)
            : new List<LoanRequest>();

        
        if (passportJson != null)
        {
            var passport = JsonSerializer.Deserialize<Passport>(passportJson);

            var additionalInfo = passport?.AdditionalInfo;
            if (additionalInfo != null)
            {
                var response = await _scoringCalculation.GetDataReturnData(additionalInfo, request);
                request.Scoring = response;
                
                loanRequests?.Add(request);
                user.ExtraProperties["LoanRequests"] = JsonSerializer.Serialize(loanRequests);
                await _userRepository.UpdateAsync(user);
                
                return response;
            }
            loanRequests?.Add(request);
            user.ExtraProperties["LoanRequests"] = JsonSerializer.Serialize(loanRequests);
            await _userRepository.UpdateAsync(user);
            
            return 0;
        }
        
        loanRequests?.Add(request);
        user.ExtraProperties["LoanRequests"] = JsonSerializer.Serialize(loanRequests);
        await _userRepository.UpdateAsync(user);
        
        return 0;
    }
}