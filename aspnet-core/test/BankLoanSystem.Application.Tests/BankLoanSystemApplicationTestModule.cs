using Volo.Abp.Modularity;

namespace BankLoanSystem;

[DependsOn(
    typeof(BankLoanSystemApplicationModule),
    typeof(BankLoanSystemDomainTestModule)
)]
public class BankLoanSystemApplicationTestModule : AbpModule
{

}
