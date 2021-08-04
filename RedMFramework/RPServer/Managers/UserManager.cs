using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitizenFX.Core;
using RPShared.Models;
using static RPServer.API.SAPI;
using RPServer.Database;

namespace RPServer.Managers
{
    public class UserManager : BaseScript
    {
        public bool DoesUserExist(Player player) => MySQL.Exists($"SELECT * FROM users WHERE License='{GetUserLicense(player)}'");
        public UserData Get(Player player) => MySQL.Select<UserData>($"SELECT * FROM users WHERE License=\"{GetUserLicense(player)}\"");

        public UserManager()
        {
            
        }

        public void CreateUser(Player player) => MySQL.Insert("users", new UserData
        {
            License = GetUserLicense(player),
            Name = player.Name,
            PermissionLevel = 0,
            Banned = 0
        });

        public void Save(UserData data) => MySQL.Update("users", $"License='{data.License}'", data);
    }
}
