using Volo.Abp.Settings;

namespace BankLoanSystem.Settings;

public class BankLoanSystemSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(BankLoanSystemSettings.MySetting1));
    }
}
