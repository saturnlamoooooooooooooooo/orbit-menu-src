using EclipseX.Mods;
using IIDKQuest.Classes;
using IIDKQuest.Mods;
using static IIDKQuest.Settings;

namespace IIDKQuest.Menu
{
    /*
     This menu has no skidded mods
     if you remove this it is skidding
     Dm LJ/owner if these any bug
     And this is a beta
     */

    internal class Buttons
    {
        public static ButtonInfo[][] buttons = new ButtonInfo[][]
        {
            new ButtonInfo[] { // Main Mods
                new ButtonInfo { buttonText = "Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false,},
                new ButtonInfo { buttonText = "Room", method =() => SettingsMods.Room(), isTogglable = false,},
                new ButtonInfo { buttonText = "Movement", method =() => SettingsMods.Movement(), isTogglable = false,},
                new ButtonInfo { buttonText = "Advantage", method =() => SettingsMods.Advantage(), isTogglable = false,},
                new ButtonInfo { buttonText = "VRRig", method =() => SettingsMods.VrRig(), isTogglable = false,},
                new ButtonInfo { buttonText = "NameTag", method =() => SettingsMods.NameTag(), isTogglable = false,},
                new ButtonInfo { buttonText = "Player", method =() => SettingsMods.Player(), isTogglable = false,},
                new ButtonInfo { buttonText = "<color=red>Overpowered</color>", method =() => SettingsMods.Overpowered(), isTogglable = false,},
                new ButtonInfo { buttonText = "<color=yellow>Make Sure To Go Back A Page</color>", isTogglable = false},
                new ButtonInfo { buttonText = "Safety", method =() => SettingsMods.Safety(), isTogglable = false,},
                new ButtonInfo { buttonText = "SMH", method =() => SettingsMods.SMH(), isTogglable = false,},
                new ButtonInfo { buttonText = "Sounboard", method =() => SettingsMods.SoundBorad(), isTogglable = false,},
                new ButtonInfo { buttonText = "Photon", method =() => SettingsMods.Photon(), isTogglable = false,},
                new ButtonInfo { buttonText = "Admin Mods", method =() => SettingsMods.Admin(), isTogglable = false,},

            },

            new ButtonInfo[] { // Settings
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false,},
                new ButtonInfo { buttonText = "Right Hand", enableMethod =() => SettingsMods.RightHand(), disableMethod =() => SettingsMods.LeftHand(),},
                new ButtonInfo { buttonText = "Status", method =() => StartUpMods.StumpTexty(),},                                         
                new ButtonInfo { buttonText = "Destroy Status", method =() => StartUpMods.DestroyStumpText(),},
                new ButtonInfo { buttonText = "FPS Counter", enableMethod =() => SettingsMods.EnableFPSCounter(), disableMethod =() => SettingsMods.DisableFPSCounter(), enabled = fpsCounter,},
                new ButtonInfo { buttonText = "Disconnect Button", enableMethod =() => SettingsMods.EnableDisconnectButton(), disableMethod =() => SettingsMods.DisableDisconnectButton(), enabled = disconnectButton,},
                new ButtonInfo  { buttonText = "Change Theme", method = () => ThemeSettings.ChangeTheme(),},
                new ButtonInfo { buttonText =  "Change Tag Aura Distance [" + SettingsMods.tagAuraDistance + "]", method =() => SettingsMods.ChangeTagAuraRange(), isTogglable = false,
},


            },

            new ButtonInfo[] { // Menu Settings
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false,},
                
            },

            new ButtonInfo[] { // Movement Settings
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false,},

            },

            new ButtonInfo[] { // Projectile Settings
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false,},

            },
            new ButtonInfo[] { // Room
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false,},
                new ButtonInfo { buttonText = "Join Code [<color=magenta>E</color>clipseX]", method =() => Utility.JoinMenuRoom(),},
                new ButtonInfo { buttonText = "Quit Game", method =() => RoomMods.QuitApp(),},
                new ButtonInfo { buttonText = "Join Randmom Public", method =() => RoomMods.JoinRandomPub(), isTogglable = false,},
                new ButtonInfo { buttonText = "Disconnect", method =() => RoomMods.Disconnect(), isTogglable = false,},
                new ButtonInfo { buttonText = "Trigger Disconnect", method =() => RoomMods.TriggerDisconnect(),},
                new ButtonInfo { buttonText = "Grip Disconnect", method =() => RoomMods.GripDisconnect(),},


            },

            new ButtonInfo[] { // Movement
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false,},
                new ButtonInfo { buttonText = "Turning [<color=magenta>J</color>]", method = () => MovementMods.Turning(), isTogglable = true,},
                new ButtonInfo { buttonText = "No Clip", method = () => MovementMods.NoClip(), isTogglable = true,},
                new ButtonInfo { buttonText = "Speed Boost [<color=magenta>RG</color>]", method = () => MovementMods.GripSpeedBoost(), isTogglable = true,},
                new ButtonInfo { buttonText = "Mosa Speed [<color=magenta>RG</color>]", method = () => MovementMods.GripMosaBoost(), isTogglable = true,},
                new ButtonInfo { buttonText = "Uncap Max Velocity [<color=red>N/W</color>]", method = () => MovementMods.GripUncapMaxVelocity(), isTogglable = true,},
                new ButtonInfo { buttonText = "Break Gravity [<color=magenta>RG</color>]", method = () => MovementMods.GripBreakGravity(), isTogglable = true,},
                new ButtonInfo { buttonText = "High Gravity [<color=magenta>RG</color>]", method = () => MovementMods.GripHighGravity(), isTogglable = true,},
                new ButtonInfo { buttonText = "Reverse Gravity [<color=magenta>RG</color>]", method = () => MovementMods.GripReverseGravity(),},
                new ButtonInfo { buttonText = "Fling Self [<color=magenta>RG</color>]", method = () => MovementMods.GripNoGravity(),},
                new ButtonInfo { buttonText = "Break Gravity", method = () => MovementMods.BreakGravity(),},
                new ButtonInfo { buttonText = "High Gravity", method = () => MovementMods.HighGravity(),},
                new ButtonInfo { buttonText = "Reverse Gravity", method = () => MovementMods.ReverseGravity(),},
                new ButtonInfo { buttonText = "No Gravity", method = () => MovementMods.NoGravity(),},
                new ButtonInfo { buttonText = "Fix Gravity", method = () => MovementMods.FixGravity(),},
                new ButtonInfo { buttonText = "Speed Boost", method = () => MovementMods.Speedboost(),},
                new ButtonInfo { buttonText = "Mosa Speed", method = () => MovementMods.MosaBoost(),},
                new ButtonInfo { buttonText = "Uncap Max Velocity", method = () => MovementMods.UncapMaxVelocity(),},
                new ButtonInfo { buttonText = "Grip Fly", method = () => MovementMods.Gripfly(),},

            },

            // Working on this
            new ButtonInfo[] { // Advantage
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false,},
                new ButtonInfo { buttonText = "Tag Aura", method =() => Global.ReturnHome(), isTogglable = false,},

            },

            // Working on this
            new ButtonInfo[] { // VRRig
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false,},
                 new ButtonInfo { buttonText = "Long Arms", method = () => MovementMods.LongArms(), isTogglable = true,},
                new ButtonInfo { buttonText = "Fix Arms", method = () => MovementMods.FixArms(), isTogglable = true,},
                 new ButtonInfo { buttonText = "Spaz Monkey", method = () => VrrigMods.SpazMonke(), isTogglable = true,},

            },

            new ButtonInfo[] { // NameTag
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false,},
                new ButtonInfo { buttonText = "EclipseX Tag", method =() => Utility.ChangeName("<color=magenta>EclipseX [ - USER - ]</color>\ndiscord.gg/fFKkB7xdmv"),},
                new ButtonInfo { buttonText = "Eclipse On Top", method =() => Utility.ChangeName("EclipseX On Top\ndiscord.gg/fFKkB7xdmv"),},
                new ButtonInfo { buttonText = "PBBV Name", method =() => Utility.ChangeName("PBBV"),},
                new ButtonInfo { buttonText = "ECHO Name", method =() => Utility.ChangeName("ECHO"),},
                new ButtonInfo { buttonText = "DAISY09 Name", method =() => Utility.ChangeName("DAISY09"),},

            },

            
            new ButtonInfo[] { // Player
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false,},
                new ButtonInfo { buttonText = "Ghost Monkey [<color=mgenta>RP</color>]", method =() => Utility.GhostMonkey(),},
                new ButtonInfo { buttonText = "Invis Monkey [<color=magenta>RT</color>]", method =() => Utility.InvisMonkey(),},

            },

            new ButtonInfo[] { // Overpowered
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false,},
                new ButtonInfo { buttonText = "Insta Crash All [<color=red>N/W</color>]", method =() => Utility.InstaCrashAll(),}, // Yes need fixing idk how
                new ButtonInfo { buttonText = "Crash All V1 [<color=magenta>RG</color>]", method =() => OverpoweredMods.CrashAllV1(),},
                new ButtonInfo { buttonText = "Crash All V2 [<color=magenta>RG</color>]", method =() => OverpoweredMods.CrashAllV2(),},
                new ButtonInfo { buttonText = "Crash All V3 [<color=magenta>RG</color>]", method =() => OverpoweredMods.CrashAllV3(),},
                new ButtonInfo { buttonText = "Crash Gun V1", method =() => OverpoweredMods.CrashGunV1(),},
                new ButtonInfo { buttonText = "Crash Gun V2", method =() => OverpoweredMods.CrashGunV2(),},
                new ButtonInfo { buttonText = "Crash Gun V3", method =() => OverpoweredMods.CrashGunV3(),},

            },

            // Working on this
            new ButtonInfo[] { // Safety
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false,},
                new ButtonInfo { buttonText = "Anti-Report", method =() => SafteyMods.AntiReport(), isTogglable = true,},

            },

            // Working on this
            new ButtonInfo[] { // SMH
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false,},

            },

            new ButtonInfo[] { // SoundBored
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false,},
                new ButtonInfo { buttonText = "Create A Folder", method =() => StartUpMods.CreateFolder(),},
                
            },

            // Working on this
            new ButtonInfo[] { // Photon
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false,},

            },

            new ButtonInfo[] { // Admin
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false,},
                
            },
        };
    }
}
