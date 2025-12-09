using System;
using IIDKQuest.Menu;
using MelonLoader;
using UnityEngine;

namespace IIDKQuest.Classes
{
	// Token: 0x0200001A RID: 26
	[RegisterTypeInIl2Cpp]
	public class Button : MonoBehaviour
	{
		// Token: 0x06000114 RID: 276 RVA: 0x0000C248 File Offset: 0x0000A448
		public Button(IntPtr ptr) : base(ptr)
		{
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0000C254 File Offset: 0x0000A454
		public void OnTriggerEnter(Collider collider)
		{
			bool flag = Time.time > Button.buttonCooldown && collider == Main.buttonCollider && Main.menu != null;
			if (flag)
			{
				Button.buttonCooldown = Time.time + 0.2f;
				GorillaTagger.Instance.StartVibration(Settings.rightHanded, GorillaTagger.Instance.tagHapticStrength / 2f, GorillaTagger.Instance.tagHapticDuration / 2f);
				GorillaTagger.Instance.offlineVRRig.PlayHandTap(8, Settings.rightHanded, 0.4f);
				Main.Toggle(this.relatedText);
			}
		}

		// Token: 0x04000086 RID: 134
		public string relatedText;

		// Token: 0x04000087 RID: 135
		public static float buttonCooldown;
	}
}
