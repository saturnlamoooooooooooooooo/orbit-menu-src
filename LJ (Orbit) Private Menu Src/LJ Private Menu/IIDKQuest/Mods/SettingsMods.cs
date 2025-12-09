using System;
using easyInputs;
using IIDKQuest.Menu;

namespace IIDKQuest.Mods
{
	// Token: 0x02000012 RID: 18
	internal class SettingsMods
	{
		// Token: 0x060000C2 RID: 194 RVA: 0x000077A4 File Offset: 0x000059A4
		public static void EnterSettings()
		{
			Main.buttonsType = 1;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000077AD File Offset: 0x000059AD
		public static void MenuSettings()
		{
			Main.buttonsType = 2;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x000077B6 File Offset: 0x000059B6
		public static void MovementSettings()
		{
			Main.buttonsType = 3;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x000077BF File Offset: 0x000059BF
		public static void ProjectileSettings()
		{
			Main.buttonsType = 4;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000077C8 File Offset: 0x000059C8
		public static void Room()
		{
			Main.buttonsType = 5;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x000077D1 File Offset: 0x000059D1
		public static void Movement()
		{
			Main.buttonsType = 6;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x000077DA File Offset: 0x000059DA
		public static void Advantage()
		{
			Main.buttonsType = 7;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x000077E3 File Offset: 0x000059E3
		public static void VrRig()
		{
			Main.buttonsType = 8;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x000077EC File Offset: 0x000059EC
		public static void NameTag()
		{
			Main.buttonsType = 9;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x000077F6 File Offset: 0x000059F6
		public static void Player()
		{
			Main.buttonsType = 10;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00007800 File Offset: 0x00005A00
		public static void Overpowered()
		{
			Main.buttonsType = 11;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000780A File Offset: 0x00005A0A
		public static void Safety()
		{
			Main.buttonsType = 12;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00007814 File Offset: 0x00005A14
		public static void SMH()
		{
			Main.buttonsType = 13;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000781E File Offset: 0x00005A1E
		public static void SoundBored()
		{
			Main.buttonsType = 14;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00007828 File Offset: 0x00005A28
		public static void Experimental()
		{
			Main.buttonsType = 15;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00007832 File Offset: 0x00005A32
		public static void Admin()
		{
			Main.buttonsType = 16;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x0000783C File Offset: 0x00005A3C
		public static void SoundBoradBeta()
		{
			Main.buttonsType = 17;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00007846 File Offset: 0x00005A46
		public static void RightHand()
		{
			Settings.rightHanded = true;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0000784F File Offset: 0x00005A4F
		public static void LeftHand()
		{
			Settings.rightHanded = false;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00007858 File Offset: 0x00005A58
		public static void EnableFPSCounter()
		{
			Settings.fpsCounter = true;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00007861 File Offset: 0x00005A61
		public static void DisableFPSCounter()
		{
			Settings.fpsCounter = false;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0000786A File Offset: 0x00005A6A
		public static void EnableNotifications()
		{
			Settings.disableNotifications = false;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00007873 File Offset: 0x00005A73
		public static void DisableNotifications()
		{
			Settings.disableNotifications = true;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0000787C File Offset: 0x00005A7C
		public static void EnableDisconnectButton()
		{
			Settings.disconnectButton = true;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00007885 File Offset: 0x00005A85
		public static void DisableDisconnectButton()
		{
			Settings.disconnectButton = false;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00007890 File Offset: 0x00005A90
		public static void FreezeRig()
		{
			bool secondaryButtonDown = EasyInputs.GetSecondaryButtonDown(1);
			if (secondaryButtonDown)
			{
				GorillaTagger.Instance.myVRRig.enabled = false;
			}
			else
			{
				GorillaTagger.Instance.myVRRig.enabled = true;
			}
		}
	}
}
