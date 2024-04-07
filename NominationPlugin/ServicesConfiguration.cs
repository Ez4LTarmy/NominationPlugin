namespace NominationPlugin;

using CounterStrikeSharp.API.Core;
using Microsoft.Extensions.DependencyInjection;

public class ServicesConfiguration : IPluginServiceCollection<NominationPlugin>
{
    public void ConfigureServices(IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<TestCommandHandler>();
    }
}
