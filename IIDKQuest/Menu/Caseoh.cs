using System;
using UnityEngine;

namespace IIDKQuest.Mods
{
	// Token: 0x02000012 RID: 18
	internal class Caseoh
	{
		// Token: 0x06000026 RID: 38 RVA: 0x00002E10 File Offset: 0x00001010
		public static void caseohreal()
		{
			VRRig offlineVRRig = GorillaTagger.Instance.offlineVRRig;
			GameObject gameObject = GameObject.CreatePrimitive(PrimitiveType.Sphere);
			gameObject.transform.position = offlineVRRig.transform.position + offlineVRRig.transform.forward * 0.1f + Vector3.down * -1.35f;
			gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject.transform.LookAt(offlineVRRig.transform.transform);
			gameObject.GetComponent<Renderer>().material = GorillaTagger.Instance.offlineVRRig.mainSkin.material;
			gameObject.GetComponent<Renderer>().material.color = GorillaTagger.Instance.offlineVRRig.mainSkin.material.color;
			UnityEngine.Object.Destroy(gameObject, Time.deltaTime);
			UnityEngine.Object.Destroy(gameObject.GetComponent<Collider>());
		}
	}
}
