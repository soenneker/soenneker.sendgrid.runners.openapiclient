using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.SendGrid.Runners.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class SendGridOpenApiClientRunnerTests : FixturedUnitTest
{
    public SendGridOpenApiClientRunnerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
