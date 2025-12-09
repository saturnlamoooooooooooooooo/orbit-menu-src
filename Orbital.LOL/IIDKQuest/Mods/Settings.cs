using static IIDKQuest.Menu.Main;
using static IIDKQuest.Settings;

namespace IIDKQuest.Mods
{
    internal class SettingsMods
    {
        public static void EnterSettings()
        {
            buttonsType = 1;
        }

        public static void MenuSettings()
        {
            buttonsType = 2;
        }

        public static void MovementSettings()
        {
            buttonsType = 3;
        }
        public static void SafteySettings()
        {
            buttonsType = 4;
        }
        public static void ProjectileSettings()
        {
            buttonsType = 5;
        }
        
        public static void SoundBoardMods()
        {
            buttonsType = 6;
        }
        public static void creds()
        {
            buttonsType = 7;
        }

        public static void RightHand()
        {
            rightHanded = true;
        }

        public static void LeftHand()
        {
            rightHanded = false;
        }

        public static void EnableFPSCounter()
        {
            fpsCounter = true;
        }

        public static void DisableFPSCounter()
        {
            fpsCounter = false;
        }

        public static void EnableNotifications()
        {
            disableNotifications = false;
        }

        public static void DisableNotifications()
        {
            disableNotifications = true;
        }

        public static void EnableDisconnectButton()
        {
            disconnectButton = true;
        }

        public static void DisableDisconnectButton()
        {
            disconnectButton = false;
        }
    }
}
