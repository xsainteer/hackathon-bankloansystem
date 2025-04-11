using BankLoanSystem.Samples;
using Xunit;

namespace BankLoanSystem.EntityFrameworkCore.Domains;

[Collection(BankLoanSystemTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<BankLoanSystemEntityFrameworkCoreTestModule>
{

}
