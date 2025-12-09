using IIDKQuest.Classes;
using IIDKQuest.Mods;
using MenuTemplate;
using REAK.Menu.mods;
using TemplateMenuByZinx.Menu.mods;
using TemplateMenuByZinx.Menu.notflib.mods;
using Orbital.LOL.Menu;
using static IIDKQuest.Settings;

namespace IIDKQuest.Menu
    
{
    internal class Buttons
    {
        public static ButtonInfo[][] buttons = new ButtonInfo[][]
        {
            new ButtonInfo[] { // Main Mods
   new ButtonInfo { buttonText = "Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Opens the main settings page for the menu." },
new ButtonInfo { buttonText = "Core", method =() => SettingsMods.SoundBoardMods(), isTogglable = false, toolTip = "Opens the main settings page for the menu." },
new ButtonInfo { buttonText = "<color=red", method =() => SettingsMods.creds(), isTogglable = false, toolTip = "Opens the main settings page for the menu." },
new ButtonInfo { buttonText = "Join Random Public (W)", method =() => joinpublic.JoinRandomPublic(), isTogglable = false, toolTip = "Joins a random public room." },
new ButtonInfo { buttonText = "Disconnect (W)", method =() => disconnect.Disconnect(), isTogglable = false, toolTip = "Disconnects from the server." },
new ButtonInfo { buttonText = "Quit APP (W)", method =() => quitgame.quitapp(), isTogglable = false, toolTip = "Quits the application." },
new ButtonInfo { buttonText = "CosmetX", method =() => Cosmetx.AllCosmetics(), isTogglable = false, toolTip = "Quits the application." },
new ButtonInfo { buttonText = "Orbitay.lol Menu Name (W)", method =() => MenuNameTag.MenuNameTagFrFr(), isTogglable = true, toolTip = "Changes your menu name tag." },
new ButtonInfo { buttonText = "Platforms (W)", method =() => Platforms.Platform(), isTogglable = true, toolTip = "Enables platform visuals under you." },
new ButtonInfo { buttonText = "LongArms (W)", method =() => LongArms.LongArmsByOrbit(), isTogglable = true, toolTip = "Enables long arms mod." },
new ButtonInfo { buttonText = "BetterLongArms (W)", method =() => LongArms2.ReallyLongArmsByOrbit(), isTogglable = true, toolTip = "Enables improved long arms." },
new ButtonInfo { buttonText = "ResetLongArms (W)", method =() => ReLongArms.ResetArms(), isTogglable = false, toolTip = "Resets long arms to normal." },
new ButtonInfo { buttonText = "NoTagFreeze (W)", method =() => notagfreeze.DisabletagFreeze(), isTogglable = true, toolTip = "Disables freeze when tagged." },
new ButtonInfo { buttonText = "MosaSpeed (W)", method =() => MosaSpeed.MosaSpeedByOrbit(), isTogglable = true, toolTip = "Increases player speed." },
new ButtonInfo { buttonText = "Fly (W)", method =() => Fly.FlyFr(), isTogglable = true, toolTip = "Enables flight." },
new ButtonInfo { buttonText = "NoCilpFly (W)", method =() => NoClipFly.NoclipFly(), isTogglable = true, toolTip = "Fly through walls (noclip)." },
new ButtonInfo { buttonText = "Tracers (W)", method =() => Tracers.TracerMod(), isTogglable = true, toolTip = "Draws lines to players." },
new ButtonInfo { buttonText = "Box Esp", method =() => Box_Esp.boxesp(), isTogglable = true, toolTip = "Draws lines to players." },
new ButtonInfo { buttonText = "ESP", method =() => esp.Chams(), isTogglable = true, disableMethod =() => esp.destroymethod(), enabled = !disableNotifications, toolTip = "Toggles the notifications."},
new ButtonInfo { buttonText = "Give Watch All [<color=green>SS</color>] (W)", method =() => Givewatchall.givewatchallmod(), isTogglable = false, toolTip = "Gives watch to all players." },
new ButtonInfo { buttonText = "Ghost Monkey (B) (NW)", method =() => ghostmonkey.GhostMonkey(), isTogglable = true, toolTip = "Makes you invisible while not moving." },
new ButtonInfo { buttonText = "Banana OS [<color=green>CS</color>]", method =() => bannaOS.GiveBananaOS(), isTogglable = false, toolTip = "Launches Banana OS." },
new ButtonInfo { buttonText = "Crash Gun(<color=red>OP-LAGGY</color>)", method =() => CrashGun.Activate(), isTogglable = true, toolTip = "Attempts to crash another player." },
new ButtonInfo { buttonText = "Kick Gun", method =() => SpringGun.Activate(), isTogglable = true, toolTip = "Attempts to kick another player." },
new ButtonInfo { buttonText = "Touch To Crash Player", method =() => touch_to_crash.tch2crash(), isTogglable = true, toolTip = "Attempts to kick another player." },
new ButtonInfo { buttonText = "Stump Text", method =() => StumpText.StumpTexty(), isTogglable = true, toolTip = "Enables text display in stump." },
new ButtonInfo { buttonText = "Motd", method =() => MOTD.Boards(), isTogglable = false, toolTip = "Shows the message of the day board." },
new ButtonInfo { buttonText = "Punch Mod", method =() => BoxingMods.BetterPunchMod(), isTogglable = true, toolTip = "Enables punch physics for players." },
new ButtonInfo { buttonText = "Set Master-Client", method =() => OverpoweredModsCat.SetMaster(), isTogglable = false, toolTip = "Sets you as the master client." },
new ButtonInfo { buttonText = "Auto Master Client", method =() => OverpoweredModsCat.SetMaster(), isTogglable = true, toolTip = "Automatically becomes master client." },
new ButtonInfo { buttonText = "Clean Server", method =() => OverpoweredModsCat.CrashAll(), isTogglable = false, toolTip = "Toggles stump text." },
new ButtonInfo { buttonText = "Low HZ", method =() => ModscoolbyLunar.hz(), isTogglable = false, toolTip = "Shows the message of the day." },
new ButtonInfo { buttonText = "Join Menu Room", method =() => ModscoolbyLunar.JoinMenuRoom(), isTogglable = false, toolTip = "Shows the message of the day." },
new ButtonInfo { buttonText = "Button Spam", method =() => buttonspam.Gorillascoreboardspam(), isTogglable = true, toolTip = "Shows the message of the day." },
new ButtonInfo { buttonText = "Button Gun", method =() => ModscoolbyLunar.JoinMenuRoom(), isTogglable = true, toolTip = "Shows the message of the day." },
new ButtonInfo { buttonText = "2 Box ESP", method =() => ESPBoxDrawer.DrawBox(), isTogglable = true, toolTip = "Shows the message of the day." },
new ButtonInfo { buttonText = "1X1 Lego Piece", method =() => Caseoh.caseohreal(), isTogglable = true, toolTip = "Shows the message of the day." },
new ButtonInfo { buttonText = "Pee", method =() => pee.Piss(), isTogglable = true, toolTip = "Shows the message of the day." },
new ButtonInfo { buttonText = "Poop", method =() => poop.Poop(), isTogglable = true, toolTip = "Shows the message of the day." },
new ButtonInfo { buttonText = "Nuke Forest", method =() => nuke.NukeForest(), isTogglable = true, toolTip = "Shows the message of the day." },
new ButtonInfo { buttonText = "Yellow Enemy Spammer", method =() => spamenemy.EnemySpam(), isTogglable = true, toolTip = "Shows the message of the day." },
new ButtonInfo { buttonText = "Menu Themed Enemy", method =() => spamenemyredandblack.EnemySpam(), isTogglable = true, toolTip = "Shows the message of the day." },
new ButtonInfo { buttonText = "Rain", method =() =>  cuberain.Cuberain(), isTogglable = true, toolTip = "Shows the message of the day." },
new ButtonInfo { buttonText = "Network player self", method =() => become_ball.becomeball(), isTogglable = true, toolTip = "Shows the message of the day." },
new ButtonInfo { buttonText = "Casual", method =() =>  CASUAL.causals(), isTogglable = true, toolTip = "Shows the message of the day." },
new ButtonInfo { buttonText = "Infection", method =() =>  infection.infections(), isTogglable = true, toolTip = "Shows the message of the day." },
new ButtonInfo { buttonText = "High Quality Mic", method =() => mic_mods.highqualitymic(), isTogglable = true, toolTip = "Shows the message of the day." },
new ButtonInfo { buttonText = "Low Quality mic", method =() =>  mic_mods.lowqualitymic(), isTogglable = true, toolTip = "Shows the message of the day." },
new ButtonInfo { buttonText = "Loud Mic", method =() =>  mic_mods.loudmic(), isTogglable = true, toolTip = "Shows the message of the day." },
new ButtonInfo { buttonText = "Fix Mic", method =() =>  mic_mods.fixmic(), isTogglable = true, toolTip = "Shows the message of the day." },
new ButtonInfo { buttonText = "RGB Sky", method =() => SkyMods.RGBSKY(), isTogglable = true, toolTip = "Shows the message of the day." },
new ButtonInfo { buttonText = "Custom Bananaos Test", method =() => bananaOS.GiveBananaOS(), isTogglable = true, toolTip = "Shows the message of the day." },







            },

            new ButtonInfo[] { // Settings
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Menu", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the settings for the menu."},
                new ButtonInfo { buttonText = "Movement", method =() => SettingsMods.MovementSettings(), isTogglable = false, toolTip = "Opens the movement settings for the menu."},
                new ButtonInfo { buttonText = "Saftey", method =() => SettingsMods.SafteySettings(), isTogglable = false, toolTip = "Opens the projectile settings for the menu."},
                new ButtonInfo { buttonText = "Projectile", method =() => SettingsMods.ProjectileSettings(), isTogglable = false, toolTip = "Opens the projectile settings for the menu."},
            },

            new ButtonInfo[] { // Menu Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
                new ButtonInfo { buttonText = "Right Hand", enableMethod =() => SettingsMods.RightHand(), disableMethod =() => SettingsMods.LeftHand(), toolTip = "Puts the menu on your right hand."},
                new ButtonInfo { buttonText = "Notifications", enableMethod =() => SettingsMods.EnableNotifications(), disableMethod =() => SettingsMods.DisableNotifications(), enabled = !disableNotifications, toolTip = "Toggles the notifications."},
                new ButtonInfo { buttonText = "FPS Counter", enableMethod =() => SettingsMods.EnableFPSCounter(), disableMethod =() => SettingsMods.DisableFPSCounter(), enabled = fpsCounter, toolTip = "Toggles the FPS counter."},
                new ButtonInfo { buttonText = "Disconnect Button", enableMethod =() => SettingsMods.EnableDisconnectButton(), disableMethod =() => SettingsMods.DisableDisconnectButton(), enabled = disconnectButton, toolTip = "Toggles the disconnect button."},
        
            },

            new ButtonInfo[] { // Movement Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
                new ButtonInfo { buttonText = "Turning", method =() => turning.Turning(), isTogglable = true, toolTip = "Shows the message of the day." },
            },

                new ButtonInfo[] { // Saftey Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
                new ButtonInfo { buttonText = "Anti Crash", method =() => AntiCrash.ClearObjects(), isTogglable = true, toolTip = "Shows the message of the day." },
                   new ButtonInfo { buttonText = "Anti Anti AFK Kick", method =() => AntiAFK.EnableAFK(), isTogglable = true, toolTip = "Shows the message of the day." },
            },

            new ButtonInfo[] { // Projectile Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the settings for the menu."},
            },

            new ButtonInfo[] { // SoundBoard Mods
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Opens the settings for the menu."},
                new ButtonInfo { buttonText = "Coming Soon To The [<color=green>PAID!</color>] Version", isTogglable = true},
            },
            new ButtonInfo[] { // Credit's 
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Opens the settings for the menu."},
                new ButtonInfo { buttonText = "Lunar/Vanq [ <color=green>Co</color>-Dev ]", isTogglable = true, toolTip = "Opens the settings for the menu." },
                new ButtonInfo { buttonText = "Orbit[ <color=green>Main</color>-Dev ]", isTogglable = true, toolTip = "Opens the settings for the menu." },



            },

    };
        };
}; 