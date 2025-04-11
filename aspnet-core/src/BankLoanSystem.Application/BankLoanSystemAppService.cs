using System;
using System.Collections.Generic;
using System.Text;
using BankLoanSystem.Localization;
using Volo.Abp.Application.Services;

namespace BankLoanSystem;

/* Inherit your application services from this class.
 */
public abstract class BankLoanSystemAppService : ApplicationService
{
    protected BankLoanSystemAppService()
    {
        LocalizationResource = typeof(BankLoanSystemResource);
    }
}
