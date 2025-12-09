using System;
using easyInputs;
using GorillaLocomotion;
using GorillaNetworking;
using UnityEngine;

namespace IIDKQuest.Mods
{
	// Token: 0x0200000C RID: 12
	internal class MovementMods
	{
		// Token: 0x06000073 RID: 115 RVA: 0x00005242 File Offset: 0x00003442
		public static void SmallArms()
		{
			Player.Instance.transform.localScale = new Vector3(1.1f, 1.1f, 1.1f);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000526C File Offset: 0x0000346C
		public static void PSAFoward()
		{
			bool secondaryButtonDown = EasyInputs.GetSecondaryButtonDown(1);
			if (secondaryButtonDown)
			{
				Player.Instance.transform.position += Player.Instance.headCollider.transform.forward * Time.deltaTime * 2f;
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000052CC File Offset: 0x000034CC
		public static void WallWalk()
		{
			bool gripButtonDown = EasyInputs.GetGripButtonDown(1);
			if (gripButtonDown)
			{
				Player.Instance.GetComponent<Rigidbody>().AddForce(new Vector3(0f, 0f, -50f), 5);
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000530C File Offset: 0x0000350C
		public static void StrongWallWalk()
		{
			bool gripButtonDown = EasyInputs.GetGripButtonDown(1);
			if (gripButtonDown)
			{
				Player.Instance.GetComponent<Rigidbody>().AddForce(new Vector3(0f, 0f, -500f), 5);
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000534C File Offset: 0x0000354C
		public static void TpToStump()
		{
			bool primaryButtonDown = EasyInputs.GetPrimaryButtonDown(1);
			if (primaryButtonDown)
			{
				foreach (MeshCollider meshCollider in Resources.FindObjectsOfTypeAll<MeshCollider>())
				{
					meshCollider.enabled = false;
				}
				Player.Instance.transform.position = new Vector3(-66.4848f, 11.8871f, -82.6619f);
			}
			else
			{
				foreach (MeshCollider meshCollider2 in Resources.FindObjectsOfTypeAll<MeshCollider>())
				{
					bool enabled = meshCollider2.enabled;
					if (enabled)
					{
						break;
					}
					meshCollider2.enabled = true;
				}
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00005424 File Offset: 0x00003624
		public static void TurningMod()
		{
			bool thumbStickButtonTouched = EasyInputs.GetThumbStickButtonTouched(1);
			if (thumbStickButtonTouched)
			{
				Player.Instance.Turn(EasyInputs.GetThumbStick2DAxis(1).x * (float)GorillaComputer.instance.turnValue);
				Player.Instance.disableMovement = false;
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000546C File Offset: 0x0000366C
		public static void AFly()
		{
			bool primaryButtonDown = EasyInputs.GetPrimaryButtonDown(1);
			if (primaryButtonDown)
			{
				Transform transform = Player.Instance.transform;
				transform.position += Player.Instance.rightHandTransform.forward * 0.4f;
				Player.Instance.playerRigidBody.velocity = new Vector3(0f, 0f, 0f);
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000054E0 File Offset: 0x000036E0
		public static void TriggerFly()
		{
			bool triggerButtonDown = EasyInputs.GetTriggerButtonDown(1);
			if (triggerButtonDown)
			{
				Transform transform = Player.Instance.transform;
				transform.position += Player.Instance.rightHandTransform.forward * 0.4f;
				Player.Instance.bodyCollider.attachedRigidbody.velocity = new Vector3(0f, 0f, 0f);
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000555C File Offset: 0x0000375C
		public static void NoclipAFly()
		{
			bool primaryButtonDown = EasyInputs.GetPrimaryButtonDown(1);
			if (primaryButtonDown)
			{
				foreach (MeshCollider meshCollider in Object.FindObjectsOfType<MeshCollider>())
				{
					meshCollider.enabled = false;
				}
				Transform transform = Player.Instance.transform;
				transform.position += Player.Instance.rightHandTransform.forward * 0.4f;
				Player.Instance.bodyCollider.attachedRigidbody.velocity = new Vector3(0f, 0f, 0f);
			}
			else
			{
				foreach (MeshCollider meshCollider2 in Object.FindObjectsOfType<MeshCollider>())
				{
					meshCollider2.enabled = true;
				}
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00005664 File Offset: 0x00003864
		public static void NoclipTriggerFly()
		{
			bool triggerButtonDown = EasyInputs.GetTriggerButtonDown(1);
			if (triggerButtonDown)
			{
				foreach (MeshCollider meshCollider in Object.FindObjectsOfType<MeshCollider>())
				{
					meshCollider.enabled = false;
				}
				Transform transform = Player.Instance.transform;
				transform.position += Player.Instance.rightHandTransform.forward * 0.4f;
				Player.Instance.bodyCollider.attachedRigidbody.velocity = new Vector3(0f, 0f, 0f);
			}
			else
			{
				foreach (MeshCollider meshCollider2 in Object.FindObjectsOfType<MeshCollider>())
				{
					meshCollider2.enabled = true;
				}
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000576C File Offset: 0x0000396C
		public static void Noclip()
		{
			bool triggerButtonDown = EasyInputs.GetTriggerButtonDown(1);
			if (triggerButtonDown)
			{
				foreach (MeshCollider meshCollider in Object.FindObjectsOfType<MeshCollider>())
				{
					meshCollider.enabled = false;
				}
			}
			else
			{
				foreach (MeshCollider meshCollider2 in Object.FindObjectsOfType<MeshCollider>())
				{
					meshCollider2.enabled = true;
				}
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00005810 File Offset: 0x00003A10
		public static void BetterLongArms()
		{
			Player.Instance.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00005837 File Offset: 0x00003A37
		public static void MosaBoost()
		{
			Player.Instance.jumpMultiplier = 2.5f;
			Player.Instance.maxJumpSpeed = 7f;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000585A File Offset: 0x00003A5A
		public static void SpeedBoost()
		{
			Player.Instance.jumpMultiplier = 4f;
			Player.Instance.maxJumpSpeed = 8f;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00005880 File Offset: 0x00003A80
		public static void GripMosaBoost()
		{
			bool gripButtonDown = EasyInputs.GetGripButtonDown(1);
			if (gripButtonDown)
			{
				Player.Instance.jumpMultiplier = 3f;
				Player.Instance.maxJumpSpeed = 7f;
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000058BC File Offset: 0x00003ABC
		public static void GripSpeedBoost()
		{
			bool gripButtonDown = EasyInputs.GetGripButtonDown(1);
			if (gripButtonDown)
			{
				Player.Instance.jumpMultiplier = 4f;
			}
			Player.Instance.maxJumpSpeed = 8f;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x000058F6 File Offset: 0x00003AF6
		public static void UncapMaxVelocity()
		{
			Player.Instance.maxJumpSpeed = 1E+14f;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00005909 File Offset: 0x00003B09
		public static void BreakGravity()
		{
			Player.Instance.playerRigidBody.velocity = new Vector3(0f, 0f, 0f);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00005930 File Offset: 0x00003B30
		public static void HighGravity()
		{
			Player.Instance.playerRigidBody.velocity = new Vector3(0f, -50f, 0f);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00005957 File Offset: 0x00003B57
		public static void ReverseGravity()
		{
			Player.Instance.playerRigidBody.velocity = new Vector3(0f, 50f, 0f);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000597E File Offset: 0x00003B7E
		public static void NoGravity()
		{
			Player.Instance.playerRigidBody.useGravity = false;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00005992 File Offset: 0x00003B92
		public static void FixGravity()
		{
			Player.Instance.playerRigidBody.useGravity = true;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000059A8 File Offset: 0x00003BA8
		public static void LeftAndRight()
		{
			bool triggerButtonDown = EasyInputs.GetTriggerButtonDown(1);
			if (triggerButtonDown)
			{
				Transform transform = Player.Instance.transform;
				transform.position += Player.Instance.transform.right * 0.3f;
			}
			bool triggerButtonDown2 = EasyInputs.GetTriggerButtonDown(0);
			if (triggerButtonDown2)
			{
				Transform transform2 = Player.Instance.transform;
				transform2.position += Player.Instance.transform.right * -0.3f;
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00005A3C File Offset: 0x00003C3C
		public static void ForwardAndBackward()
		{
			bool triggerButtonDown = EasyInputs.GetTriggerButtonDown(1);
			if (triggerButtonDown)
			{
				Transform transform = Player.Instance.transform;
				transform.position += Player.Instance.transform.forward * 0.3f;
			}
			bool triggerButtonDown2 = EasyInputs.GetTriggerButtonDown(0);
			if (triggerButtonDown2)
			{
				Transform transform2 = Player.Instance.transform;
				transform2.position += Player.Instance.transform.forward * -0.3f;
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00005ACE File Offset: 0x00003CCE
		public static void FixArms()
		{
			Player.Instance.transform.localScale = new Vector3(1f, 1f, 1f);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00005AF8 File Offset: 0x00003CF8
		public static void Platform()
		{
			bool gripButtonDown = EasyInputs.GetGripButtonDown(0);
			bool gripButtonDown2 = EasyInputs.GetGripButtonDown(1);
			Color color = Color.Lerp(Color.blue, Color.cyan, Mathf.PingPong(Time.time, 1f));
			Shader shader = Shader.Find("Unlit/Color");
			bool flag = MovementMods.rightHandPlatform != null;
			if (flag)
			{
				Material material = new Material(shader);
				material.color = color;
				MovementMods.rightHandPlatform.GetComponent<Renderer>().material = material;
			}
			bool flag2 = MovementMods.leftHandPlatform != null;
			if (flag2)
			{
				Material material2 = new Material(shader);
				material2.color = color;
				MovementMods.leftHandPlatform.GetComponent<Renderer>().material = material2;
			}
			bool flag3 = MovementMods.platformCooldown == 0f && gripButtonDown2;
			if (flag3)
			{
				MovementMods.platformCooldown = 1f;
				MovementMods.rightHandPlatform = GameObject.CreatePrimitive(3);
				Material material3 = new Material(shader);
				material3.color = color;
				MovementMods.rightHandPlatform.GetComponent<Renderer>().material = material3;
				Object.Destroy(MovementMods.rightHandPlatform.GetComponent<Rigidbody>());
				MovementMods.rightHandPlatform.transform.localScale = new Vector3(0.0125f, 0.28f, 0.3825f);
				MovementMods.rightHandPlatform.transform.position = new Vector3(0f, -0.0075f, 0f) + GorillaTagger.Instance.rightHandTransform.position;
				MovementMods.rightHandPlatform.transform.rotation = GorillaTagger.Instance.rightHandTransform.rotation;
			}
			else
			{
				bool flag4 = MovementMods.platformCooldown == 1f && !gripButtonDown2;
				if (flag4)
				{
					MovementMods.platformCooldown = 0f;
					Object.DestroyImmediate(MovementMods.rightHandPlatform);
					MovementMods.rightHandPlatform = null;
				}
			}
			bool flag5 = MovementMods.platformCooldown2 == 0f && gripButtonDown;
			if (flag5)
			{
				MovementMods.platformCooldown2 = 1f;
				MovementMods.leftHandPlatform = GameObject.CreatePrimitive(3);
				Material material4 = new Material(shader);
				material4.color = color;
				MovementMods.leftHandPlatform.GetComponent<Renderer>().material = material4;
				Object.Destroy(MovementMods.leftHandPlatform.GetComponent<Rigidbody>());
				MovementMods.leftHandPlatform.transform.localScale = new Vector3(0.0125f, 0.28f, 0.3825f);
				MovementMods.leftHandPlatform.transform.position = new Vector3(0f, -0.0075f, 0f) + GorillaTagger.Instance.leftHandTransform.position;
				MovementMods.leftHandPlatform.transform.rotation = GorillaTagger.Instance.leftHandTransform.rotation;
			}
			else
			{
				bool flag6 = MovementMods.platformCooldown2 == 1f && !gripButtonDown;
				if (flag6)
				{
					MovementMods.platformCooldown2 = 0f;
					Object.DestroyImmediate(MovementMods.leftHandPlatform);
					MovementMods.leftHandPlatform = null;
				}
			}
		}

		// Token: 0x04000071 RID: 113
		public static float platformCooldown;

		// Token: 0x04000072 RID: 114
		public static float platformCooldown2;

		// Token: 0x04000073 RID: 115
		public static GameObject rightHandPlatform;

		// Token: 0x04000074 RID: 116
		public static GameObject leftHandPlatform;

		// Token: 0x04000075 RID: 117
		private static GameObject gameObject;
	}
}
