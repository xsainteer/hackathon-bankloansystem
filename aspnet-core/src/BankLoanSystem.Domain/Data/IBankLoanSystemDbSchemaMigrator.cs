using System.Threading.Tasks;

namespace BankLoanSystem.Data;

public interface IBankLoanSystemDbSchemaMigrator
{
    Task MigrateAsync();
}
