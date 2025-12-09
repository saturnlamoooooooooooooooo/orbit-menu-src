using System;
using GorillaNetworking;
using Photon.Pun;
using UnityEngine;

namespace IIDKQuest.Mods
{
	// Token: 0x02000011 RID: 17
	internal class SafetyMods
	{
		// Token: 0x060000BF RID: 191 RVA: 0x00007620 File Offset: 0x00005820
		public static void FakeLag()
		{
			bool[] array = new bool[5];
			array[0] = true;
			bool[] array2 = array;
			int num = new Random().Next(array2.Length);
			bool flag = array2[num];
			if (flag)
			{
				GorillaTagger.Instance.myVRRig.enabled = false;
			}
			bool[] array3 = new bool[5];
			array3[0] = true;
			bool[] array4 = array3;
			int num2 = new Random().Next(array4.Length);
			bool flag2 = array4[num2];
			if (flag2)
			{
				GorillaTagger.Instance.myVRRig.enabled = true;
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00007698 File Offset: 0x00005898
		public static void BanAnti()
		{
			string[] array = new string[]
			{
				"FREHI33498DJDSFJ",
				"000000000000000",
				"LE89FOPA20OIF19C",
				"B395SLO2DF0AS3F",
				"LHD5GC8GS21HJLO7",
				"OLSEMMN83FL1AS0",
				"SDME09234FND39F8",
				"KDM3LSOI5PDXM53",
				"KRMFGJKNO349SDJ2",
				"JKNDSF66DFIJ22F",
				"BHIJKNS23DEFWUH9",
				"LDO2S09DXLE3ASM",
				"ASDIJ387SNDHAT8"
			};
			int num = new Random().Next(array.Length);
			PhotonNetwork.LocalPlayer.UserId = array[num];
			PhotonNetwork.LocalPlayer._UserId_k__BackingField = array[num];
			PhotonNetwork.LocalPlayer.NickName = "gorilla\nID: " + array[num] + "```\n>nuh uh no id for you biatch";
			GorillaComputer.instance.currentName = "gorilla\nID: " + array[num] + "```\n>nuh uh no id for you biatch";
			PlayerPrefs.SetString("GorillaLocomotion.PlayerName", "gorilla\nID: " + array[num] + "```\n>nuh uh no id for you biatch uh");
		}
	}
}
