using System.Collections.Generic;
using BankLoanSystem.Entities;
using Volo.Abp.ObjectExtending;

namespace BankLoanSystem.Extensions;

public static class IdentityUserExtensions
{
    public static void ConfigureCustomUserProperties()
    {
        ObjectExtensionManager.Instance
            .Modules()
            .ConfigureIdentity(identity =>
            {
                identity.ConfigureUser(user =>
                {
                    user.AddOrUpdateProperty<bool>("IsApproved");
                    user.AddOrUpdateProperty<Passport>("Passport");
                    user.AddOrUpdateProperty<List<LoanRequest>>("LoanRequests");
                });
            });
    }
}