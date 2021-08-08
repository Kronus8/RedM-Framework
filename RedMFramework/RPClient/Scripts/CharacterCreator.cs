using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CitizenFX.Core;

using RPClient.API;

namespace RPClient.Scripts
{
    class CharacterCreator : BaseScript
    {
        public CharacterCreator()
        {

        }

        [Command("createchar")]
        public async Task CreateCharacter(int source, List<object> args, string raw)
        {
            string FirstName = args[0].ToString();
            string LastName = args[1].ToString();

            TriggerServerEvent(Events.CharacterCreator.CreateCharacterEvent, FirstName, LastName);
            await Delay(100);
        }
    }
}
