using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitizenFX.Core;
using RPServer.API;
using static RPServer.API.SAPI;

namespace RPServer.Managers
{
    public class ConnectionManager : BaseScript
    {
        private UserManager user;

        public ConnectionManager()
        {

        }

        [EventHandler(Events.ConnectionEvents.OnPlayerConnecting)]
        private async void OnPlayerConnecting([FromSource] Player player, string playerName, dynamic setKickReason, dynamic deferrals)
        {
            deferrals.defer();
            await Delay(0);
            Debug.WriteLine("Player {0} is connecting and their license is {1}", playerName, GetUserLicense(player));

            if (!user.DoesUserExist(player))
            {
                await Delay(0);
                user.CreateUser(player);
                return;
            }
            else 
            {
                await Delay(0);
                deferrals.done();
            }
        }

        [EventHandler(Events.ConnectionEvents.OnPlayerDisconnecting)]
        private void OnPlayerDisconnecting([FromSource] Player player, string reason)
        {

        }
    }
}
