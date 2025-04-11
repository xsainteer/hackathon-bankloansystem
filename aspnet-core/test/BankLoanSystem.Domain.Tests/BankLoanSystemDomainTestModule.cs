using Volo.Abp.Modularity;

namespace BankLoanSystem;

[DependsOn(
    typeof(BankLoanSystemDomainModule),
    typeof(BankLoanSystemTestBaseModule)
)]
public class BankLoanSystemDomainTestModule : AbpModule
{

}
