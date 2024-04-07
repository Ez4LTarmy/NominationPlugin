namespace NominationPlugin.Handlers;

using CounterStrikeSharp.API.Core;
using Microsoft.Extensions.Logging;

public class TestCommandHandler : ICommandHandler
{
    private readonly ILogger<TestCommandHandler> _logger;
    private readonly BasePlugin _plugin;

    public TestCommandHandler(
        ILogger<TestCommandHandler> logger,
        BasePlugin plugin)
    {
        _logger = logger;
        _plugin = plugin;

        _logger.LogInformation("Log from ctor");
    }

    public void Register()
    {
        _logger.LogInformation("log from register");

        _plugin.AddCommand("css_test2", "desc", (player, context) =>
        {
            _logger.LogInformation("Player with id {ID} called the css_hello", player?.SteamID);
        });
    }
}
