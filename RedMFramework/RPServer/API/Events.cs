﻿namespace RPServer.API
{
    public static class Events
    {
        public static class ConnectionEvents
        {
            public const string OnPlayerConnecting = "playerConnecting";
            public const string OnPlayerDisconnecting = "playerDropped";
        }

        public static class CharacterCreatorEvents
        {
            public const string CreateCharacterEvent = "CreateCharacterEvent";
        }
    }
}
