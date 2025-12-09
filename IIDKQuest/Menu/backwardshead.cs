using System;
using UnityEngine;

namespace IIDKQuest.Mods
{
	// Token: 0x02000007 RID: 7
	internal class backwardshead
	{
		// Token: 0x06000010 RID: 16 RVA: 0x00002811 File Offset: 0x00000A11
		public static void BackWardshead()
		{
			GorillaTagger.Instance.myVRRig.head.trackingRotationOffset = new Vector3(0f, 180f, 0f);
		}
	}
}
