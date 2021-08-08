using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CitizenFX.Core;
using CitizenFX.Core.Native;
using static CitizenFX.Core.Native.API;

using Newtonsoft.Json;

namespace RPClient.API
{
    class CAPI : BaseScript
    {
        public CAPI()
        {
            
        }

        public static void Call(long address, params InputArgument[] args) => Function.Call((Hash)address, args);
        public static void Call(ulong address, params InputArgument[] args) => Function.Call((Hash)address, args);
        public static void HideHudComponent(uint component) => Call(0x4CC5F2FC1332577F, component);
        public static void EnableAttributeCoreOverpower(int Ped, int coreIndex, float value, bool makeSound) => Call(0x4AF5A4C7B9157D14, Ped, coreIndex, value, makeSound);
    }
}
