using Microsoft.Extensions.Localization;
using BankLoanSystem.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace BankLoanSystem;

[Dependency(ReplaceServices = true)]
public class BankLoanSystemBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<BankLoanSystemResource> _localizer;

    public BankLoanSystemBrandingProvider(IStringLocalizer<BankLoanSystemResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
