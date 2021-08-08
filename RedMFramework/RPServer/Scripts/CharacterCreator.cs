using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitizenFX.Core;

using RPServer.Database;
using RPShared.Models;

namespace RPServer.Scripts
{
    class CharacterCreator : BaseScript
    {
        public CharacterCreator()
        {

        }

        [EventHandler(API.Events.CharacterCreatorEvents.CreateCharacterEvent)]
        public void CreateCharacterEvent([FromSource] Player player, string FirstName, string LastName)
        {
            string CharID = CreateCharID();
            while (MySQL.Exists($"SELECT * FROM `characters` WHERE `CharID` = '{CharID}'")) { CharID = CreateCharID(); }

            MySQL.Insert("characters", new CharacterData
            {
                CharID = CharID,
                FirstName = FirstName,
                LastName = LastName
            });
        }

        private string CreateCharID()
        {
            string CharID = "";
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                if (random.Next(2) == 1) CharID += (char)(random.Next(26) + 65);
                else CharID += random.Next(10);
            }

            return CharID;
        }
    }
}
