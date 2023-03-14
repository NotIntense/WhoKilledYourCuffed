using System.Collections.Generic;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using Exiled.Loader;

namespace WhoKilledYourCuffed
{
    public class SPlayer
    {
        public void PlayerDeath(DyingEventArgs ev)
        {
           if(ev.Player.IsCuffed && ev.Attacker.Role.Team == ev.Player.Role.Team) 
           {
                ev.Player.Cuffer.Broadcast(duration: 5, message: $"<color=#00FFFF>{ev.Attacker.Nickname} has killed your cuffed player, {ev.Player.Nickname}!</color>");
           }
        }
    }
}
