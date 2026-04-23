using Soenneker.Tests.HostedUnit;

namespace Soenneker.SendGrid.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class SendGridOpenApiClientRunnerTests : HostedUnitTest
{
    public SendGridOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
