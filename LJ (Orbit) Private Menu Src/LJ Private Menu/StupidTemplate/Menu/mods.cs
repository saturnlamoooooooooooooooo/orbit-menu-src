using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using easyInputs;
using GorillaLocomotion;
using Il2CppSystem.Text.RegularExpressions;
using Photon.Pun;
using UnityEngine;
using UnityEngine.InputSystem;

namespace StupidTemplate.Menu
{
	// Token: 0x02000002 RID: 2
	internal class mods
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public static void Disconnect()
		{
			PhotonNetwork.Disconnect();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002059 File Offset: 0x00000259
		public static void placeholder()
		{
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0000205C File Offset: 0x0000025C
		public static void GunSmoothNess()
		{
			bool flag = mods.num == 10f;
			if (flag)
			{
				mods.num = 15f;
			}
			else
			{
				bool flag2 = mods.num == 15f;
				if (flag2)
				{
					mods.num = 5f;
				}
				else
				{
					mods.num = 10f;
				}
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000020AC File Offset: 0x000002AC
		public static void CycleGunColor()
		{
			int num = mods.colorCycle.IndexOf(mods.currentGunColor);
			mods.currentGunColor = mods.colorCycle[(num + 1) % mods.colorCycle.Count];
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000020E8 File Offset: 0x000002E8
		public static void GunTemplate()
		{
			bool flag = EasyInputs.GetGripButtonFloat(1) > 0.1f;
			if (flag)
			{
				RaycastHit raycastHit;
				bool flag2 = Physics.Raycast(Player.Instance.rightHandTransform.position, -Player.Instance.rightHandTransform.up, ref raycastHit);
				if (flag2)
				{
					bool isPressed = Mouse.current.rightButton.isPressed;
					if (isPressed)
					{
						Camera component = GameObject.Find("Shoulder Camera").GetComponent<Camera>();
						Ray ray = component.ScreenPointToRay(Mouse.current.position.ReadValue());
						Physics.Raycast(ray, ref raycastHit, 100f);
					}
					bool flag3 = mods.GunSphere == null;
					if (flag3)
					{
						mods.GunSphere = GameObject.CreatePrimitive(0);
						mods.GunSphere.transform.localScale = (mods.isSphereEnabled ? new Vector3(0.1f, 0.1f, 0.1f) : new Vector3(0f, 0f, 0f));
						mods.GunSphere.GetComponent<Renderer>().material.shader = Shader.Find("Standard");
						mods.GunSphere.GetComponent<Renderer>().material.color = mods.currentGunColor.Item1;
						Object.Destroy(mods.GunSphere.GetComponent<BoxCollider>());
						Object.Destroy(mods.GunSphere.GetComponent<Rigidbody>());
						Object.Destroy(mods.GunSphere.GetComponent<Collider>());
						mods.lineRenderer = mods.GunSphere.AddComponent<LineRenderer>();
						mods.lineRenderer.material = new Material(Shader.Find("Sprites/Default"));
						mods.lineRenderer.widthCurve = AnimationCurve.Linear(0f, 0.01f, 1f, 0.01f);
						mods.lineRenderer.startColor = mods.currentGunColor.Item1;
						mods.lineRenderer.endColor = mods.currentGunColor.Item1;
						mods.linePositions = new Vector3[50];
						for (int i = 0; i < mods.linePositions.Length; i++)
						{
							mods.linePositions[i] = Player.Instance.rightHandTransform.position;
						}
					}
					mods.GunSphere.transform.position = raycastHit.point;
					mods.timeCounter += Time.deltaTime;
					Vector3 position = Player.Instance.rightHandTransform.position;
					Vector3 normalized = (raycastHit.point - position).normalized;
					float num = Vector3.Distance(position, raycastHit.point);
					Vector3 vector = position - mods.previousControllerPosition;
					mods.previousControllerPosition = position;
					bool flag4 = EasyInputs.GetTriggerButtonFloat(1) > 0.1f;
					if (flag4)
					{
					}
					for (int j = 0; j < mods.linePositions.Length; j++)
					{
						float num2 = (float)j / (float)(mods.linePositions.Length - 1);
						Vector3 vector2 = Vector3.Lerp(position, raycastHit.point, num2);
						mods.linePositions[j] += vector * 0.5f;
						mods.linePositions[j] += Random.insideUnitSphere * 0.01f;
						mods.linePositions[j] = Vector3.Lerp(mods.linePositions[j], vector2, Time.deltaTime * mods.num);
					}
					mods.lineRenderer.positionCount = mods.linePositions.Length;
					mods.lineRenderer.SetPositions(mods.linePositions);
					mods.GunSphere.GetComponent<Renderer>().material.color = mods.currentGunColor.Item1;
					mods.lineRenderer.startColor = mods.currentGunColor.Item1;
					mods.lineRenderer.endColor = mods.currentGunColor.Item1;
				}
			}
			bool flag5 = mods.GunSphere != null && EasyInputs.GetGripButtonFloat(1) <= 0.1f;
			if (flag5)
			{
				Object.Destroy(mods.GunSphere);
				Object.Destroy(mods.lineRenderer);
				mods.timeCounter = 0f;
				mods.linePositions = null;
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002528 File Offset: 0x00000728
		public static string StripRichText(string input)
		{
			return Regex.Replace(input, "<.*?>", string.Empty);
		}

		// Token: 0x04000001 RID: 1
		public static GameObject GunSphere;

		// Token: 0x04000002 RID: 2
		private static LineRenderer lineRenderer;

		// Token: 0x04000003 RID: 3
		private static float timeCounter = 0f;

		// Token: 0x04000004 RID: 4
		private static Vector3[] linePositions;

		// Token: 0x04000005 RID: 5
		private static Vector3 previousControllerPosition;

		// Token: 0x04000006 RID: 6
		public static float num = 10f;

		// Token: 0x04000007 RID: 7
		[TupleElementNames(new string[]
		{
			"color",
			"name"
		})]
		public static List<ValueTuple<Color, string>> colorCycle = new List<ValueTuple<Color, string>>
		{
			new ValueTuple<Color, string>(new Color(0.7411765f, 0.9843137f, 0.8f), "mint"),
			new ValueTuple<Color, string>(new Color(1f, 0.8980392f, 0.7058824f), "peach"),
			new ValueTuple<Color, string>(new Color(0.5254902f, 0.6627451f, 0.7372549f), "dustyBlue"),
			new ValueTuple<Color, string>(new Color(0.78431374f, 0.63529414f, 0.78431374f), "lilac"),
			new ValueTuple<Color, string>(new Color(1f, 1f, 0.8f), "paleYellow"),
			new ValueTuple<Color, string>(new Color(1f, 0.7137255f, 0.75686276f), "softPink"),
			new ValueTuple<Color, string>(new Color(0.9019608f, 0.9019608f, 0.98039216f), "lavender"),
			new ValueTuple<Color, string>(new Color(0.827451f, 0.827451f, 0.827451f), "lightGray"),
			new ValueTuple<Color, string>(new Color(0.6627451f, 0.6627451f, 0.6627451f), "warmGray"),
			new ValueTuple<Color, string>(new Color(1f, 1f, 0.9411765f), "ivory"),
			new ValueTuple<Color, string>(new Color(0.9607843f, 0.9411765f, 0.7647059f), "beige"),
			new ValueTuple<Color, string>(new Color(0.5019608f, 0.5019608f, 0f), "olive"),
			new ValueTuple<Color, string>(new Color(0.8235294f, 0.7058824f, 0.54901963f), "tan"),
			new ValueTuple<Color, string>(new Color(0.52156866f, 0.6f, 0.21960784f), "mossGreen"),
			new ValueTuple<Color, string>(new Color(0.7607843f, 0.69803923f, 0.5019608f), "sand"),
			new ValueTuple<Color, string>(new Color(0.6901961f, 0.6f, 0.5019608f), "maincolor")
		};

		// Token: 0x04000008 RID: 8
		[TupleElementNames(new string[]
		{
			"color",
			"name"
		})]
		public static ValueTuple<Color, string> currentGunColor = mods.colorCycle[0];

		// Token: 0x04000009 RID: 9
		public static bool isSphereEnabled = true;
	}
}
