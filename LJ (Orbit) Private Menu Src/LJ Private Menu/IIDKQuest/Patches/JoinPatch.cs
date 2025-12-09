using System;
using HarmonyLib;
using IIDKQuest.Notifications;
using Photon.Pun;
using Photon.Realtime;

namespace IIDKQuest.Patches
{
	// Token: 0x02000006 RID: 6
	[HarmonyPatch(typeof(MonoBehaviourPunCallbacks), "OnPlayerEnteredRoom")]
	internal class JoinPatch
	{
		// Token: 0x06000057 RID: 87 RVA: 0x0000483C File Offset: 0x00002A3C
		private static void Prefix(Player newPlayer)
		{
			bool flag = newPlayer != JoinPatch.oldnewplayer;
			if (flag)
			{
				NotifiLib.SendNotification("<color=grey>[</color><color=green>JOIN</color><color=grey>] </color><color=white>Name: " + newPlayer.NickName + "</color>");
				JoinPatch.oldnewplayer = newPlayer;
			}
		}

		// Token: 0x04000061 RID: 97
		private static Player oldnewplayer;
	}
}
