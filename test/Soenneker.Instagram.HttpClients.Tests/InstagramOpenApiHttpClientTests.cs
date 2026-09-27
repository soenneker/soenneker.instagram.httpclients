using Soenneker.Instagram.HttpClients.Abstract;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.Instagram.HttpClients.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class InstagramOpenApiHttpClientTests : HostedUnitTest
{
    private readonly IInstagramOpenApiHttpClient _httpclient;

    public InstagramOpenApiHttpClientTests(Host host) : base(host)
    {
        _httpclient = Resolve<IInstagramOpenApiHttpClient>(true);
    }

    [Test]
    public void Default()
    {

    }
}
