using Xunit;

namespace BankLoanSystem.EntityFrameworkCore;

[CollectionDefinition(BankLoanSystemTestConsts.CollectionDefinitionName)]
public class BankLoanSystemEntityFrameworkCoreCollection : ICollectionFixture<BankLoanSystemEntityFrameworkCoreFixture>
{

}
