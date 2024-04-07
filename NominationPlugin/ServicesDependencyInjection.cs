namespace NominationPlugin;

using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Core.Plugin;
using Microsoft.Extensions.DependencyInjection;

public class ServicesDependencyInjection : IPluginServiceCollection<NominationPlugin>
{
    public void ConfigureServices(IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<IPluginContext>();
        serviceCollection.AddCommandHandlers();
    }
}
