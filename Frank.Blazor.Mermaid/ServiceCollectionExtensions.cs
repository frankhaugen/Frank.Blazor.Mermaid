using Microsoft.Extensions.DependencyInjection;

namespace Frank.Blazor.Mermaid;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddMermaid(this IServiceCollection services)
    {
        services.AddScoped<MermaidInterop>();
        return services;
    }
}