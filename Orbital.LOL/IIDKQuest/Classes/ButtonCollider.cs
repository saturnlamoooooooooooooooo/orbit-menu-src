using Photon.Pun;
using System;
using UnityEngine;
using static IIDKQuest.Menu.Main;
using static IIDKQuest.Settings;

namespace IIDKQuest.Classes
{

    [MelonLoader.RegisterTypeInIl2Cpp]
    public class Button : MonoBehaviour
	{
		public Button(IntPtr ptr ) : base(ptr) { }
		public string relatedText;

		public static float buttonCooldown = 0f;
		
		public void OnTriggerEnter(Collider collider)
		{
			if (Time.time > buttonCooldown && collider == buttonCollider && menu != null)
			{
                buttonCooldown = Time.time + 0.2f;
                GorillaTagger.Instance.StartVibration(rightHanded, GorillaTagger.Instance.tagHapticStrength / 2f, GorillaTagger.Instance.tagHapticDuration / 2f);
                GorillaTagger.Instance.offlineVRRig.PlayHandTap(8, rightHanded, 0.4f);
				Toggle(this.relatedText);
            }
		}
	}
}
