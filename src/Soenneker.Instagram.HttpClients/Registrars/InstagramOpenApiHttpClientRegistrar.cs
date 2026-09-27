using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.Instagram.HttpClients.Abstract;
using Soenneker.Utils.HttpClientCache.Registrar;

namespace Soenneker.Instagram.HttpClients.Registrars;

/// <summary>
/// Registers the OpenAPI HttpClient wrapper for dependency injection.
/// </summary>
public static class InstagramOpenApiHttpClientRegistrar
{
    /// <summary>
    /// Adds <see cref="InstagramOpenApiHttpClient"/> as a singleton service. <para/>
    /// </summary>
    public static IServiceCollection AddInstagramOpenApiHttpClientAsSingleton(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddSingleton<IInstagramOpenApiHttpClient, InstagramOpenApiHttpClient>();

        return services;
    }

    /// <summary>
    /// Adds <see cref="InstagramOpenApiHttpClient"/> as a scoped service. <para/>
    /// </summary>
    public static IServiceCollection AddInstagramOpenApiHttpClientAsScoped(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddScoped<IInstagramOpenApiHttpClient, InstagramOpenApiHttpClient>();

        return services;
    }
}
