using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BankLoanSystem.Data;
using Volo.Abp.DependencyInjection;

namespace BankLoanSystem.EntityFrameworkCore;

public class EntityFrameworkCoreBankLoanSystemDbSchemaMigrator
    : IBankLoanSystemDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreBankLoanSystemDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the BankLoanSystemDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<BankLoanSystemDbContext>()
            .Database
            .MigrateAsync();
    }
}
