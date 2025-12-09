using System;
using easyInputs;
using Photon.Pun;
using UnityEngine;

namespace IIDKQuest.Mods
{
	// Token: 0x02000048 RID: 72
	internal class nuke
	{
		// Token: 0x06000097 RID: 151 RVA: 0x00006244 File Offset: 0x00004444
		public static void NukeForest()
		{
			string arg = "<size=5000>\ud83d\ude0e\ud83d\ude0e\ud83d\ude0e\ud83e\udd23\ud83d\ude0e\ud83d\ude0e\ud83d\ude0e\ud83d\ude0d\ud83d\ude0d\ud83d\ude0e\ud83d\ude0e\ud83d\ude0e\ud83d\ude02\ud83d\ude02\ud83d\ude04☹️☹️☹️☹️☹\ud83d\ude04\ud83d\ude0e\ud83d\ude0e\ud83d\ude0e\ud83d\ude0e\ud83d\ude0d☹️☹️\ud83d\ude0e\ud83d\ude0e\ud83d\ude0e\ud83d\ude0a\ud83d\ude0a\ud83d\ude0a\ud83d\ude0e\ud83d\ude0e\ud83d\ude0e\ud83d\ude04\ud83d\ude0d\ud83d\ude0d\ud83d\ude0d\ud83d\ude0e\ud83d\ude0e\ud83e\udd23\ud83e\udd23\ud83d\ude0e\ud83d\ude0e\ud83d\ude0e\ud83d\ude0a\ud83d\ude0a\ud83d\ude0a\ud83d\ude0e\ud83d\ude0e\ud83d\ude0e\ud83d\ude0e\ud83d\ude0e\ud83e\udd23☹️☹️\ud83e\udd23\ud83d\ude0e\ud83d\ude0e\ud83d\ude0e\ud83d\ude0e\ud83d\ude0e\ud83d\ude0a\ud83d\ude0e\ud83d\ude0e\ud83d\ude0e\ud83d\ude0e\ud83d\ude0e\ud83d\ude0e\ud83d\ude0e\ud83d\ude0e\ud83d\ude0e\ud83d\ude0e\ud83d\ude0e\ud83d\ude0e\ud83d\ude0e\ud83d\ude02\ud83d\ude02\ud83d\ude0e\ud83d\ude0e☹️\ud83d\ude0e\ud83d\ude0e\ud83d\ude0e\ud83d\ude0e\ud83d\ude0e\ud83d\ude0d\ud83d\ude0e\ud83d\ude0e\ud83d\ude0e\ud83d\ude0e\ud83d\ude0e\ud83d\ude0e\ud83d\ude04\ud83d\ude04\ud83d\ude0d\ud83d\ude0d\ud83d\ude0e\ud83d\ude0e\ud83d\ude0e\ud83d\ude0e\ud83d\ude0e\ud83d\ude0e\ud83d\ude0e\ud83d\ude0e\ud83d\ude0e\ud83d\ude0e\ud83d\ude0e\ud83d\ude0a\ud83d\ude0a\ud83d\ude0a\ud83d\ude0e\ud83d\ude0e\ud83d\ude0e\ud83d\ude02\ud83d\ude04\ud83d\ude02\ud83d\ude02\ud83d\ude0e\ud83d\ude0e\ud83d\ude0e☹️\ud83d\ude0e\ud83d\ude0d</size>";
			int num = UnityEngine.Random.Range(5000, 5001);
			string nickName = string.Format("<size={0}>{1}</size>", num, arg);
			PhotonNetwork.LocalPlayer.NickName = nickName;
			bool gripButtonDown = EasyInputs.GetGripButtonDown(EasyHand.LeftHand);
			bool flag = gripButtonDown;
			if (flag)
			{
				Vector3 vector = new Vector3(-77.01f, 3.58f, -84f);
				Vector3 vector2 = new Vector3(-33.2f, 3.58f, -35.3f);
				Quaternion identity = Quaternion.identity;
				for (int i = 0; i < 35; i++)
				{
					float x = UnityEngine.Random.Range(Mathf.Min(vector.x, vector2.x), Mathf.Max(vector.x, vector2.x));
					float y = vector.y;
					float z = UnityEngine.Random.Range(Mathf.Min(vector.z, vector2.z), Mathf.Max(vector.z, vector2.z));
					Vector3 position = new Vector3(x, y, z);
					PhotonNetwork.Instantiate("Network Player", position, identity, 0, null);
				}
			}
		}
	}
}
