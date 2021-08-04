using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitizenFX.Core;
using RPShared.Models;
using static RPServer.API.SAPI;

namespace RPServer.Managers
{
    public class UserManager : BaseScript
    {
        public bool DoesUserExist(Player player)
        {
            return false;
        }

        public UserManager()
        {
            
        }

        public void CreateUser(Player player) => new UserData
        {
            License = GetUserLicense(player),
            Name = GetUserName(player),
            Group = "User",
            PermissionLevel = 0,
            Banned = 0
        };
    }
}
