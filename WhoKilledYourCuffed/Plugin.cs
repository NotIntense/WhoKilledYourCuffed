using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.CreditTags;
using Exiled.Events.Handlers;
using System;
using PlayerHandlers = Exiled.Events.Handlers.Player;


namespace WhoKilledYourCuffed
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin Instance;
        public override string Author => "NotIntense";
        public override string Prefix => "WKYCP";
        public override string Name => "WhoKilledYourCuffedPlayer";
        public override Version RequiredExiledVersion { get; } = new(6, 0, 0);
        public override Version Version { get; } = new(1, 0, 0);

        public override PluginPriority Priority => PluginPriority.Medium;

        public SPlayer player;
        public override void OnEnabled()
        {
            Instance = this;
            RegisterEvents();
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            UnRegister();
        }

        public void RegisterEvents()
        {
            player = new SPlayer();
            PlayerHandlers.Dying += Plugin.Instance.player.PlayerDeath;
        }
        public void UnRegister()
        {
            base.OnDisabled();
        }
    }
}
