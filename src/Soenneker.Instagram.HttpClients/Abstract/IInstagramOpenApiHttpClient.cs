using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;

namespace Soenneker.Instagram.HttpClients.Abstract;

/// <summary>
/// Provides a cached, authenticated HttpClient for the Instagram Graph API.
/// </summary>
public interface IInstagramOpenApiHttpClient: IDisposable, IAsyncDisposable
{
    /// <summary>
    /// Gets the cached HTTP client using the configured access token and API base URL.
    /// </summary>
    /// <param name="cancellationToken">Token used to cancel client initialization.</param>
    /// <returns>The configured HTTP client.</returns>
    ValueTask<HttpClient> Get(CancellationToken cancellationToken = default);
}
