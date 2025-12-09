using System;
using easyInputs;
using Photon.Pun;
using UnityEngine;

namespace IIDKQuest.Mods
{
	// Token: 0x02000013 RID: 19
	internal class SMHMods
	{
		// Token: 0x060000DD RID: 221 RVA: 0x000078DC File Offset: 0x00005ADC
		public static void TimmySpam()
		{
			bool rtrigger = Utility.RTrigger;
			if (rtrigger)
			{
				Utility.BetaSpawnPrefab("horror/timmy", Utility.RightHandTransform().position, Utility.RightHandTransform().rotation);
			}
			bool ltrigger = Utility.LTrigger;
			if (ltrigger)
			{
				Utility.BetaSpawnPrefab("horror/timmy", Utility.LeftHandTransform().position, Utility.LeftHandTransform().rotation);
			}
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0000793C File Offset: 0x00005B3C
		public static void StalkerSpam()
		{
			bool rtrigger = Utility.RTrigger;
			if (rtrigger)
			{
				Utility.BetaSpawnPrefab("horror/stalker", Utility.RightHandTransform().position, Utility.RightHandTransform().rotation);
			}
			bool ltrigger = Utility.LTrigger;
			if (ltrigger)
			{
				Utility.BetaSpawnPrefab("horror/stalker", Utility.LeftHandTransform().position, Utility.LeftHandTransform().rotation);
			}
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0000799C File Offset: 0x00005B9C
		public static void TimmyAll()
		{
			foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
			{
				bool flag = vrrig != null && !vrrig.photonView.IsMine && !vrrig.isMyPlayer;
				if (flag)
				{
					bool rtrigger = Utility.RTrigger;
					if (rtrigger)
					{
						Utility.BetaSpawnPrefab("horror/timmy", vrrig.headConstraint.transform.position, vrrig.headConstraint.transform.rotation);
					}
				}
			}
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00007A2C File Offset: 0x00005C2C
		public static void StalkerAll()
		{
			foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
			{
				bool flag = vrrig != null && !vrrig.photonView.IsMine && !vrrig.isMyPlayer;
				if (flag)
				{
					bool rtrigger = Utility.RTrigger;
					if (rtrigger)
					{
						Utility.BetaSpawnPrefab("horror/stalker", vrrig.headConstraint.transform.position, vrrig.headConstraint.transform.rotation);
					}
				}
			}
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00007ABC File Offset: 0x00005CBC
		public static void TimmyGun()
		{
			bool rgrip = Utility.RGrip;
			if (rgrip)
			{
				RaycastHit raycastHit;
				Physics.Raycast(Utility.RightHandTransform().position - Utility.RightHandTransform().up, -Utility.RightHandTransform().up + Utility.RightHandTransform().forward, ref raycastHit);
				GameObject gameObject = GameObject.CreatePrimitive(0);
				gameObject.transform.localScale = new Vector3(0.15f, 0.15f, 0.15f);
				gameObject.GetComponent<Renderer>().material.color = Color.white;
				gameObject.transform.position = raycastHit.point;
				Object.Destroy(gameObject.GetComponent<BoxCollider>());
				Object.Destroy(gameObject.GetComponent<Rigidbody>());
				Object.Destroy(gameObject.GetComponent<Collider>());
				Object.Destroy(gameObject, Time.deltaTime);
				gameObject.GetComponent<Collider>().enabled = false;
				bool rtrigger = Utility.RTrigger;
				if (rtrigger)
				{
					gameObject.GetComponent<Renderer>().material.color = Color.red;
					Utility.BetaSpawnPrefab("horror/timmy", gameObject.transform.position, gameObject.transform.rotation);
				}
			}
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00007BE8 File Offset: 0x00005DE8
		public static void MoveTimmy()
		{
			PhotonNetwork.SetMasterClient(PhotonNetwork.LocalPlayer);
			bool rgrip = Utility.RGrip;
			if (rgrip)
			{
				RaycastHit raycastHit;
				Physics.Raycast(Utility.RightHandTransform().position - Utility.RightHandTransform().up, -Utility.RightHandTransform().up + Utility.RightHandTransform().forward, ref raycastHit);
				GameObject gameObject = GameObject.CreatePrimitive(0);
				gameObject.transform.localScale = new Vector3(0.15f, 0.15f, 0.15f);
				gameObject.GetComponent<Renderer>().material.color = Color.white;
				gameObject.transform.position = raycastHit.point;
				Object.Destroy(gameObject.GetComponent<BoxCollider>());
				Object.Destroy(gameObject.GetComponent<Rigidbody>());
				Object.Destroy(gameObject.GetComponent<Collider>());
				Object.Destroy(gameObject, Time.deltaTime);
				gameObject.GetComponent<Collider>().enabled = false;
				bool rtrigger = Utility.RTrigger;
				if (rtrigger)
				{
					gameObject.GetComponent<Renderer>().material.color = Color.red;
					Utility.SetMaster(PhotonNetwork.LocalPlayer);
					foreach (GameObject gameObject2 in Object.FindObjectsOfType<GameObject>())
					{
						bool flag = gameObject2.name.ToLower().Contains("timmy");
						if (flag)
						{
							gameObject2.transform.position = gameObject.transform.position;
						}
					}
				}
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00007D84 File Offset: 0x00005F84
		public static void TimmyAllRigs()
		{
			bool rtrigger = Utility.RTrigger;
			if (rtrigger)
			{
				Utility.SetMaster(PhotonNetwork.LocalPlayer);
				foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
				{
					bool flag = vrrig != null && !vrrig.photonView.IsMine && !vrrig.isMyPlayer;
					if (flag)
					{
						bool rtrigger2 = Utility.RTrigger;
						if (rtrigger2)
						{
							foreach (GameObject gameObject in Object.FindObjectsOfType<GameObject>())
							{
								bool flag2 = gameObject.name.ToLower().Contains("timmy");
								if (flag2)
								{
									bool rtrigger3 = Utility.RTrigger;
									if (rtrigger3)
									{
										gameObject.transform.position = vrrig.headConstraint.transform.position;
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00007E98 File Offset: 0x00006098
		public static void SpazTimmy()
		{
			bool rtrigger = Utility.RTrigger;
			if (rtrigger)
			{
				Utility.SetMaster(PhotonNetwork.LocalPlayer);
				foreach (GameObject gameObject in Object.FindObjectsOfType<GameObject>())
				{
					bool flag = gameObject.name.ToLower().Contains("timmy");
					if (flag)
					{
						bool rtrigger2 = Utility.RTrigger;
						if (rtrigger2)
						{
							gameObject.transform.localRotation = Quaternion.Euler((float)Random.Range(0, 100), (float)Random.Range(0, 100), (float)Random.Range(0, 100));
						}
					}
				}
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00007F50 File Offset: 0x00006150
		public static void FlingTimmy()
		{
			bool rtrigger = Utility.RTrigger;
			if (rtrigger)
			{
				Utility.SetMaster(PhotonNetwork.LocalPlayer);
				foreach (GameObject gameObject in Object.FindObjectsOfType<GameObject>())
				{
					bool flag = gameObject.name.ToLower().Contains("timmy");
					if (flag)
					{
						bool rtrigger2 = Utility.RTrigger;
						if (rtrigger2)
						{
							gameObject.transform.position = new Vector3(0f, 150f, 0f);
						}
					}
				}
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00007FFC File Offset: 0x000061FC
		public static void KillGun()
		{
			bool rgrip = Utility.RGrip;
			if (rgrip)
			{
				RaycastHit raycastHit;
				Physics.Raycast(Utility.RightHandTransform().position - Utility.RightHandTransform().up, -Utility.RightHandTransform().up + Utility.RightHandTransform().forward, ref raycastHit);
				GameObject gameObject = GameObject.CreatePrimitive(0);
				gameObject.transform.localScale = new Vector3(0.15f, 0.15f, 0.15f);
				gameObject.GetComponent<Renderer>().material.color = Color.white;
				gameObject.transform.position = raycastHit.point;
				Object.Destroy(gameObject.GetComponent<BoxCollider>());
				Object.Destroy(gameObject.GetComponent<Rigidbody>());
				Object.Destroy(gameObject.GetComponent<Collider>());
				Object.Destroy(gameObject, Time.deltaTime);
				gameObject.GetComponent<Collider>().enabled = false;
				bool rtrigger = Utility.RTrigger;
				if (rtrigger)
				{
					gameObject.GetComponent<Renderer>().material.color = Color.red;
					VRRig componentInParent = raycastHit.collider.GetComponentInParent<VRRig>();
					bool flag = componentInParent != null;
					if (flag)
					{
						GameObject gameObject2 = PhotonNetwork.Instantiate("horror/stalker", componentInParent.headConstraint.transform.position, componentInParent.headConstraint.transform.rotation, 0, null);
						bool enabled = gameObject2.GetComponent<Renderer>().enabled;
						if (enabled)
						{
							gameObject2.GetComponent<Renderer>().enabled = false;
						}
					}
				}
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00008178 File Offset: 0x00006378
		public static void KillAll()
		{
			foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
			{
				bool flag = vrrig != null && !vrrig.photonView.IsMine && !vrrig.isMyPlayer;
				if (flag)
				{
					bool rtrigger = Utility.RTrigger;
					if (rtrigger)
					{
						Utility.BetaSpawnPrefab("horror/stalker", vrrig.headConstraint.transform.position, vrrig.headConstraint.transform.rotation);
						Utility.BetaSpawnPrefab("horror/stalker", vrrig.transform.position, vrrig.headConstraint.transform.rotation);
						Utility.BetaSpawnPrefab("horror/stalker", vrrig.rightHandTransform.transform.position, vrrig.headConstraint.transform.rotation);
					}
				}
			}
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00008264 File Offset: 0x00006464
		public static void StalkerGun()
		{
			bool rgrip = Utility.RGrip;
			if (rgrip)
			{
				RaycastHit raycastHit;
				Physics.Raycast(Utility.RightHandTransform().position - Utility.RightHandTransform().up, -Utility.RightHandTransform().up + Utility.RightHandTransform().forward, ref raycastHit);
				GameObject gameObject = GameObject.CreatePrimitive(0);
				gameObject.transform.localScale = new Vector3(0.15f, 0.15f, 0.15f);
				gameObject.GetComponent<Renderer>().material.color = Color.white;
				gameObject.transform.position = raycastHit.point;
				Object.Destroy(gameObject.GetComponent<BoxCollider>());
				Object.Destroy(gameObject.GetComponent<Rigidbody>());
				Object.Destroy(gameObject.GetComponent<Collider>());
				Object.Destroy(gameObject, Time.deltaTime);
				gameObject.GetComponent<Collider>().enabled = false;
				bool rtrigger = Utility.RTrigger;
				if (rtrigger)
				{
					gameObject.GetComponent<Renderer>().material.color = Color.red;
					Utility.BetaSpawnPrefab("horror/stalker", gameObject.transform.position, gameObject.transform.rotation);
				}
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00008390 File Offset: 0x00006590
		public static void TimmyAndStalkerSpam()
		{
			bool triggerButtonDown = EasyInputs.GetTriggerButtonDown(1);
			if (triggerButtonDown)
			{
				PhotonNetwork.Instantiate("horror/timmy", GorillaTagger.Instance.rightHandTransform.position, GorillaTagger.Instance.rightHandTransform.rotation, 0, null);
			}
			bool gripButtonDown = EasyInputs.GetGripButtonDown(0);
			if (gripButtonDown)
			{
				PhotonNetwork.Instantiate("horror/stalker", GorillaTagger.Instance.leftHandTransform.position, GorillaTagger.Instance.leftHandTransform.rotation, 0, null);
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0000840C File Offset: 0x0000660C
		public static void FullBright()
		{
			RenderSettings.fog = false;
			RenderSettings.ambientLight = Color.white;
		}
	}
}
