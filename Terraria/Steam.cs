namespace Terraria
{
    using System;
    using System.Runtime.InteropServices;

    public class Steam
    {
        public static bool SteamInit;

        public static void Init()
        {
            SteamInit = SteamAPI_Init();
        }

        public static void Kill()
        {
            SteamAPI_Shutdown();
        }

        [DllImport("steam_api.dll")]
        private static extern bool SteamAPI_Init();
        [DllImport("steam_api.dll")]
        private static extern bool SteamAPI_Shutdown();
    }
}

