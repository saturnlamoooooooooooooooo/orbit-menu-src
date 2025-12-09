using System;
using UnityEngine;

namespace IIDKQuest.Mods
{
	// Token: 0x0200000C RID: 12
	internal class Brokenhead
	{
		// Token: 0x0600001A RID: 26 RVA: 0x000029E3 File Offset: 0x00000BE3
		public static void Sidewayshead()
		{
			GorillaTagger.Instance.myVRRig.head.trackingRotationOffset = new Vector3(0f, 0f, 90f);
		}
	}
}
