using System;
using easyInputs;
using GorillaLocomotion;
using Photon.Pun;

namespace IIDKQuest.Mods
{
	// Token: 0x02000011 RID: 17
	internal class buttonspam
	{
		// Token: 0x06000024 RID: 36 RVA: 0x00002D88 File Offset: 0x00000F88
		public static void Gorillascoreboardspam()
		{
			bool gripButtonDown = EasyInputs.GetGripButtonDown(EasyHand.RightHand);
			if (gripButtonDown)
			{
				PhotonNetwork.Instantiate("gorillaprefabs/GorillaScoreBoard", Player.Instance.rightHandTransform.position, Player.Instance.rightHandTransform.rotation, 0, null);
			}
			bool gripButtonDown2 = EasyInputs.GetGripButtonDown(EasyHand.LeftHand);
			if (gripButtonDown2)
			{
				PhotonNetwork.Instantiate("gorillaprefabs/GorillaScoreBoard", Player.Instance.leftHandTransform.position, Player.Instance.leftHandTransform.rotation, 0, null);
			}
		}
	}
}
