using System;
using IIDKQuest.Classes;
using IIDKQuest.Menu;
using UnityEngine;

namespace IIDKQuest
{
	// Token: 0x02000003 RID: 3
	internal class Settings
	{
		// Token: 0x0400000A RID: 10
		public static ExtGradient backgroundColor = new ExtGradient
		{
			isRainbow = true
		};

		// Token: 0x0400000B RID: 11
		public static ExtGradient[] buttonColors = new ExtGradient[]
		{
			new ExtGradient
			{
				colors = Main.GetSolidGradient(Color.black)
			},
			new ExtGradient
			{
				isRainbow = true
			}
		};

		// Token: 0x0400000C RID: 12
		public static Color[] textColors = new Color[]
		{
			Color.white,
			Color.white
		};

		// Token: 0x0400000D RID: 13
		public static Font currentFont = Resources.GetBuiltinResource<Font>("Arial.ttf");

		// Token: 0x0400000E RID: 14
		public static bool fpsCounter = true;

		// Token: 0x0400000F RID: 15
		public static bool disconnectButton = true;

		// Token: 0x04000010 RID: 16
		public static bool rightHanded = false;

		// Token: 0x04000011 RID: 17
		public static bool disableNotifications = false;

		// Token: 0x04000012 RID: 18
		public static KeyCode keyboardButton = 113;

		// Token: 0x04000013 RID: 19
		public static Vector3 menuSize = new Vector3(0.1f, 1f, 1f);

		// Token: 0x04000014 RID: 20
		public static int buttonsPerPage = 8;
	}
}
