using System;
using UnityEngine;

namespace IIDKQuest.Mods
{
	// Token: 0x0200000D RID: 13
	internal class brokenneck
	{
		// Token: 0x0600001C RID: 28 RVA: 0x00002A18 File Offset: 0x00000C18
		public static void BreakNeck()
		{
			GorillaTagger.Instance.myVRRig.head.trackingRotationOffset = new Vector3(0f, 0f, 180f);
		}
	}
}
