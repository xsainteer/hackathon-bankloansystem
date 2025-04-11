using Volo.Abp.Modularity;

namespace BankLoanSystem;

public abstract class BankLoanSystemApplicationTestBase<TStartupModule> : BankLoanSystemTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
