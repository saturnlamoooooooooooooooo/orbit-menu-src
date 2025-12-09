using System;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

namespace IIDKQuest.Mods
{
	// Token: 0x02000009 RID: 9
	internal class AdvantageMods
	{
		// Token: 0x06000063 RID: 99 RVA: 0x00004F28 File Offset: 0x00003128
		public static void LowHZ()
		{
			foreach (MeshCollider meshCollider in Resources.FindObjectsOfTypeAll<MeshCollider>())
			{
				meshCollider.enabled = true;
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00004F7C File Offset: 0x0000317C
		public static void HeadSpinX()
		{
			GorillaTagger.Instance.myVRRig.head.trackingRotationOffset = GorillaTagger.Instance.myVRRig.head.trackingRotationOffset + new Vector3(15f, 0f, 0f);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00004FCC File Offset: 0x000031CC
		public static void HeadSpinY()
		{
			GorillaTagger.Instance.myVRRig.head.trackingRotationOffset = GorillaTagger.Instance.myVRRig.head.trackingRotationOffset + new Vector3(0f, 15f, 0f);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0000501C File Offset: 0x0000321C
		public static void TagSelf()
		{
			PhotonNetwork.SetMasterClient(PhotonNetwork.LocalPlayer);
			foreach (GorillaTagManager gorillaTagManager in Object.FindObjectsOfType<GorillaTagManager>())
			{
				gorillaTagManager.AddInfectedPlayer(PhotonNetwork.LocalPlayer);
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00005080 File Offset: 0x00003280
		public static void UnTagSelf()
		{
			foreach (GorillaTagManager gorillaTagManager in Object.FindObjectsOfType<GorillaTagManager>())
			{
				Player localPlayer = PhotonNetwork.LocalPlayer;
				bool flag = gorillaTagManager.currentInfected != null && gorillaTagManager.currentInfected.Contains(localPlayer);
				if (flag)
				{
					gorillaTagManager.currentInfected.Remove(localPlayer);
					gorillaTagManager.UpdateState();
				}
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00005104 File Offset: 0x00003304
		public static void BackwardsHead()
		{
			GorillaTagger.Instance.myVRRig.head.trackingRotationOffset = new Vector3(0f, 180f, 0f);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00005130 File Offset: 0x00003330
		public static void UpsideDownHead()
		{
			GorillaTagger.Instance.myVRRig.head.trackingRotationOffset = new Vector3(180f, 0f, 0f);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000515C File Offset: 0x0000335C
		public static void BreakHead1()
		{
			GorillaTagger.Instance.myVRRig.head.trackingRotationOffset = new Vector3(90f, 0f, 0f);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00005188 File Offset: 0x00003388
		public static void BreakHead2()
		{
			GorillaTagger.Instance.myVRRig.head.trackingRotationOffset = new Vector3(0f, 90f, 0f);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000051B4 File Offset: 0x000033B4
		public static void BreakHead3()
		{
			GorillaTagger.Instance.myVRRig.head.trackingRotationOffset = new Vector3(0f, 0f, 90f);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000051E0 File Offset: 0x000033E0
		public static void FixHead()
		{
			GorillaTagger.Instance.myVRRig.head.trackingRotationOffset = new Vector3(0f, 0f, 0f);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000520C File Offset: 0x0000340C
		public static void TagAura()
		{
			GorillaTagger.Instance.sphereCastRadius = 10f;
		}
	}
}
