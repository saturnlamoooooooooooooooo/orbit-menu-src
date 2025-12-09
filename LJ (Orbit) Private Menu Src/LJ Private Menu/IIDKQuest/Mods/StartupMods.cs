using System;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace IIDKQuest.Mods
{
	// Token: 0x02000015 RID: 21
	internal class StartupMods
	{
		// Token: 0x060000F2 RID: 242 RVA: 0x000086F4 File Offset: 0x000068F4
		public static void CreateFolder()
		{
			bool flag = !Directory.Exists("Sea Client/Soundboard");
			if (flag)
			{
				Directory.CreateDirectory("Sea Client/Soundboard");
			}
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00008720 File Offset: 0x00006920
		public static void StumpTexty()
		{
			bool flag = StartupMods.StumpObj == null;
			if (flag)
			{
				StartupMods.StumpObj = new GameObject("STUMPOBJ");
				TextMeshPro textMeshPro = StartupMods.StumpObj.AddComponent<TextMeshPro>();
				textMeshPro.text = "<color=#FFFFFF>S</color><color=#E5FFFF>e</color><color=#CCFFFF>a</color><color=#B2FFFF> </color><color=#99FFFF>C</color><color=#7FFFFF>l</color>i<color=#66FFFF>e</color><color=#4CFFFF>n</color>t<color=#33FFFF>\nWelcome To <color=#FFFFFF>S</color><color=#E5FFFF>e</color><color=#CCFFFF>a</color><color=#B2FFFF> </color><color=#99FFFF>C</color><color=#7FFFFF>l</color>i<color=#66FFFF>e</color><color=#4CFFFF>n</color>t<color=#33FFFF>.\nThe Only Wet Dll You Will Ever Us\nStats: <color=green>Undetected</color>\n<color=blue>Version: 1.0.0</color>";
				textMeshPro.fontSize = 2f;
				textMeshPro.alignment = 514;
				textMeshPro.color = Color.cyan;
				textMeshPro.font = StartupMods.ArialFontAsset;
				Transform transform = StartupMods.StumpObj.transform;
				transform.localScale = new Vector3(0.6f, 0.6f, 0.6f);
				transform.position = new Vector3(-67.125f, 12.249f, -82.66959f);
			}
			Transform transform2 = StartupMods.StumpObj.transform;
			transform2.LookAt(Camera.main.transform.position);
			transform2.Rotate(0f, 180f, 0f);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00008810 File Offset: 0x00006A10
		public static void DestroyStumpText()
		{
			Object.Destroy(StartupMods.StumpObj);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00008820 File Offset: 0x00006A20
		public static void Motd()
		{
			GameObject.Find("motd").GetComponent<Text>().text = "<color=#FFFFFF>S</color><color=#E5FFFF>e</color><color=#CCFFFF>a</color><color=#B2FFFF> </color><color=#99FFFF>C</color><color=#7FFFFF>l</color>i<color=#66FFFF>e</color><color=#4CFFFF>n</color>t<color=#33FFFF>";
			GameObject.Find("motdtext").GetComponent<Text>().text = "WELLCOME TO <color=#FFFFFF>S</color><color=#E5FFFF>e</color><color=#CCFFFF>a</color><color=#B2FFFF> </color><color=#99FFFF>C</color><color=#7FFFFF>l</color>i<color=#66FFFF>e</color><color=#4CFFFF>n</color>t<color=#33FFFF>.\nTHIS MENU IS FULLY <color=green>UNDETECTED</color>!\nMENU MADE BY <color=red>LJ</color> THANK FOR USING MY MENU\n<color=red>I LJ AM NOT RESPONSIBLE FOR ANY BANS USING THIS MENU</color>\nIF YOU WOULD WANT THE DISCORD HERE -> https://discord.gg/yymMkkd6gz";
			GameObject.Find("CodeOfConduct").GetComponent<Text>().text = "<color=cyan>Important</color>";
			GameObject.Find("COC Text").GetComponent<Text>().text = string.Concat(new string[]
			{
				"Version: [1.0.0]\n<color=green>CREDITS</color> : Jx,Lunar,Saturn\nCHANGE TURN SPEED AT COMPUTER\nMENU MADE BY LJ"
			});
		}

		// Token: 0x04000077 RID: 119
		public static TMP_FontAsset ArialFontAsset;

		// Token: 0x04000078 RID: 120
		private static GameObject StumpObj;

		// Token: 0x04000079 RID: 121
		private static GameObject StumpObj1;
	}
}
