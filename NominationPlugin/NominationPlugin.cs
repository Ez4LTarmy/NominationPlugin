namespace NominationPlugin;

using CounterStrikeSharp.API.Core;
using Microsoft.Extensions.Logging;

public class NominationPlugin : BasePlugin
{
    public override string ModuleName => "Nomination Plugin";

    public override string ModuleVersion => "0.0.0.1";

    public override string ModuleAuthor => "lt.army, not_kurumi";

    public override string ModuleDescription => "SEX";

    public override void Load(bool hotReload)
    {
        Logger.LogInformation("Plugin was loaded successfully");

        AddCommand("css_test1", "desc", (player, context) =>
        {
            Logger.LogInformation("Player with id {ID} called the css_hello", player?.SteamID);
        });
    }

    public override void Unload(bool hotReload)
    {
        Logger.LogInformation("Plugin was unloaded successfully");
    }
}
