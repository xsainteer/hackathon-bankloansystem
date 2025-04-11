using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace BankLoanSystem.Data;

/* This is used if database provider does't define
 * IBankLoanSystemDbSchemaMigrator implementation.
 */
public class NullBankLoanSystemDbSchemaMigrator : IBankLoanSystemDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
