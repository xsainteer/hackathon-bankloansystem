using BankLoanSystem.Interfaces;
using BankLoanSystem.Services;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace BankLoanSystem;

[DependsOn(
    typeof(BankLoanSystemApplicationModule),
    typeof(BankLoanSystemDomainTestModule)
)]
public class BankLoanSystemApplicationTestModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddScoped<IScoringCalculationService, ScoringCalculationService>();
        base.ConfigureServices(context);
    }
}
