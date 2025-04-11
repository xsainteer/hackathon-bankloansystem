using BankLoanSystem.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace BankLoanSystem.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class BankLoanSystemController : AbpControllerBase
{
    protected BankLoanSystemController()
    {
        LocalizationResource = typeof(BankLoanSystemResource);
    }
}
