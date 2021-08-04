using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPClient.API
{
    public static class Events
    {
        public static class BaseEvents
        {
            public const string OnResourceStart = "onResourceStart";
            public const string OnResourceStop = "onResourceStop";
            public const string OnClientResourceStart = "onClientResourceStart";
            public const string OnClientResourceStop = "onClientResourceStop";
            public const string OnPopulationPedCreating = "populationPedCreating";
            public const string OnPlayerActivated = "playerActivated";
            public const string OnSessionInitialized = "sessionInitialized";
        }

        public static class Session
        {
            public const string OnPlayerActivated = "playerActivated";
            public const string OnSessionInitialized = "sessionInitialized";
        }

        public static class Map
        {
            public const string OnClientMapStart = "onClientMapStart";
            public const string OnClientMapStop = "onClientMapStop";
            public const string OnClientGameTypeStart = "onClientGameTypeStart";
            public const string OnClientGameTypeStop = "onClientGameTypeStop";
            public const string OnGetMapDirectives = "getMapDirectives";
        }

        public static class Chat
        {
            public const string OnChatMessage = "chatMessage";
            public const string OnAddMessage = "chat:addMessage";
            public const string OnAddTemplate = "chat:addTemplate";
            public const string OnAddSuggestion = "chat:addSuggestion";
            public const string OnRemoveSuggestion = "chat:removeSuggestion";
            public const string OnClear = "chat:clear";
        }
    }
}
