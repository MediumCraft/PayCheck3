﻿using ModdableWebServer;
using ModdableWebServer.Attributes;
using ModdableWebServer.Helper;
using NetCoreServer;

namespace PayCheckServerLib.Responses
{
    public class LobbyBlocked
    {
        [HTTP("GET", "/lobby/v1/public/player/namespaces/{namespace}/users/me/blocked-by")]
        public static bool Blocked(HttpRequest request, PC3Server.PC3Session session)
        {
            ResponseCreator response = new();
            response.SetBody("{\r\n    \"data\": []\r\n}");
            session.SendResponse(response.GetResponse());
            return true;
        }

        [HTTP("GET", "/lobby/v1/public/player/namespaces/{namespace}/users/me/blocked")]
        public static bool BlockedBy(HttpRequest request, PC3Server.PC3Session session)
        {
            ResponseCreator response = new();
            response.SetBody("{\r\n    \"data\": []\r\n}");
            session.SendResponse(response.GetResponse());
            return true;
        }
    }
}
