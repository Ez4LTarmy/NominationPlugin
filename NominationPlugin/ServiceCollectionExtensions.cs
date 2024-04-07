namespace NominationPlugin;

using global::NominationPlugin.Handlers;
using Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static void AddCommandHandlers(
        this IServiceCollection services,
        Type[] excludedTypes)
    {
        var types = AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(assembly => assembly.GetTypes())
            .Where(type =>
                typeof(ICommandHandler).IsAssignableFrom(type) &&
                !type.IsInterface &&
                !type.IsAbstract &&
                !excludedTypes.Contains(type));

        foreach (var type in types)
        {
            services.AddSingleton(type);
        }
    }

    public static void AddCommandHandlers(this IServiceCollection services)
        => AddCommandHandlers(services, Array.Empty<Type>());
}
