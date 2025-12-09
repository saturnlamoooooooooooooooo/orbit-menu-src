using System;
using GorillaLocomotion;
using UnityEngine;

namespace IIDKQuest.Mods
{
	// Token: 0x020000BA RID: 186
	internal class BoxingMods
	{
		// Token: 0x060003A7 RID: 935 RVA: 0x00058B44 File Offset: 0x00056D44
		public static void BetterPunchMod()
		{
			int num = -1;
			foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
			{
				bool flag = vrrig != GorillaTagger.Instance.offlineVRRig;
				bool flag2 = flag;
				if (flag2)
				{
					num++;
					Vector3 position = vrrig.rightHandTransform.position;
					Vector3 position2 = GorillaTagger.Instance.offlineVRRig.head.rigTarget.position;
					float num2 = Vector3.Distance(position, position2);
					bool flag3 = (double)num2 < 0.25;
					bool flag4 = flag3;
					if (flag4)
					{
						Player.Instance.GetComponent<Rigidbody>().velocity += Vector3.Normalize(vrrig.rightHandTransform.position - BoxingMods.lastRight[num]) * 10f;
					}
					BoxingMods.lastRight[num] = vrrig.rightHandTransform.position;
					position = vrrig.leftHandTransform.position;
					num2 = Vector3.Distance(position, position2);
					bool flag5 = (double)num2 < 0.25;
					bool flag6 = flag5;
					if (flag6)
					{
						Player.Instance.GetComponent<Rigidbody>().velocity += Vector3.Normalize(vrrig.leftHandTransform.position - BoxingMods.lastLeft[num]) * 10f;
					}
					BoxingMods.lastLeft[num] = vrrig.leftHandTransform.position;
				}
			}
		}

		// Token: 0x040000FD RID: 253
		public static Vector3[] lastLeft = new Vector3[]
		{
			Vector3.zero,
			Vector3.zero,
			Vector3.zero,
			Vector3.zero,
			Vector3.zero,
			Vector3.zero,
			Vector3.zero,
			Vector3.zero,
			Vector3.zero,
			Vector3.zero
		};

		// Token: 0x040000FE RID: 254
		public static Vector3[] lastRight = new Vector3[]
		{
			Vector3.zero,
			Vector3.zero,
			Vector3.zero,
			Vector3.zero,
			Vector3.zero,
			Vector3.zero,
			Vector3.zero,
			Vector3.zero,
			Vector3.zero,
			Vector3.zero
		};
	}
}
