using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitizenFX.Core;
using RPServer.API;

namespace RPServer.Managers
{
    public class ConnectionManager : BaseScript
    {
        public ConnectionManager()
        {

        }

        [EventHandler(Events.ConnectionEvents.OnPlayerConnecting)]
        private async void OnPlayerConnecting([FromSource] Player player, string playerName, dynamic setKickReason, dynamic deferrals)
        {
            await Delay(0);
            Debug.WriteLine("Player {0} is connecting and their license is {1}", playerName, player.Identifiers["license"]);
        }

        [EventHandler(Events.ConnectionEvents.OnPlayerDisconnecting)]
        private void OnPlayerDisconnecting([FromSource] Player player, string reason)
        {

        }
    }
}
