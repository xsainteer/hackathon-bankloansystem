using BankLoanSystem.Samples;
using Xunit;

namespace BankLoanSystem.EntityFrameworkCore.Applications;

[Collection(BankLoanSystemTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<BankLoanSystemEntityFrameworkCoreTestModule>
{

}
