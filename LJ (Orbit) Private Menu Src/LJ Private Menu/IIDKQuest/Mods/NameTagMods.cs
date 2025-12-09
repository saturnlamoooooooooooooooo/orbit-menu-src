using System;
using GorillaNetworking;
using Photon.Pun;
using UnityEngine;

namespace IIDKQuest.Mods
{
	// Token: 0x0200000D RID: 13
	internal class NameTagMods
	{
		// Token: 0x0600008E RID: 142 RVA: 0x00005DDB File Offset: 0x00003FDB
		public static void UserName()
		{
			PhotonNetwork.LocalPlayer.NickName = "<color=purple>LJ RIVATE MENU [LJ]</color>\nMenu Made By LJ We're On Top";
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00005DEE File Offset: 0x00003FEE
		public static void LJName()
		{
			PhotonNetwork.LocalPlayer.NickName = "@LJ Is Here Don't Crash\nMenu Made By LJ We're On Top";
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00005E03 File Offset: 0x00004003
		public static void ByeByeID()
		{
			PhotonNetwork.LocalPlayer.NickName = "  \nBye Bye!";
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00005E16 File Offset: 0x00004016
		public static void HashtagNametag()
		{
			PhotonNetwork.LocalPlayer.NickName = "<color=green>##################################################################################</color>";
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00005E29 File Offset: 0x00004029
		public static void NoNametag()
		{
			PhotonNetwork.LocalPlayer.NickName = "  \n  ";
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00005E3C File Offset: 0x0000403C
		public static void BadNameSpaz()
		{
			Random random = new Random();
			int num = random.Next(0, 9);
			string[] array = new string[]
			{
				"Fuck",
				"Ass ",
				"Dick",
				"Bitch",
				"Cock",
				"Asshole"
			};
			PhotonNetwork.LocalPlayer.NickName = array[num];
			PhotonNetwork.LocalPlayer.UserId = array[num];
			GorillaComputer.instance.currentName = array[num];
			PlayerPrefs.SetString("GorillaLocomotion.PlayerName", array[num]);
		}

		// Token: 0x04000076 RID: 118
		private static string nickname;
	}
}
