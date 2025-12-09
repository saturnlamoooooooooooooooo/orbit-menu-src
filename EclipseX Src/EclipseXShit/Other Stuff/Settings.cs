using easyInputs;
using UnityEngine;
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

        public static void ProjectileSettings()
        {
            buttonsType = 4;
        }

        public static void Room()
        {
            buttonsType = 5;
        }

        public static void Movement()
        {
            buttonsType = 6;
        }

        public static void Advantage()
        {
            buttonsType = 7;
        }

        public static void VrRig()
        {
            buttonsType = 8;
        }

        public static void NameTag()
        {
            buttonsType = 9;
        }

        public static void Player()
        {
            buttonsType = 10;
        }

        public static void Overpowered()
        {
            buttonsType = 11;
        }

        public static void Safety()
        {
            buttonsType = 12;
        }

        public static void SMH()
        {
            buttonsType = 13;
        }

        public static void SoundBorad()
        {
            buttonsType = 14;
        }

        public static void Photon()
        {
            buttonsType = 15;
        }

        public static void Admin()
        {
            buttonsType = 16;
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
        public static void ChangeTagAuraRange() // iidks tag aura
        {
            tagAuraIndex++;
            if (tagAuraIndex > 3)
            {
                tagAuraIndex = 0;
            }
            string[] names = new string[]
            {
                "Yes",
                "Normal",
                "Far",
                "Maximum"
            };
            float[] distances = new float[]
            {
                9223372036854775808,
                1.666f,
                3f,
                5f
            };

            tagAuraDistance = distances[tagAuraIndex];
            GetIndex("ctaRange").overlapText = "Change Tag Aura Distance <color=grey>[</color><color=green>" + names[tagAuraIndex] + "</color><color=grey>]</color>";
        }

        public static float tagAuraDistance = 1.666f;
        public static int tagAuraIndex = 1;

    }
}
