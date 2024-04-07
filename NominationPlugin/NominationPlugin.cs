namespace NominationPlugin;

using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Core.Attributes.Registration;
using CounterStrikeSharp.API.Modules.Commands;
using Microsoft.Extensions.Logging;

public class NominationPlugin : BasePlugin
{
    public override string ModuleName => "Nomination Plugin";

    public override string ModuleVersion => "0.0.0.1";

    public override void Load(bool hotReload)
    {
        Logger.LogInformation("Nomination plugin succesfully loaded");
    }

    [ConsoleCommand("css_hello", """Responds to the caller with "pong" """)]
    public void TestCommandHandle(CCSPlayerController? player, CommandInfo commandInfo)
    {
        Logger.LogInformation("Player with id {ID} called the css_hello", player?.SteamID);
    }
}
