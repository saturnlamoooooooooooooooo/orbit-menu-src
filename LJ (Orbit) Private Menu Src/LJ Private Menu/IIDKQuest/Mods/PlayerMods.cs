using System;
using easyInputs;
using UnityEngine;

namespace IIDKQuest.Mods
{
	// Token: 0x0200000F RID: 15
	internal class PlayerMods
	{
		// Token: 0x060000A9 RID: 169 RVA: 0x00006DF8 File Offset: 0x00004FF8
		public static void BoxESP()
		{
			foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
			{
				bool flag = vrrig != null && !vrrig.photonView.IsMine && !vrrig.isMyPlayer;
				if (flag)
				{
					bool flag2 = vrrig.mainSkin.material.name.Contains("fected");
					GameObject gameObject = new GameObject("box");
					gameObject = GameObject.CreatePrimitive(3);
					gameObject.transform.position = vrrig.headConstraint.transform.position;
					gameObject.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
					gameObject.transform.rotation = vrrig.transform.rotation;
					gameObject.GetComponent<Renderer>().material.shader = Utility.GUIShader();
					gameObject.GetComponent<Renderer>().material.color = (flag2 ? Color.red : Color.grey);
					Object.Destroy(gameObject, Time.deltaTime);
				}
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00006F28 File Offset: 0x00005128
		public static void SphereESP()
		{
			foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
			{
				bool flag = vrrig != null && !vrrig.photonView.IsMine && !vrrig.isMyPlayer;
				if (flag)
				{
					bool flag2 = vrrig.mainSkin.material.name.Contains("fected");
					GameObject gameObject = new GameObject("sphere");
					gameObject = GameObject.CreatePrimitive(0);
					gameObject.transform.position = vrrig.headConstraint.transform.position;
					gameObject.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
					gameObject.transform.rotation = vrrig.transform.rotation;
					gameObject.GetComponent<Renderer>().material.shader = Utility.GUIShader();
					gameObject.GetComponent<Renderer>().material.color = (flag2 ? Color.red : Color.grey);
					Object.Destroy(gameObject, Time.deltaTime);
				}
			}
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00007058 File Offset: 0x00005258
		public static void NameTagESP()
		{
			foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
			{
				bool flag = vrrig != null && !vrrig.photonView.IsMine && !vrrig.isMyPlayer;
				if (flag)
				{
					GameObject gameObject = new GameObject("NameTagESP");
					gameObject.transform.position = vrrig.headConstraint.transform.position + new Vector3(0f, 1.2f, 0f);
					gameObject.transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);
					TextMesh textMesh = gameObject.AddComponent<TextMesh>();
					textMesh.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
					textMesh.fontSize = 24;
					textMesh.color = Color.white;
					textMesh.characterSize = 0.1f;
					textMesh.anchor = 4;
					textMesh.alignment = 1;
					string text = vrrig.concatStringOfCosmeticsAllowed.Contains("FIRST LOGIN") ? "QUEST" : "PCVR";
					textMesh.text = string.Format("Name: {0}\nUserId: {1}\nMaster: {2}\nActorNumber: {3}\nPlatform: {4}", new object[]
					{
						vrrig.photonView.Owner.NickName,
						vrrig.photonView.Owner.UserId,
						vrrig.photonView.Owner.IsMasterClient,
						vrrig.photonView.Owner.ActorNumber,
						text
					});
					gameObject.transform.position = vrrig.headConstraint.transform.position + new Vector3(0f, 1f, 0f);
					gameObject.transform.LookAt(Camera.main.transform.position);
					gameObject.transform.Rotate(0f, 180f, 0f);
					Object.Destroy(gameObject, Time.deltaTime);
				}
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00007278 File Offset: 0x00005478
		public static void Tracers()
		{
			VRRig[] array = GorillaParent.instance.vrrigs.ToArray();
			foreach (VRRig vrrig in array)
			{
				for (int j = 0; j < array.Length; j++)
				{
					bool flag = array[j] != null && !array[j].isMyPlayer && !array[j].photonView.IsMine;
					if (flag)
					{
						array[j] = Utility.GetAllVRRigsWithoutMe(vrrig);
						Color color = vrrig.mainSkin.material.name.Contains("fected") ? Color.red : Color.grey;
						ValueTuple<GameObject, LineRenderer> valueTuple = Utility.CreateLine(Utility.RightHandTransform(), vrrig.headMesh.transform, color);
						GameObject item = valueTuple.Item1;
						LineRenderer item2 = valueTuple.Item2;
					}
				}
			}
		}

		// Token: 0x060000AD RID: 173 RVA: 0x0000736C File Offset: 0x0000556C
		public static void Chams(bool chams)
		{
			foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
			{
				bool flag = vrrig != null && !vrrig.photonView.IsMine && !vrrig.isMyPlayer;
				if (flag)
				{
					bool flag2 = vrrig.mainSkin.material.name.Contains("fected");
					if (chams)
					{
						vrrig.mainSkin.material.shader = Utility.GUIShader();
						vrrig.currentMatIndex = (flag2 ? 1 : 0);
					}
					else
					{
						vrrig.mainSkin.material.shader = Utility.StandardShader();
						vrrig.currentMatIndex = 0;
					}
				}
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00007438 File Offset: 0x00005638
		public static void GhostMonkey()
		{
			bool primaryButtonDown = EasyInputs.GetPrimaryButtonDown(1);
			if (primaryButtonDown)
			{
			}
			GorillaTagger.Instance.myVRRig.enabled = false;
			GorillaTagger.Instance.offlineVRRig.enabled = false;
			GorillaTagger.Instance.myVRRig.enabled = true;
			GorillaTagger.Instance.offlineVRRig.enabled = true;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00007498 File Offset: 0x00005698
		public static void InvisMonkey()
		{
			bool gripButtonDown = EasyInputs.GetGripButtonDown(1);
			if (gripButtonDown)
			{
				GorillaTagger.Instance.myVRRig.head.trackingPositionOffset = new Vector3(999f, 0f, 0f);
			}
			else
			{
				GorillaTagger.Instance.myVRRig.head.trackingPositionOffset = new Vector3(0f, -0.15f, 0f);
			}
		}
	}
}
