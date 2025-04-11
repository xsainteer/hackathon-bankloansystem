using BankLoanSystem.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace BankLoanSystem.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(BankLoanSystemEntityFrameworkCoreModule),
    typeof(BankLoanSystemApplicationContractsModule)
    )]
public class BankLoanSystemDbMigratorModule : AbpModule
{
}
