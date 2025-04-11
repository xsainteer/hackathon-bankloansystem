using Volo.Abp.Modularity;

namespace BankLoanSystem;

/* Inherit from this class for your domain layer tests. */
public abstract class BankLoanSystemDomainTestBase<TStartupModule> : BankLoanSystemTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
