namespace NominationPlugin;

using CounterStrikeSharp.API.Core;
using Microsoft.Extensions.DependencyInjection;

public class ServicesDependencyInjection : IPluginServiceCollection<NominationPlugin>
{
    public void ConfigureServices(IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<BasePlugin>();
        serviceCollection.AddCommandHandlers();
    }
}
