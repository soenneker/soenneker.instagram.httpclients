using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;

namespace Soenneker.Instagram.HttpClients.Abstract;

/// <summary>
/// A .NET thread-safe singleton HttpClient for
/// </summary>
public interface IInstagramOpenApiHttpClient: IDisposable, IAsyncDisposable
{
    ValueTask<HttpClient> Get(CancellationToken cancellationToken = default);
}
