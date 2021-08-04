using System;
using CitizenFX.Core;
using RPServer.API;

namespace RPServer.Managers
{
    public class ConnectionManager : BaseScript
    {
        private UserManager user = new UserManager();

        public ConnectionManager() { }

        [EventHandler(Events.ConnectionEvents.OnPlayerConnecting)]
        private async void OnPlayerConnecting([FromSource] Player player, string playerName, dynamic setKickReason, dynamic deferrals)
        {
            deferrals.defer();

            await Delay(0);

            if (!user.DoesUserExist(player))
            {
                await Delay(0);
                user.CreateUser(player);
                return;
            }
            else
            {
                var userData = user.Get(player);
                await Delay(0);

                if (userData.Banned == 1)
                {
                    await Delay(0);
                    deferrals.done("Banned!");
                    return;
                }
                else
                {
                    deferrals.done();
                }
            }
        }

        [EventHandler(Events.ConnectionEvents.OnPlayerDisconnecting)]
        private void OnPlayerDisconnecting([FromSource] Player player, string reason)
        {
            Debug.WriteLine("Player {0} is disconnecting.", player.Name);
        }
    }
}
