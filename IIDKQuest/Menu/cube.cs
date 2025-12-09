using System;
using easyInputs;
using GorillaLocomotion;
using Photon.Pun;

namespace IIDKQuest.Mods
{
	// Token: 0x02000016 RID: 22
	internal class cube
	{
		// Token: 0x0600002E RID: 46 RVA: 0x00003A70 File Offset: 0x00001C70
		public static void Pewpew()
		{
			bool gripButtonDown = EasyInputs.GetGripButtonDown(EasyHand.RightHand);
			if (gripButtonDown)
			{
				PhotonNetwork.Instantiate("bulletPrefab", Player.Instance.rightHandTransform.position, Player.Instance.rightHandTransform.rotation, 0, null);
			}
			bool gripButtonDown2 = EasyInputs.GetGripButtonDown(EasyHand.LeftHand);
			if (gripButtonDown2)
			{
				PhotonNetwork.Instantiate("bulletPrefab", Player.Instance.leftHandTransform.position, Player.Instance.leftHandTransform.rotation, 0, null);
			}
		}
	}
}
