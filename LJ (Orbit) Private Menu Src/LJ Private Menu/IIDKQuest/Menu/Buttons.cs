using System;
using IIDKQuest.Classes;
using IIDKQuest.Mods;
using StupidTemplate.Menu;
using UnityEngine;

namespace IIDKQuest.Menu
{
	// Token: 0x02000018 RID: 24
	internal class Buttons
	{
		// Token: 0x0400007A RID: 122
		public static ButtonInfo[][] buttons = new ButtonInfo[][]
		{
			new ButtonInfo[]
			{
				new ButtonInfo
				{
					buttonText = "Settings",
					method = delegate()
					{
						SettingsMods.EnterSettings();
					},
					isTogglable = false,
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Room",
					method = delegate()
					{
						SettingsMods.Room();
					},
					isTogglable = false,
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Movement",
					method = delegate()
					{
						SettingsMods.Movement();
					},
					isTogglable = false,
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Advantage",
					method = delegate()
					{
						SettingsMods.Advantage();
					},
					isTogglable = false,
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "VRRig",
					method = delegate()
					{
						SettingsMods.VrRig();
					},
					isTogglable = false,
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "NameTag",
					method = delegate()
					{
						SettingsMods.NameTag();
					},
					isTogglable = false,
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Player",
					method = delegate()
					{
						SettingsMods.Player();
					},
					isTogglable = false,
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "<color=red>Overpowered</color>",
					method = delegate()
					{
						SettingsMods.Overpowered();
					},
					isTogglable = false,
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "<color=yellow>Make Sure To Go Back A Page</color>",
					isTogglable = false
				},
				new ButtonInfo
				{
					buttonText = "Safety",
					method = delegate()
					{
						SettingsMods.Safety();
					},
					isTogglable = false,
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "SMH",
					method = delegate()
					{
						SettingsMods.SMH();
					},
					isTogglable = false,
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Sounboard",
					method = delegate()
					{
						SettingsMods.SoundBored();
					},
					isTogglable = false,
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Photon",
					method = delegate()
					{
						SettingsMods.Experimental();
					},
					isTogglable = false,
					toolTip = "Opens the main settings page for the menu."
				}
			},
			new ButtonInfo[]
			{
				new ButtonInfo
				{
					buttonText = "Return to Main",
					method = delegate()
					{
						Global.ReturnHome();
					},
					isTogglable = false,
					toolTip = "Returns to the main page of the menu."
				},
				new ButtonInfo
				{
					buttonText = "Right Hand",
					enableMethod = delegate()
					{
						SettingsMods.RightHand();
					},
					disableMethod = delegate()
					{
						SettingsMods.LeftHand();
					},
					toolTip = "Puts the menu on your right hand."
				},
				new ButtonInfo
				{
					buttonText = "Disconnect Button",
					enableMethod = delegate()
					{
						SettingsMods.EnableDisconnectButton();
					},
					disableMethod = delegate()
					{
						SettingsMods.DisableDisconnectButton();
					},
					enabled = Settings.disconnectButton,
					toolTip = "Toggles the disconnect button."
				},
				new ButtonInfo
				{
					buttonText = "Equip Gun",
					method = delegate()
					{
						mods.GunTemplate();
					},
					isTogglable = true,
					toolTip = "Equips a gun."
				},
				new ButtonInfo
				{
					buttonText = "Smoothness: " + ((mods.num == 5f) ? "Very Fast" : ((mods.num == 10f) ? "Normal" : "Super Smooth")),
					method = delegate()
					{
						mods.GunSmoothNess();
						foreach (ButtonInfo[] array2 in Buttons.buttons)
						{
							foreach (ButtonInfo buttonInfo in array2)
							{
								bool flag = buttonInfo.buttonText.StartsWith("Smoothness");
								if (flag)
								{
									buttonInfo.buttonText = "Smoothness: " + ((mods.num == 5f) ? "Super Smooth" : ((mods.num == 10f) ? "Normal" : "No Smooth"));
								}
							}
						}
					},
					isTogglable = false,
					toolTip = "Changes gun smoothness."
				},
				new ButtonInfo
				{
					buttonText = "Toggle Sphere Size: " + (mods.isSphereEnabled ? "Enabled" : "Disabled"),
					method = delegate()
					{
						mods.isSphereEnabled = !mods.isSphereEnabled;
						bool flag = mods.GunSphere != null;
						if (flag)
						{
							mods.GunSphere.transform.localScale = (mods.isSphereEnabled ? new Vector3(0.1f, 0.1f, 0.1f) : new Vector3(0f, 0f, 0f));
						}
						foreach (ButtonInfo[] array2 in Buttons.buttons)
						{
							foreach (ButtonInfo buttonInfo in array2)
							{
								bool flag2 = buttonInfo.buttonText.StartsWith("Toggle Sphere Size");
								if (flag2)
								{
									buttonInfo.buttonText = "Toggle Sphere Size: " + (mods.isSphereEnabled ? "Enabled" : "Disabled");
								}
							}
						}
					},
					isTogglable = false,
					toolTip = "Toggles the size of the gun sphere."
				},
				new ButtonInfo
				{
					buttonText = "Freeze Player In Menu",
					method = delegate()
					{
						Utility.FreezePlayerInMenu();
					},
					isTogglable = true,
					toolTip = "Lets you float while the menu is open."
				},
				new ButtonInfo
				{
					buttonText = "Ghost In Menu",
					method = delegate()
					{
						Utility.GhostInMenu();
					},
					disableMethod = new Action(Utility.FixGhostRig),
					isTogglable = true,
					toolTip = "Makes you have ghost monke when menu is open."
				}
			},
			new ButtonInfo[]
			{
				new ButtonInfo
				{
					buttonText = "Return to Settings",
					method = delegate()
					{
						SettingsMods.EnterSettings();
					},
					isTogglable = false,
					toolTip = "Returns to the main settings page for the menu."
				}
			},
			new ButtonInfo[]
			{
				new ButtonInfo
				{
					buttonText = "Return to Settings",
					method = delegate()
					{
						SettingsMods.EnterSettings();
					},
					isTogglable = false,
					toolTip = "Returns to the main settings page for the menu."
				}
			},
			new ButtonInfo[]
			{
				new ButtonInfo
				{
					buttonText = "Return to Settings",
					method = delegate()
					{
						SettingsMods.MenuSettings();
					},
					isTogglable = false,
					toolTip = "Opens the settings for the menu."
				}
			},
			new ButtonInfo[]
			{
				new ButtonInfo
				{
					buttonText = "Return to Main",
					method = delegate()
					{
						Global.ReturnHome();
					},
					isTogglable = false,
					toolTip = "Returns to the main page of the menu."
				},
				new ButtonInfo
				{
					buttonText = "Quit Game",
					method = delegate()
					{
						RoomMods.QuitApp();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Join Randmom Public",
					method = delegate()
					{
						RoomMods.JoinRandomPub();
					},
					isTogglable = false,
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Disconnect",
					method = delegate()
					{
						RoomMods.Disconnect();
					},
					isTogglable = false,
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Trigger Disconnect",
					method = delegate()
					{
						RoomMods.TriggerDisconnect();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Grip Disconnect",
					method = delegate()
					{
						RoomMods.GripDisconnect();
					},
					toolTip = "Opens the main settings page for the menu."
				}
			},
			new ButtonInfo[]
			{
				new ButtonInfo
				{
					buttonText = "Return to Main",
					method = delegate()
					{
						Global.ReturnHome();
					},
					isTogglable = false,
					toolTip = "Returns to the main page of the menu."
				},
				new ButtonInfo
				{
					buttonText = "Turning",
					method = delegate()
					{
						MovementMods.TurningMod();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Platfoms",
					method = delegate()
					{
						MovementMods.Platform();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "No Clip",
					method = delegate()
					{
						MovementMods.Noclip();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Long Arms",
					method = delegate()
					{
						MovementMods.BetterLongArms();
					},
					isTogglable = false,
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Small Arms",
					method = delegate()
					{
						MovementMods.SmallArms();
					},
					isTogglable = false,
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Fix Arms",
					method = delegate()
					{
						MovementMods.FixArms();
					},
					isTogglable = false,
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Mosa Speed",
					method = delegate()
					{
						MovementMods.MosaBoost();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Speed Boost",
					method = delegate()
					{
						MovementMods.SpeedBoost();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Grip Mosa Speed",
					method = delegate()
					{
						MovementMods.GripMosaBoost();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Grip Speed Boost",
					method = delegate()
					{
						MovementMods.GripSpeedBoost();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "UncapMaxVelocity",
					method = delegate()
					{
						MovementMods.UncapMaxVelocity();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Break Gravity",
					method = delegate()
					{
						MovementMods.BreakGravity();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "High Gravity",
					method = delegate()
					{
						MovementMods.HighGravity();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Reverse Gravity",
					method = delegate()
					{
						MovementMods.ReverseGravity();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "No Gravity",
					method = delegate()
					{
						MovementMods.NoGravity();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Fix Gravity",
					method = delegate()
					{
						MovementMods.FixGravity();
					},
					isTogglable = false,
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Left And Right",
					method = delegate()
					{
						MovementMods.LeftAndRight();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Forward And Backward",
					method = delegate()
					{
						MovementMods.ForwardAndBackward();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "PSA Foward",
					method = delegate()
					{
						MovementMods.PSAFoward();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Fly",
					method = delegate()
					{
						MovementMods.AFly();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "No Clip Fly",
					method = delegate()
					{
						MovementMods.NoclipAFly();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Trigger Fly",
					method = delegate()
					{
						MovementMods.TriggerFly();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Noclip Trigger Fly",
					method = delegate()
					{
						MovementMods.NoclipTriggerFly();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Tp To Stump",
					method = delegate()
					{
						MovementMods.TpToStump();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Wall Walk",
					method = delegate()
					{
						MovementMods.WallWalk();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Strong Wall Walk",
					method = delegate()
					{
						MovementMods.StrongWallWalk();
					},
					toolTip = "Opens the main settings page for the menu."
				}
			},
			new ButtonInfo[]
			{
				new ButtonInfo
				{
					buttonText = "Return to Main",
					method = delegate()
					{
						Global.ReturnHome();
					},
					isTogglable = false,
					toolTip = "Returns to the main page of the menu."
				},
				new ButtonInfo
				{
					buttonText = "Tag Aura",
					method = delegate()
					{
						AdvantageMods.TagAura();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Tag Self",
					method = delegate()
					{
						AdvantageMods.TagSelf();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Un Tag Self",
					method = delegate()
					{
						AdvantageMods.UnTagSelf();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "LowHZ",
					method = delegate()
					{
						AdvantageMods.LowHZ();
					},
					toolTip = "Opens the main settings page for the menu."
				}
			},
			new ButtonInfo[]
			{
				new ButtonInfo
				{
					buttonText = "Return to Main",
					method = delegate()
					{
						Global.ReturnHome();
					},
					isTogglable = false,
					toolTip = "Returns to the main page of the menu."
				},
				new ButtonInfo
				{
					buttonText = "Reset Hand Taps",
					method = delegate()
					{
						VrRigMods.FixTaps();
					},
					isTogglable = false,
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Fix Hand Taps",
					method = delegate()
					{
						VrRigMods.SlowTapdown();
					},
					isTogglable = false,
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "No Tap Cooldown",
					method = delegate()
					{
						VrRigMods.NoTapCooldown();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Loud Hand Taps",
					method = delegate()
					{
						VrRigMods.LoudHandTaps();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Silent Hand Taps",
					method = delegate()
					{
						VrRigMods.SilentHandTaps();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "No Hand Taps",
					method = delegate()
					{
						VrRigMods.NoHandTaps();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Grippy Hands",
					method = delegate()
					{
						VrRigMods.GrippyHands();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "No Tag Freeze",
					method = delegate()
					{
						VrRigMods.NoTagFreeze();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Tag Freeze",
					method = delegate()
					{
						VrRigMods.TagFreeze();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Slide Control",
					method = delegate()
					{
						VrRigMods.SlideControl();
					},
					toolTip = "Opens the main settings page for the menu."
				}
			},
			new ButtonInfo[]
			{
				new ButtonInfo
				{
					buttonText = "Return to Main",
					method = delegate()
					{
						Global.ReturnHome();
					},
					isTogglable = false,
					toolTip = "Returns to the main page of the menu."
				},
				new ButtonInfo
				{
					buttonText = "LJ Name",
					method = delegate()
					{
						NameTagMods.LJName();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "On Top Name",
					method = delegate()
					{
						NameTagMods.UserName();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Bad Name",
					method = delegate()
					{
						NameTagMods.BadNameSpaz();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Bye Bye Id",
					method = delegate()
					{
						NameTagMods.ByeByeID();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Hash Tag Name",
					method = delegate()
					{
						NameTagMods.HashtagNametag();
					},
					toolTip = "Opens the main settings page for the menu."
				}
			},
			new ButtonInfo[]
			{
				new ButtonInfo
				{
					buttonText = "Return to Main",
					method = delegate()
					{
						Global.ReturnHome();
					},
					isTogglable = false,
					toolTip = "Returns to the main page of the menu."
				},
				new ButtonInfo
				{
					buttonText = "Ghost Monkey",
					method = delegate()
					{
						PlayerMods.GhostMonkey();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Invis Monkey",
					method = delegate()
					{
						PlayerMods.InvisMonkey();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Chams",
					method = delegate()
					{
						PlayerMods.Chams(true);
					},
					disableMethod = delegate()
					{
						PlayerMods.Chams(false);
					},
					isTogglable = true,
					toolTip = "Lets you see players through walls."
				},
				new ButtonInfo
				{
					buttonText = "Tracers",
					method = delegate()
					{
						PlayerMods.Tracers();
					},
					isTogglable = true,
					toolTip = "Points lines at other players."
				},
				new ButtonInfo
				{
					buttonText = "Box ESP",
					method = delegate()
					{
						PlayerMods.BoxESP();
					},
					isTogglable = true,
					toolTip = "Lets you see players through walls."
				},
				new ButtonInfo
				{
					buttonText = "Sphere ESP",
					method = delegate()
					{
						PlayerMods.SphereESP();
					},
					isTogglable = true,
					toolTip = "Lets you see players through walls."
				},
				new ButtonInfo
				{
					buttonText = "Name Tags",
					method = delegate()
					{
						PlayerMods.NameTagESP();
					},
					isTogglable = true,
					toolTip = "Lets you see player info above there head with a name tag."
				},
				new ButtonInfo
				{
					buttonText = "Fix Head",
					method = delegate()
					{
						AdvantageMods.FixHead();
					},
					isTogglable = false,
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Backwards Head",
					method = delegate()
					{
						AdvantageMods.BackwardsHead();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "UpsideDown Head",
					method = delegate()
					{
						AdvantageMods.UpsideDownHead();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Break Head",
					method = delegate()
					{
						AdvantageMods.BreakHead1();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Break Head 2",
					method = delegate()
					{
						AdvantageMods.BreakHead2();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Break Head 3",
					method = delegate()
					{
						AdvantageMods.BreakHead3();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Head Spin X",
					method = delegate()
					{
						AdvantageMods.HeadSpinX();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Head Spin Y",
					method = delegate()
					{
						AdvantageMods.HeadSpinY();
					},
					toolTip = "Opens the main settings page for the menu."
				}
			},
			new ButtonInfo[]
			{
				new ButtonInfo
				{
					buttonText = "Return to Main",
					method = delegate()
					{
						Global.ReturnHome();
					},
					isTogglable = false,
					toolTip = "Returns to the main page of the menu."
				},
				new ButtonInfo
				{
					buttonText = "Clean Server",
					method = delegate()
					{
						OverpoweredMods.CleanServer();
					},
					isTogglable = false,
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Grab Game Info",
					method = delegate()
					{
						OverpoweredMods.GrabGameInfo();
					},
					isTogglable = false,
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Cube Spam",
					method = delegate()
					{
						OverpoweredMods.CubeSpam();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Target Spam",
					method = delegate()
					{
						OverpoweredMods.TargetSpam();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "CosmeticX",
					method = delegate()
					{
						OverpoweredMods.CosmticX();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Cosmetic Spaz",
					method = delegate()
					{
						OverpoweredMods.CosmeticSpam();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Lag All",
					method = delegate()
					{
						OverpoweredMods.LagAll();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Lag All V2",
					method = delegate()
					{
						OverpoweredMods.LagAll2();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "RPC Lag All",
					method = delegate()
					{
						OverpoweredMods.RPCLag();
					},
					isTogglable = true,
					toolTip = "Lags people using rpcs while holding right trigger."
				},
				new ButtonInfo
				{
					buttonText = "Kick All",
					method = delegate()
					{
						OverpoweredMods.KickAll();
					},
					isTogglable = true,
					toolTip = "Lets you kick everyone in stump."
				},
				new ButtonInfo
				{
					buttonText = "Inf Shiny Rocks",
					method = delegate()
					{
						OverpoweredMods.BetaChangeShinyRock(int.MaxValue);
					},
					isTogglable = false,
					toolTip = "Gives you infinite shiny rocks."
				},
				new ButtonInfo
				{
					buttonText = "Crash All",
					method = delegate()
					{
						OverpoweredMods.CrashAll();
					},
					isTogglable = true,
					toolTip = "Lets you crash all while holding right trigger."
				},
				new ButtonInfo
				{
					buttonText = "Crash All V2",
					method = delegate()
					{
						OverpoweredMods.CrashAllV2();
					},
					isTogglable = true,
					toolTip = "Lets you crash all while holding right trigger."
				},
				new ButtonInfo
				{
					buttonText = "Crash All V3",
					method = delegate()
					{
						OverpoweredMods.CrashAllV3();
					},
					isTogglable = true,
					toolTip = "Lets you crash all while holding right trigger."
				}
			},
			new ButtonInfo[]
			{
				new ButtonInfo
				{
					buttonText = "Return to Main",
					method = delegate()
					{
						Global.ReturnHome();
					},
					isTogglable = false,
					toolTip = "Returns to the main page of the menu."
				},
				new ButtonInfo
				{
					buttonText = "No Afk Kick",
					method = delegate()
					{
						RoomMods.NoAfkKick();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Spam Mute All",
					method = delegate()
					{
						Utility.PacketStresser();
					},
					isTogglable = true,
					toolTip = "Spams all the report and mute buttons."
				},
				new ButtonInfo
				{
					buttonText = "Spam Mute All V2",
					method = delegate()
					{
						Utility.BetaSpamMuteAll();
					},
					isTogglable = true,
					toolTip = "Spams all the report and mute buttons."
				},
				new ButtonInfo
				{
					buttonText = "Mat All",
					method = delegate()
					{
						OverpoweredMods.DoMatStuffIdk();
					},
					isTogglable = true,
					toolTip = "Changes everyones mat index."
				}
			},
			new ButtonInfo[]
			{
				new ButtonInfo
				{
					buttonText = "Return to Main",
					method = delegate()
					{
						Global.ReturnHome();
					},
					isTogglable = false,
					toolTip = "Returns to the main page of the menu."
				},
				new ButtonInfo
				{
					buttonText = "Full Bright",
					method = delegate()
					{
						SMHMods.FullBright();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Timmy Spam",
					method = delegate()
					{
						SMHMods.TimmySpam();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Stalker Spam",
					method = delegate()
					{
						SMHMods.StalkerSpam();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Timmy All",
					method = delegate()
					{
						SMHMods.TimmyAll();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Stalker All",
					method = delegate()
					{
						SMHMods.StalkerAll();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Timmy Gun",
					method = delegate()
					{
						SMHMods.TimmyGun();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Stalker Gun",
					method = delegate()
					{
						SMHMods.StalkerGun();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Kill Gun",
					method = delegate()
					{
						SMHMods.KillGun();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Kill All",
					method = delegate()
					{
						SMHMods.KillAll();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Spaz Timmy",
					method = delegate()
					{
						SMHMods.SpazTimmy();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Fling Timmy",
					method = delegate()
					{
						SMHMods.FlingTimmy();
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Move Timmy To All",
					method = delegate()
					{
						SMHMods.TimmyAllRigs();
					},
					toolTip = "Opens the main settings page for the menu."
				}
			},
			new ButtonInfo[]
			{
				new ButtonInfo
				{
					buttonText = "Return to Main",
					method = delegate()
					{
						Global.ReturnHome();
					},
					isTogglable = false,
					toolTip = "Returns to the main page of the menu."
				},
				new ButtonInfo
				{
					buttonText = "Create Folder",
					method = delegate()
					{
						StartupMods.CreateFolder();
					},
					isTogglable = false,
					toolTip = "Returns to the main page of the menu."
				},
				new ButtonInfo
				{
					buttonText = "Stop All Sounds",
					method = delegate()
					{
						Soundbored.RestoreMic();
					},
					isTogglable = false,
					toolTip = "Returns to the main page of the menu."
				},
				new ButtonInfo
				{
					buttonText = "Audio 1",
					enableMethod = delegate()
					{
						Soundbored.SounboardPlay("Sea Client/Soundboard/Audio1.wav");
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Audio 2",
					enableMethod = delegate()
					{
						Soundbored.SounboardPlay("Sea Client/Soundboard/Audio2.wav");
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Audio 3",
					enableMethod = delegate()
					{
						Soundbored.SounboardPlay("Sea Client/Soundboard/Audio3.wav");
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Audio 4",
					enableMethod = delegate()
					{
						Soundbored.SounboardPlay("Sea Client/Soundboard/Audio4.wav");
					},
					toolTip = "Opens the main settings page for the menu."
				},
				new ButtonInfo
				{
					buttonText = "Audio 5",
					enableMethod = delegate()
					{
						Soundbored.SounboardPlay("Sea Client/Soundborad/Audio5.wav");
					},
					toolTip = "This Button Was Made by LJ"
				}
			},
			new ButtonInfo[]
			{
				new ButtonInfo
				{
					buttonText = "Return to Main",
					method = delegate()
					{
						Global.ReturnHome();
					},
					isTogglable = false,
					toolTip = "Returns to the main page of the menu."
				},
				new ButtonInfo
				{
					buttonText = "Stick In Car",
					method = delegate()
					{
						Utility.BetaAddItemToCart("LBAAK.");
					},
					isTogglable = false,
					toolTip = "Lets you buy the moderator stick."
				},
				new ButtonInfo
				{
					buttonText = "Admin In Cart",
					method = delegate()
					{
						Utility.BetaAddItemToCart("LBAAD.");
					},
					isTogglable = false,
					toolTip = "Lets you buy the admin badge."
				},
				new ButtonInfo
				{
					buttonText = "Finger Painter In Cart",
					method = delegate()
					{
						Utility.BetaAddItemToCart("LBADE.");
					},
					isTogglable = false,
					toolTip = "Lets you buy the finger painter."
				},
				new ButtonInfo
				{
					buttonText = "Gold Wrench In Cart",
					method = delegate()
					{
						Utility.BetaAddItemToCart("LBABC.");
					},
					isTogglable = false,
					toolTip = "Lets you buy the golden wrench."
				},
				new ButtonInfo
				{
					buttonText = "Cat Ears In Cart",
					method = delegate()
					{
						Utility.BetaAddItemToCart("LHAAB.");
					},
					isTogglable = false,
					toolTip = "Lets you buy the cat ears."
				},
				new ButtonInfo
				{
					buttonText = "Diamond Balloon In Cart",
					method = delegate()
					{
						Utility.BetaAddItemToCart("LMAAR.");
					},
					isTogglable = false,
					toolTip = "Lets you buy the diamond balloon."
				},
				new ButtonInfo
				{
					buttonText = "Canyon Pin In Cart",
					method = delegate()
					{
						Utility.BetaAddItemToCart("LBAAG.");
					},
					isTogglable = false,
					toolTip = "Lets you buy the canyons pin."
				},
				new ButtonInfo
				{
					buttonText = "City Pin In Cart",
					method = delegate()
					{
						Utility.BetaAddItemToCart("LBAAH.");
					},
					isTogglable = false,
					toolTip = "Lets you buy the city pin."
				},
				new ButtonInfo
				{
					buttonText = "Crystals Pin In Cart",
					method = delegate()
					{
						Utility.BetaAddItemToCart("LBAAF.");
					},
					isTogglable = false,
					toolTip = "Lets you buy the caves pin."
				},
				new ButtonInfo
				{
					buttonText = "Gorilla Pin In Cart",
					method = delegate()
					{
						Utility.BetaAddItemToCart("LBAAI.");
					},
					isTogglable = false,
					toolTip = "Lets you buy the gorilla pin."
				},
				new ButtonInfo
				{
					buttonText = "Mountain Pin In Cart",
					method = delegate()
					{
						Utility.BetaAddItemToCart("LBABH.");
					},
					isTogglable = false,
					toolTip = "Lets you buy the mountains pin."
				},
				new ButtonInfo
				{
					buttonText = "Tree Pin In Cart",
					method = delegate()
					{
						Utility.BetaAddItemToCart("LBAAA.");
					},
					isTogglable = false,
					toolTip = "Lets you buy the tree pin."
				}
			}
		};
	}
}
