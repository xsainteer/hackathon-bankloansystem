using BankLoanSystem.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace BankLoanSystem.Permissions;

public class BankLoanSystemPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(BankLoanSystemPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(BankLoanSystemPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<BankLoanSystemResource>(name);
    }
}
