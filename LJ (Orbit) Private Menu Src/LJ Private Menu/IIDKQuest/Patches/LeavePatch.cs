using System;
using HarmonyLib;
using IIDKQuest.Notifications;
using Photon.Pun;
using Photon.Realtime;

namespace IIDKQuest.Patches
{
	// Token: 0x02000007 RID: 7
	[HarmonyPatch(typeof(MonoBehaviourPunCallbacks), "OnPlayerLeftRoom")]
	internal class LeavePatch
	{
		// Token: 0x06000059 RID: 89 RVA: 0x00004888 File Offset: 0x00002A88
		private static void Prefix(Player otherPlayer)
		{
			bool flag = otherPlayer != PhotonNetwork.LocalPlayer && otherPlayer != LeavePatch.a;
			if (flag)
			{
				NotifiLib.SendNotification("<color=grey>[</color><color=red>LEAVE</color><color=grey>]</color> <color=white>Name: " + otherPlayer.NickName + "</color>");
				LeavePatch.a = otherPlayer;
			}
		}

		// Token: 0x04000062 RID: 98
		private static Player a;
	}
}
