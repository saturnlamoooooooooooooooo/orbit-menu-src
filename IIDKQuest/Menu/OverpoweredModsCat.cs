using System;
using easyInputs;
using GorillaLocomotion;
using GorillaNetworking;
using Photon.Pun;
using UnityEngine;

namespace IIDKQuest.Mods
{
	// Token: 0x02000009 RID: 9
	internal class OverpoweredModsCat
	{
		private static object leftTrail;
		private static object rightTrail;

		// Token: 0x06000034 RID: 52 RVA: 0x00003D4C File Offset: 0x00001F4C
		public static void CrashAll()
		{
			bool gripButtonDown = EasyInputs.GetGripButtonDown(EasyHand.RightHand);
			if (gripButtonDown)
			{
				PhotonNetwork.SetMasterClient(PhotonNetwork.LocalPlayer);
				PhotonNetwork.DestroyAll();
				PhotonNetwork.DestroyAll();
				PhotonNetwork.DestroyAll();
				PhotonNetwork.DestroyAll();
				PhotonNetwork.DestroyAll();
				PhotonNetwork.DestroyAll();
				PhotonNetwork.DestroyAll();
				PhotonNetwork.DestroyAll();
				PhotonNetwork.DestroyAll();
				PhotonNetwork.DestroyAll();
				PhotonNetwork.DestroyAll();
				PhotonNetwork.DestroyAll();
				PhotonNetwork.DestroyAll();
				PhotonNetwork.DestroyAll();
				PhotonNetwork.DestroyAll();
				PhotonNetwork.DestroyAll();
				PhotonNetwork.DestroyAll();
				PhotonNetwork.DestroyAll();
				PhotonNetwork.DestroyAll();
				PhotonNetwork.DestroyAll();
				PhotonNetwork.DestroyAll();
				PhotonNetwork.DestroyAll();
				PhotonNetwork.DestroyAll();
				PhotonNetwork.DestroyAll();
				PhotonNetwork.DestroyAll();
				PhotonNetwork.DestroyAll();
				PhotonNetwork.DestroyAll();
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00003E16 File Offset: 0x00002016
		public static void DestroyAll()
		{
			PhotonNetwork.DestroyAll();
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00003E1F File Offset: 0x0000201F
		public static void SetMaster()
		{
			PhotonNetwork.SetMasterClient(PhotonNetwork.LocalPlayer);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00003E30 File Offset: 0x00002030
		public static void AlotOfPlayers()
		{
			bool isMasterClient = PhotonNetwork.IsMasterClient;
			bool flag = isMasterClient;
			bool flag2 = flag;
			if (flag2)
			{
				PhotonNetwork.CurrentRoom.MaxPlayers = 100;
			}
			else
			{
				bool flag3 = PhotonNetwork.CurrentRoom.MaxPlayers == 1;
				bool flag4 = flag3;
				bool flag5 = flag4;
				if (flag5)
				{
					PhotonNetwork.CurrentRoom.MaxPlayers = 10;
				}
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00003E88 File Offset: 0x00002088
		public static void RigSpam()
		{
			bool gripButtonDown = EasyInputs.GetGripButtonDown(EasyHand.RightHand);
			if (gripButtonDown)
			{
				PhotonNetwork.SetMasterClient(PhotonNetwork.LocalPlayer);
				UnityEngine.Object.Destroy(GorillaTagger.Instance.myVRRig);
			}
			else
			{
				bool gripButtonDown2 = EasyInputs.GetGripButtonDown(EasyHand.LeftHand);
				if (gripButtonDown2)
				{
					PhotonNetwork.DestroyPlayerObjects(PhotonNetwork.LocalPlayer);
				}
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00003ED8 File Offset: 0x000020D8
		public static void ColorChanger()
		{
			string[] array = new string[]
			{
				"1",
				"2",
				"3",
				"4",
				"5",
				"6",
				"7",
				"8",
				"9",
				"0"
			};
			int num = new System.Random().Next(array.Length);
			string[] array2 = new string[]
			{
				"1",
				"2",
				"3"
			};
			int num2 = new System.Random().Next(array.Length);
			GameObject gameObject = GameObject.Find("1");
			GameObject gameObject2 = GameObject.Find("option 1");
			gameObject.GetComponent<GorillaKeyboardButton>().characterString = array[num];
			gameObject.GetComponent<GorillaKeyboardButton>().repeatCooldown = 0f;
			gameObject2.GetComponent<GorillaKeyboardButton>().characterString = "option" + array2[num2];
			gameObject2.GetComponent<GorillaKeyboardButton>().repeatCooldown = 0f;
			gameObject.GetComponent<GorillaKeyboardButton>().testClick = true;
			gameObject.GetComponent<GorillaKeyboardButton>().repeatTestClick = true;
			gameObject2.GetComponent<GorillaKeyboardButton>().testClick = true;
			gameObject2.GetComponent<GorillaKeyboardButton>().repeatTestClick = true;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00004018 File Offset: 0x00002218
		public static void CubeGun()
		{
			bool gripButtonDown = EasyInputs.GetGripButtonDown(EasyHand.RightHand);
			if (gripButtonDown)
			{
				RaycastHit raycastHit;
				Physics.Raycast(Player.Instance.rightHandTransform.position - Player.Instance.rightHandTransform.up, -Player.Instance.rightHandTransform.up, out raycastHit);
				GameObject gameObject = GameObject.CreatePrimitive(PrimitiveType.Sphere);
				gameObject.transform.localScale = new Vector3(0.15f, 0.15f, 0.15f);
				gameObject.transform.position = raycastHit.point;
				UnityEngine.Object.Destroy(gameObject.GetComponent<Rigidbody>());
				UnityEngine.Object.Destroy(gameObject.GetComponent<Collider>());
				UnityEngine.Object.Destroy(gameObject, Time.deltaTime);
				bool triggerButtonDown = EasyInputs.GetTriggerButtonDown(EasyHand.RightHand);
				if (triggerButtonDown)
				{
					PhotonNetwork.Instantiate("bulletPrefab", gameObject.transform.position, GorillaTagger.Instance.myVRRig.rightHandTransform.rotation, 0, null);
				}
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x0000410C File Offset: 0x0000230C
		public static void TargetSpam()
		{
			bool gripButtonDown = EasyInputs.GetGripButtonDown(EasyHand.RightHand);
			if (gripButtonDown)
			{
				Vector3 position = Player.Instance.rightHandTransform.transform.position;
				Quaternion rotation = Player.Instance.rightHandTransform.transform.rotation;
				PhotonNetwork.Instantiate("STICKABLE TARGET", position, rotation, 0, null);
			}
			bool gripButtonDown2 = EasyInputs.GetGripButtonDown(EasyHand.LeftHand);
			if (gripButtonDown2)
			{
				Vector3 position2 = Player.Instance.leftHandTransform.transform.position;
				Quaternion rotation2 = Player.Instance.leftHandTransform.transform.rotation;
				PhotonNetwork.Instantiate("STICKABLE TARGET", position2, rotation2, 0, null).gameObject.GetComponent<Rigidbody>().useGravity = false;
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000041B8 File Offset: 0x000023B8
		public static void TargetGun()
		{
			bool gripButtonDown = EasyInputs.GetGripButtonDown(EasyHand.RightHand);
			if (gripButtonDown)
			{
				RaycastHit raycastHit;
				Physics.Raycast(Player.Instance.rightHandTransform.position - Player.Instance.rightHandTransform.up, -Player.Instance.rightHandTransform.up, out raycastHit);
				GameObject gameObject = GameObject.CreatePrimitive(PrimitiveType.Sphere);
				gameObject.transform.localScale = new Vector3(0.15f, 0.15f, 0.15f);
				gameObject.transform.position = raycastHit.point;
				UnityEngine.Object.Destroy(gameObject.GetComponent<Rigidbody>());
				UnityEngine.Object.Destroy(gameObject.GetComponent<Collider>());
				UnityEngine.Object.Destroy(gameObject, Time.deltaTime);
				bool triggerButtonDown = EasyInputs.GetTriggerButtonDown(EasyHand.RightHand);
				if (triggerButtonDown)
				{
					PhotonNetwork.Instantiate("STICKABLE TARGET", gameObject.transform.position, GorillaTagger.Instance.myVRRig.rightHandTransform.rotation, 0, null);
				}
			}
		}

		public static void EnableTrails(VRRig myRig)
		{
			if (myRig == null) return;

			if (leftTrail == null)
				leftTrail = CreateTrail(myRig.leftHandTransform, Color.cyan);

			if (rightTrail == null)
				rightTrail = CreateTrail(myRig.rightHandTransform, Color.magenta);
		}

		public static void DisableTrails()
		{
			if (leftTrail != null) GameObject.Destroy((UnityEngine.Object)leftTrail);
			if (rightTrail != null) GameObject.Destroy((UnityEngine.Object)rightTrail);
		}

		private static GameObject CreateTrail(Transform handTransform, Color trailColor)
		{
			GameObject trailObj = new GameObject("HandTrail");
			trailObj.transform.SetParent(handTransform);
			trailObj.transform.localPosition = Vector3.zero;

			TrailRenderer trail = trailObj.AddComponent<TrailRenderer>();
			trail.time = 0.5f; // Duration of trail
			trail.startWidth = 0.02f;
			trail.endWidth = 0.005f;
			trail.material = new Material(Shader.Find("Sprites/Default"));
			trail.startColor = trailColor;
			trail.endColor = new Color(trailColor.r, trailColor.g, trailColor.b, 0f); // fades out

			return trailObj;
		}

        internal static void EnableTrails()
        {
            throw new NotImplementedException();
        }
    }
}
