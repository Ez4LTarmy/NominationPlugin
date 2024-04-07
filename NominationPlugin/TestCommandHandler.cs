namespace NominationPlugin;

using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Core.Attributes.Registration;
using CounterStrikeSharp.API.Modules.Commands;
using Microsoft.Extensions.Logging;

public class TestCommandHandler
{
    private readonly ILogger<TestCommandHandler> _logger;

    public TestCommandHandler(ILogger<TestCommandHandler> logger)
    {
        _logger = logger;
        _logger.LogInformation("Test command handler was injetced with kurumi COCK");
    }

    [ConsoleCommand("css_hello", """Responds to the caller with "pong" """)]
    public void TestCommandHandle(CCSPlayerController? player, CommandInfo commandInfo)
    {
        _logger.LogInformation("Player with id {ID} called the css_hello", player?.SteamID);
    }
}
