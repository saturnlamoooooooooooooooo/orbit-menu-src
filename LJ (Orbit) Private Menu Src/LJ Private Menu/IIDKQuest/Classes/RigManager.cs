using System;
using HarmonyLib;
using MelonLoader;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

namespace IIDKQuest.Classes
{
	// Token: 0x0200001E RID: 30
	[RegisterTypeInIl2Cpp]
	public class RigManager : MonoBehaviour
	{
		// Token: 0x0600011B RID: 283 RVA: 0x0000C4F1 File Offset: 0x0000A6F1
		public RigManager(IntPtr ptr) : base(ptr)
		{
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0000C4FC File Offset: 0x0000A6FC
		public static VRRig GetVRRigFromPlayer(Player p)
		{
			VRRig result = null;
			foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
			{
				bool flag = vrrig.photonView.Owner == p;
				if (flag)
				{
					result = vrrig;
					break;
				}
			}
			return result;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0000C550 File Offset: 0x0000A750
		public static VRRig GetRandomVRRig(bool includeSelf)
		{
			VRRig vrrig = GorillaParent.instance.vrrigs.ToArray()[Random.Range(0, GorillaParent.instance.vrrigs.Count - 1)];
			VRRig result;
			if (includeSelf)
			{
				result = vrrig;
			}
			else
			{
				bool flag = vrrig != GorillaTagger.Instance.offlineVRRig;
				if (flag)
				{
					result = vrrig;
				}
				else
				{
					result = RigManager.GetRandomVRRig(includeSelf);
				}
			}
			return result;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0000C5BC File Offset: 0x0000A7BC
		public static VRRig GetClosestVRRig()
		{
			float num = float.MaxValue;
			VRRig result = null;
			foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
			{
				bool flag = Vector3.Distance(GorillaTagger.Instance.bodyCollider.transform.position, vrrig.transform.position) < num;
				if (flag)
				{
					num = Vector3.Distance(GorillaTagger.Instance.bodyCollider.transform.position, vrrig.transform.position);
					result = vrrig;
				}
			}
			return result;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x0000C654 File Offset: 0x0000A854
		public static PhotonView GetPhotonViewFromVRRig(VRRig p)
		{
			return (PhotonView)Traverse.Create(p).Field("photonView").GetValue();
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0000C680 File Offset: 0x0000A880
		public static Player GetRandomPlayer(bool includeSelf)
		{
			Player result;
			if (includeSelf)
			{
				result = PhotonNetwork.PlayerList[Random.Range(0, PhotonNetwork.PlayerList.Length - 1)];
			}
			else
			{
				result = PhotonNetwork.PlayerListOthers[Random.Range(0, PhotonNetwork.PlayerListOthers.Length - 1)];
			}
			return result;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0000C6D4 File Offset: 0x0000A8D4
		public static Player GetPlayerFromVRRig(VRRig p)
		{
			return RigManager.GetPhotonViewFromVRRig(p).Owner;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x0000C6F4 File Offset: 0x0000A8F4
		public static Player GetPlayerFromID(string id)
		{
			Player result = null;
			foreach (Player player in PhotonNetwork.PlayerList)
			{
				bool flag = player.UserId == id;
				if (flag)
				{
					result = player;
					break;
				}
			}
			return result;
		}
	}
}
