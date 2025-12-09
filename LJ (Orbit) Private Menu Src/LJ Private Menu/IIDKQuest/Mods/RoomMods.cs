using System;
using easyInputs;
using GorillaNetworking;
using Photon.Pun;
using UnityEngine;

namespace IIDKQuest.Mods
{
	// Token: 0x02000010 RID: 16
	internal class RoomMods
	{
		// Token: 0x060000B1 RID: 177 RVA: 0x00007511 File Offset: 0x00005711
		public static void JoinCodeKKK()
		{
			PhotonNetworkController.instance.AttemptToJoinSpecificRoom("KKK");
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00007524 File Offset: 0x00005724
		public static void JoinCode123()
		{
			PhotonNetworkController.instance.AttemptToJoinSpecificRoom("123");
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00007537 File Offset: 0x00005737
		public static void JoinCodeMod()
		{
			PhotonNetworkController.instance.AttemptToJoinSpecificRoom("MOD");
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000754A File Offset: 0x0000574A
		public static void JoinCodeMods()
		{
			PhotonNetworkController.instance.AttemptToJoinSpecificRoom("MODS");
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000755D File Offset: 0x0000575D
		public static void JoinCode1()
		{
			PhotonNetworkController.instance.AttemptToJoinSpecificRoom("1");
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00007570 File Offset: 0x00005770
		public static void JoinMenuRoom()
		{
			PhotonNetworkController.instance.AttemptToJoinSpecificRoom("<color=green>Cosmic.lol</color>");
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00007583 File Offset: 0x00005783
		public static void QuitApp()
		{
			Application.Quit();
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000758C File Offset: 0x0000578C
		public static void Disconnect()
		{
			PhotonNetwork.Disconnect();
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00007595 File Offset: 0x00005795
		public static void JoinRandomPub()
		{
			PhotonNetwork.JoinRandomRoom();
		}

		// Token: 0x060000BA RID: 186 RVA: 0x000075A0 File Offset: 0x000057A0
		public static void GripDisconnect()
		{
			bool gripButtonDown = EasyInputs.GetGripButtonDown(1);
			if (gripButtonDown)
			{
				PhotonNetwork.Disconnect();
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000075C0 File Offset: 0x000057C0
		public static void TriggerDisconnect()
		{
			bool triggerButtonDown = EasyInputs.GetTriggerButtonDown(1);
			if (triggerButtonDown)
			{
				PhotonNetwork.Disconnect();
			}
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000075E0 File Offset: 0x000057E0
		public static void Reconnect()
		{
			PhotonNetwork.Reconnect();
		}

		// Token: 0x060000BD RID: 189 RVA: 0x000075EC File Offset: 0x000057EC
		public static void NoAfkKick()
		{
			bool isInactive = PhotonNetwork.LocalPlayer.IsInactive;
			if (isInactive)
			{
				PhotonNetwork.LocalPlayer.IsInactive = false;
			}
		}
	}
}
