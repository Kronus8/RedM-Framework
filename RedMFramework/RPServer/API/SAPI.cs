using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitizenFX.Core;

namespace RPServer.API
{
    public class SAPI : BaseScript
    {
        public SAPI() { }

        public static string GetUserLicense(Player player) => player.Identifiers["license"];
        public static string GetUserSteamId(Player player) => player.Identifiers["steam"];
        public static string GetUserName(Player player) => player.Name;
        public static bool HasRockstarLauncherOpened(Player player) => !string.IsNullOrEmpty(GetUserLicense(player));
    }
}
