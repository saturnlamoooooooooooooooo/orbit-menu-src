using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using easyInputs;
using ExitGames.Client.Photon;
using GorillaLocomotion;
using GorillaNetworking;
using IIDKQuest.Classes;
using IIDKQuest.Menu;
using Il2CppSystem.Net;
using MelonLoader;
using Photon.Pun;
using Photon.Realtime;
using PlayFab;
using UnityEngine;
using UnityEngine.UI;

namespace IIDKQuest
{
	// Token: 0x02000005 RID: 5
	public class Utility
	{
		// Token: 0x0600000C RID: 12 RVA: 0x000028BC File Offset: 0x00000ABC
		public static void Log(string msg, int type)
		{
			switch (type)
			{
			case 0:
				File.WriteAllText(Utility.LogPath, Utility.LogMain + msg);
				break;
			case 1:
				File.WriteAllText(Utility.LogPath, Utility.LogWarningMain + msg);
				break;
			case 2:
				File.WriteAllText(Utility.LogPath, Utility.LogSuccessMain + msg);
				break;
			case 3:
				File.WriteAllText(Utility.LogPath, Utility.LogErrorMain + msg);
				break;
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002948 File Offset: 0x00000B48
		public static PhotonView GetOwnerShip(Player newOwner)
		{
			foreach (GameObject gameObject in Object.FindObjectsOfType<GameObject>())
			{
				PhotonView component = gameObject.GetComponent<PhotonView>();
				bool flag = component != null;
				if (flag)
				{
					component.Owner = newOwner;
					component.Controller = newOwner;
					return component;
				}
			}
			return null;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000029C4 File Offset: 0x00000BC4
		public static void DestroyAllPhotonViews()
		{
			foreach (GameObject gameObject in Object.FindObjectsOfType<GameObject>())
			{
				Utility.SetMaster(Utility.MyPlayer());
				PhotonView component = gameObject.GetComponent<PhotonView>();
				bool flag = component != null;
				if (flag)
				{
					PhotonNetwork.Destroy(component);
				}
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002A34 File Offset: 0x00000C34
		public static Player MyPlayer()
		{
			return PhotonNetwork.LocalPlayer;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002A4B File Offset: 0x00000C4B
		private static IEnumerator BetaBanAllWithDelay()
		{
			return new Utility.<BetaBanAllWithDelay>d__5(0);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002A54 File Offset: 0x00000C54
		public static void BetaBanAll(string userid)
		{
			string titleId = PlayFabSettings.staticSettings.TitleId;
			string text = "Modding";
			string text2 = "Cheating";
			string text3 = "https://api-colossal-quest.vercel.app/api/runcloudscript";
			WebClient webClient = new WebClient();
			try
			{
				webClient.Headers.Add("Content-Type", "application/json");
				string text4 = string.Concat(new string[]
				{
					"{\"playerId\":\"",
					userid,
					"\", \"titleId\":\"",
					titleId,
					"\", \"msg\":\"",
					text,
					"\", \"rsn\":\"",
					text2,
					"\"}"
				});
				string str = webClient.UploadString(text3, "POST", text4);
				MelonLogger.Msg("Cloud Script Response: " + str);
			}
			catch (Exception ex)
			{
				MelonLogger.Error("Error sending Cloud Script: " + ex.Message);
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002B3C File Offset: 0x00000D3C
		public static string FindVRRigFromPlayerId(VRRig who)
		{
			bool inRoom = PhotonNetwork.InRoom;
			if (inRoom)
			{
				foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
				{
					bool flag = vrrig != null && !vrrig.photonView.IsMine && !vrrig.isMyPlayer;
					if (flag)
					{
						return vrrig.photonView.Owner.UserId;
					}
				}
			}
			return null;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002BBC File Offset: 0x00000DBC
		public static void BetaSpamMuteAll()
		{
			for (int i = 0; i < 9; i++)
			{
				Utility.lastfreezegarbadge = !Utility.lastfreezegarbadge;
				foreach (GorillaPlayerScoreboardLine gorillaPlayerScoreboardLine in Object.FindObjectsOfType<GorillaPlayerScoreboardLine>())
				{
					gorillaPlayerScoreboardLine.SetReportState(true, 3);
					gorillaPlayerScoreboardLine.muteButton.testPress = Utility.lastfreezegarbadge;
				}
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002C40 File Offset: 0x00000E40
		public static void BetaCrashAllV2(VRRig target)
		{
			Utility.SetMaster(PhotonNetwork.LocalPlayer);
			bool flag = target != null;
			if (flag)
			{
				PhotonNetwork.Destroy(target.photonView);
				PhotonNetwork.DestroyPlayerObjects(target.photonView.Owner);
				PhotonNetwork.DestroyPlayerObjects(target.photonView.Controller);
				PhotonNetwork.SendDestroyOfPlayer(target.photonView.Owner.ActorNumber);
				PhotonNetwork.SendDestroyOfPlayer(target.photonView.Controller.ActorNumber);
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002CC0 File Offset: 0x00000EC0
		public static void PacketStresser()
		{
			for (int i = 0; i < 9; i++)
			{
				Utility.lastfreezegarbadge = !Utility.lastfreezegarbadge;
				foreach (GorillaPlayerScoreboardLine gorillaPlayerScoreboardLine in Object.FindObjectsOfType<GorillaPlayerScoreboardLine>())
				{
					gorillaPlayerScoreboardLine.muteButton.testPress = Utility.lastfreezegarbadge;
					gorillaPlayerScoreboardLine.SetReportState(Utility.lastfreezegarbadge, 3);
				}
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002D48 File Offset: 0x00000F48
		public static string Generate(int length)
		{
			char[] array = new char[length];
			for (int i = 0; i < length; i++)
			{
				array[i] = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"[Utility._random.Next("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789".Length)];
			}
			return new string(array);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002D9C File Offset: 0x00000F9C
		public static GorillaTagManager BetaDoSmthWithTag(int wat, Player whoToTag = null)
		{
			GorillaTagManager component = GorillaGameManager.instance.GetComponent<GorillaTagManager>();
			switch (wat)
			{
			case 0:
				component.InfectionEnd();
				break;
			case 1:
				component.UpdateInfectionState();
				break;
			case 2:
				component.UpdateTagState();
				break;
			case 3:
				component.SetisCurrentlyTag(true);
				break;
			case 4:
				component.ChangeCurrentIt(whoToTag);
				break;
			}
			return component;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002E0C File Offset: 0x0000100C
		public static void FixGhostRig()
		{
			bool flag = !Utility.myVRRig().enabled;
			if (flag)
			{
				Utility.myVRRig().enabled = true;
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002E38 File Offset: 0x00001038
		public static void FreezePlayerInMenu()
		{
			bool flag = Main.menu != null;
			if (flag)
			{
				bool flag2 = Utility.closePosition == Vector3.zero;
				if (flag2)
				{
					Utility.closePosition = GorillaTagger.Instance.GetComponent<Rigidbody>().transform.position;
				}
				else
				{
					GorillaTagger.Instance.GetComponent<Rigidbody>().transform.position = Utility.closePosition;
				}
				GorillaTagger.Instance.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
			}
			else
			{
				Utility.closePosition = Vector3.zero;
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002ED0 File Offset: 0x000010D0
		public static void GhostInMenu()
		{
			bool flag = Main.menu != null;
			if (flag)
			{
				Utility.myVRRig().enabled = false;
			}
			else
			{
				Utility.myVRRig().enabled = true;
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002F08 File Offset: 0x00001108
		public static void ChangePageType()
		{
			Utility.PageType = (Utility.PageType + 1) % Utility.PageTypes.Length;
			switch (Utility.PageType)
			{
			case 0:
				Utility.isTriggers = false;
				Utility.PageObjectPosRight = new Vector3(0.56f, 0.65f, 0f);
				Utility.PageObjectPosLeft = new Vector3(0.56f, -0.65f, 0f);
				Utility.PageObjScale = new Vector3(0.09f, 0.2f, 0.9f);
				Utility.PageTextPosLeft = new Vector3(0.064f, 0.195f, 0f);
				Utility.PageTextPosRight = new Vector3(0.064f, -0.195f, 0f);
				break;
			case 1:
				Utility.isTriggers = false;
				Utility.PageObjectPosRight = new Vector3(0.56f, -0.44f, -0.6f);
				Utility.PageObjectPosLeft = new Vector3(0.56f, 0.44f, -0.6f);
				Utility.PageTextPosLeft = new Vector3(0.062f, 0.132f, -0.23f);
				Utility.PageTextPosRight = new Vector3(0.062f, -0.13f, -0.23f);
				Utility.PageObjScale = new Vector3(0.1f, 0.2f, 0.1f);
				break;
			case 2:
				Utility.isTriggers = true;
				Utility.PageObjectPosRight = new Vector3(0f, --0f, --0f);
				Utility.PageObjectPosLeft = new Vector3(0f, 0f, --0f);
				Utility.PageObjScale = new Vector3(0f, 0f, 0f);
				Utility.PageTextPosLeft = new Vector3(222222f, -22222222f, -222222220f);
				Utility.PageTextPosRight = new Vector3(222222f, -22222222f, -222222220f);
				break;
			}
			Main.GetIndex("Change Page Type").overlapText = "Change Page Type <color=red>[" + Utility.PageTypes[Utility.PageType] + "]</color>";
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00003107 File Offset: 0x00001307
		public static void BetaEmojiName(int emoji)
		{
			PhotonNetwork.LocalPlayer.NickName = "\n\n<size=4532><sprite=" + emoji.ToString() + "></size>";
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000312B File Offset: 0x0000132B
		public static void BetaSpawnPrefab(string prefabName, Vector3 Position, Quaternion Roation)
		{
			PhotonNetwork.Instantiate(prefabName, Position, Roation, 0, null);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00003139 File Offset: 0x00001339
		public static void SetMaster(Player newMaster)
		{
			PhotonNetwork.SetMasterClient(newMaster);
			GorillaNot.instance.currentMasterClient = newMaster;
			GorillaNot.instance.OnMasterClientSwitched(newMaster);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000315C File Offset: 0x0000135C
		public static void MakeMeMaster()
		{
			bool flag = !Utility.IsMaster();
			if (flag)
			{
				Utility.SetMaster(Utility.MyPlayer());
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003184 File Offset: 0x00001384
		public static void GhostView(bool enabled)
		{
			if (enabled)
			{
				bool flag = Utility.sphereeL == null;
				if (flag)
				{
					Utility.sphereeL = GameObject.CreatePrimitive(0);
					Utility.sphereeL.GetComponent<Renderer>().material.shader = Shader.Find("GUI/Text Shader");
					Utility.sphereeL.transform.SetParent(Utility.LeftHandTransform(), false);
					Utility.sphereeL.transform.localRotation = Quaternion.identity;
					Utility.sphereeL.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
					Utility.sphereeL.GetComponent<Renderer>().material.color = Color.grey;
					Object.Destroy(Utility.sphereeL.GetComponent<Collider>());
				}
				bool flag2 = Utility.sphereeR == null;
				if (flag2)
				{
					Utility.sphereeR = GameObject.CreatePrimitive(0);
					Utility.sphereeR.GetComponent<Renderer>().material.shader = Shader.Find("GUI/Text Shader");
					Utility.sphereeR.transform.SetParent(Utility.RightHandTransform(), false);
					Utility.sphereeR.transform.localRotation = Quaternion.identity;
					Utility.sphereeR.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
					Utility.sphereeR.GetComponent<Renderer>().material.color = Color.grey;
					Object.Destroy(Utility.sphereeR.GetComponent<Collider>());
				}
			}
			else
			{
				bool flag3 = Utility.sphereeL != null;
				if (flag3)
				{
					Object.Destroy(Utility.sphereeL);
					Utility.sphereeL = null;
				}
				bool flag4 = Utility.sphereeR != null;
				if (flag4)
				{
					Object.Destroy(Utility.sphereeR);
					Utility.sphereeR = null;
				}
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00003354 File Offset: 0x00001554
		public static bool IsMaster()
		{
			return PhotonNetwork.IsMasterClient;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x0000336C File Offset: 0x0000156C
		public static void BetaDestroyPlayers(Player who)
		{
			bool flag = !Utility.IsMaster();
			if (flag)
			{
				Utility.SetMaster(PhotonNetwork.LocalPlayer);
			}
			PhotonNetwork.DestroyPlayerObjects(who);
			PhotonNetwork.DestroyPlayerObjects(who);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000033A0 File Offset: 0x000015A0
		public static void BetaDoPrefab(string prefabName)
		{
			GameObject item = PhotonNetwork.Instantiate(prefabName, Vector3.zero, Quaternion.identity, 0, null);
			Utility.Prefabs.Add(item);
			foreach (GameObject gameObject in Utility.Prefabs)
			{
				bool flag = gameObject != null;
				if (flag)
				{
					Object.Destroy(gameObject);
				}
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00003424 File Offset: 0x00001624
		public static void SlowPlayer(Player who)
		{
			Utility.myVRRig().photonView.RPC("SetTaggedTime", who, null);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003440 File Offset: 0x00001640
		public static void TagPlayer(Player who)
		{
			foreach (GorillaTagManager gorillaTagManager in Object.FindObjectsOfType<GorillaTagManager>())
			{
				Utility.MakeMeMaster();
				gorillaTagManager.AddInfectedPlayer(who);
				gorillaTagManager.AddInfectedPlayer(who);
				gorillaTagManager.AddInfectedPlayer(who);
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000034A8 File Offset: 0x000016A8
		public static void BetaCrashPlayer(Player crash)
		{
			Utility.myVRRig().photonView.RPC(Utility.RPCNames[0], crash, null);
			Utility.myVRRig().photonView.RPC(Utility.RPCNames[0], crash, null);
			Utility.myVRRig().photonView.RPC(Utility.RPCNames[1], crash, null);
			Utility.myVRRig().photonView.RPC(Utility.RPCNames[1], crash, null);
			Utility.myVRRig().photonView.RPC(Utility.RPCNames[2], crash, null);
			Utility.myVRRig().photonView.RPC(Utility.RPCNames[2], crash, null);
			Utility.myVRRig().photonView.RPC(Utility.RPCNames[3], crash, null);
			Utility.myVRRig().photonView.RPC(Utility.RPCNames[3], crash, null);
			Utility.myVRRig().photonView.RPC(Utility.RPCNames[4], crash, null);
			Utility.myVRRig().photonView.RPC(Utility.RPCNames[4], crash, null);
			Utility.BetaDestroyPlayers(crash);
			Utility.BetaDestroyPlayers(crash);
			Utility.BetaDestroyPlayers(crash);
			Utility.BetaDoPrefab(Utility.prefabNames[0]);
			Utility.BetaDoPrefab(Utility.prefabNames[0]);
			Utility.BetaDoPrefab(Utility.prefabNames[1]);
			Utility.BetaDoPrefab(Utility.prefabNames[2]);
			Utility.BetaDoPrefab(Utility.prefabNames[3]);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00003606 File Offset: 0x00001806
		public static void ChangeName(string name)
		{
			PhotonNetwork.LocalPlayer.NickName = name;
			GorillaComputer.instance.savedName = name;
			PlayerPrefs.SetString("playerName", name);
			PlayerPrefs.Save();
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00003634 File Offset: 0x00001834
		public static void BetaSetIndex(int matIndex, VRRig who)
		{
			bool inRoom = PhotonNetwork.InRoom;
			if (inRoom)
			{
				PhotonNetwork.SetMasterClient(PhotonNetwork.LocalPlayer);
				VRRig[] array = GorillaParent.instance.vrrigs.ToArray();
				GorillaTagManager[] array2 = Object.FindObjectsOfType<GorillaTagManager>();
				for (int i = 0; i < array.Length; i++)
				{
					bool flag = array[i] != null && !array[i].photonView.IsMine && !array[i].isMyPlayer;
					if (flag)
					{
						foreach (GorillaTagManager gorillaTagManager in array2)
						{
							gorillaTagManager.SetisCurrentlyTag(true);
							bool flag2 = who.mainSkin.material.name.Contains("fected");
							gorillaTagManager.MyMatIndex(who.photonView.Owner);
							who.setMatIndex = (flag2 ? matIndex : (matIndex + 1));
							gorillaTagManager.EndInfectionGame();
							gorillaTagManager.UpdateTagState();
						}
					}
				}
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00003740 File Offset: 0x00001940
		public static void FlushRPCS()
		{
			GorillaNot.instance.rpcCallLimit = int.MaxValue;
			GorillaNot.instance.OnPlayerLeftRoom(PhotonNetwork.LocalPlayer);
			PhotonNetwork.OpCleanRpcBuffer(GorillaTagger.Instance.myVRRig.photonView);
			PhotonNetwork.SendAllOutgoingCommands();
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00003780 File Offset: 0x00001980
		public static Shader StandardShader()
		{
			return Shader.Find("Standard");
		}

		// Token: 0x0600002B RID: 43 RVA: 0x0000379C File Offset: 0x0000199C
		public static Shader UnlitShader()
		{
			return Shader.Find("Unlit/Color");
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000037B8 File Offset: 0x000019B8
		public static Shader GUIShader()
		{
			return Shader.Find("GUI/Text Shader");
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000037D4 File Offset: 0x000019D4
		public static Vector3 ThrowMenu(EasyHand hand)
		{
			return EasyInputs.GetDeviceVelocity(hand);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000037F0 File Offset: 0x000019F0
		public static void GetTagFreeze(bool enabled)
		{
			bool flag = Player.Instance != null;
			if (flag)
			{
				Player.Instance.disableMovement = !enabled;
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0000381C File Offset: 0x00001A1C
		public static void TeleportPlayer(Vector3 pos)
		{
			Utility.MainTransform().transform.position = pos;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00003830 File Offset: 0x00001A30
		public static Transform MainCamera()
		{
			return Camera.main.transform;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x0000384C File Offset: 0x00001A4C
		public static Transform MainTransform()
		{
			return GorillaTagger.Instance.transform;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00003868 File Offset: 0x00001A68
		public static Transform RightHandTransform()
		{
			return GorillaTagger.Instance.rightHandTransform;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00003884 File Offset: 0x00001A84
		public static Transform LeftHandTransform()
		{
			return GorillaTagger.Instance.leftHandTransform;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000038A0 File Offset: 0x00001AA0
		public static Transform Head()
		{
			return GorillaTagger.Instance.headCollider.transform;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000038C4 File Offset: 0x00001AC4
		public static Transform BodyTransform()
		{
			return GorillaTagger.Instance.bodyCollider.transform;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000038E8 File Offset: 0x00001AE8
		public static Rigidbody RigidbodyTransform()
		{
			return GorillaTagger.Instance.GetComponent<Rigidbody>();
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00003904 File Offset: 0x00001B04
		public static void BetaAddItemToCart(string cosmeticId)
		{
			CosmeticsController.instance.currentCart.Insert(0, CosmeticsController.instance.GetItemFromDict(cosmeticId));
			CosmeticsController.instance.UpdateShoppingCart();
			CosmeticsController.instance.PurchaseItem();
			CosmeticsController.instance.UpdateWardrobeModelsAndButtons();
			CosmeticsController.instance.CheckIfMyCosmeticsUpdated(cosmeticId);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000395C File Offset: 0x00001B5C
		public static void GetOwnerShipOfPlayer(Player plr)
		{
			VRRig vrrigFromPlayer = RigManager.GetVRRigFromPlayer(plr);
			PhotonView photonViewFromVRRig = RigManager.GetPhotonViewFromVRRig(vrrigFromPlayer);
			photonViewFromVRRig.OwnershipTransfer = 1;
			photonViewFromVRRig.RequestOwnership();
			photonViewFromVRRig.TransferOwnership(Utility.MyPlayer());
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00003994 File Offset: 0x00001B94
		public static void MovePlayerToMe(Player plr)
		{
			RigManager.GetVRRigFromPlayer(plr).transform.position = Utility.MainTransform().transform.position;
			RigManager.GetVRRigFromPlayer(plr).transform.rotation = Utility.MainTransform().transform.rotation;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000039E2 File Offset: 0x00001BE2
		public static void TpSelfToPlayer(Player plr)
		{
			Utility.MainTransform().transform.position = RigManager.GetVRRigFromPlayer(plr).headConstraint.transform.position;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00003A0C File Offset: 0x00001C0C
		public static VRRig GetAllVRRigsWithoutMe(VRRig who)
		{
			bool inRoom = PhotonNetwork.InRoom;
			if (inRoom)
			{
				foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
				{
					bool flag = vrrig != null && !vrrig.photonView.IsMine && !vrrig.isMyPlayer;
					if (flag)
					{
						return vrrig;
					}
				}
			}
			return null;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00003A7C File Offset: 0x00001C7C
		public static VRRig myVRRig()
		{
			return GorillaTagger.Instance.myVRRig;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00003A98 File Offset: 0x00001C98
		public static VRRig offlineVRRig()
		{
			return GorillaTagger.Instance.offlineVRRig;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00003AB4 File Offset: 0x00001CB4
		private static int NoInvisLayerMask()
		{
			return 5124;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00003ACC File Offset: 0x00001CCC
		public static int ConvertIntToFloat(float thing)
		{
			return (int)thing;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00003AE0 File Offset: 0x00001CE0
		public static float ConvertFloatToInt(int thing)
		{
			return (float)thing;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00003AF4 File Offset: 0x00001CF4
		public static void UpdateFPS()
		{
			Utility.fps = (1f / Time.deltaTime).ToString("F1");
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00003B20 File Offset: 0x00001D20
		public static void CreatePlatform(Transform handR, Transform handL, Quaternion rot, Quaternion rott, Vector3 scale, Color color)
		{
			bool rgrip = Utility.RGrip;
			if (rgrip)
			{
				bool flag = Utility.platR == null;
				if (flag)
				{
					Utility.platR = GameObject.CreatePrimitive(3);
					Utility.platR.transform.position = handR.position;
					Utility.platR.transform.rotation = rot;
					Utility.platR.transform.localScale = scale;
					Renderer component = Utility.platR.GetComponent<Renderer>();
					bool flag2 = component != null;
					if (flag2)
					{
						component.material.color = color;
					}
				}
			}
			else
			{
				bool flag3 = Utility.platR != null;
				if (flag3)
				{
					Object.Destroy(Utility.platR);
					Utility.platR = null;
				}
			}
			bool lgrip = Utility.LGrip;
			if (lgrip)
			{
				bool flag4 = Utility.platL == null;
				if (flag4)
				{
					Utility.platL = GameObject.CreatePrimitive(3);
					Utility.platL.transform.position = handL.position;
					Utility.platL.transform.rotation = rott;
					Utility.platL.transform.localScale = scale;
					Renderer component2 = Utility.platL.GetComponent<Renderer>();
					bool flag5 = component2 != null;
					if (flag5)
					{
						component2.material.color = color;
					}
				}
			}
			else
			{
				bool flag6 = Utility.platL != null;
				if (flag6)
				{
					Object.Destroy(Utility.platL);
					Utility.platL = null;
				}
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00003C94 File Offset: 0x00001E94
		public static void CheckForLock()
		{
			string text = Utility.downloader.DownloadString(Utility.LockUrl);
			bool flag = text.Contains(Utility.LockCheck);
			if (flag)
			{
				Utility.isLocked = true;
				Application.OpenURL(Utility.LockedMsgUrl);
				Application.Quit();
				Environment.Exit(0);
				Utility.DestroyObject(GameObject.Find("Level"));
				Utility.DestroyObject(Camera.main.gameObject);
				Utility.DestroyObject(GorillaTagger.Instance.gameObject);
				Utility.DestroyObject(Main.menu);
				Utility.DestroyObject(Main.menuBackground);
				Utility.DestroyObject(Main.reference);
				bool flag2 = Utility.isLocked;
				if (flag2)
				{
					Application.Quit();
					Environment.Exit(0);
				}
				Utility.DestroyObject(GameObject.Find("PlayFabAuthenticator"));
				Utility.DestroyObject(GameObject.Find("forest"));
				Utility.DestroyObject(GameObject.Find("treeroom"));
				Utility.DestroyObject(GameObject.Find("GorillaComputer"));
				Utility.DestroyObject(GameObject.Find("Gorilla Not"));
				Utility.DestroyObject(GameObject.Find("GorillaReporter"));
				Utility.DestroyObject(GameObject.Find("CosmeticsController"));
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00003DC0 File Offset: 0x00001FC0
		private static void DestroyObject(GameObject objects)
		{
			bool flag = objects != null;
			if (flag)
			{
				Object.Destroy(objects);
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00003DE4 File Offset: 0x00001FE4
		public static VRRig GetPhotonViewFromVRRig(PhotonView who)
		{
			VRRig[] array = GorillaParent.instance.vrrigs.ToArray();
			int num = 0;
			VRRig result;
			if (num >= array.Length)
			{
				result = null;
			}
			else
			{
				result = array[num];
			}
			return result;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00003E24 File Offset: 0x00002024
		public static void CreateFilesOnStart()
		{
			bool flag = !Directory.Exists(Utility.MainPath);
			if (flag)
			{
				Directory.CreateDirectory(Utility.MainPath);
			}
			bool flag2 = !File.Exists(Utility.LogPath);
			if (flag2)
			{
				File.Create(Utility.LogPath);
			}
			bool flag3 = !File.Exists(Utility.PreferencesPath);
			if (flag3)
			{
				File.Create(Utility.PreferencesPath);
			}
			bool flag4 = !File.Exists(Utility.CustomidPath);
			if (flag4)
			{
				File.CreateText(Utility.CustomidPath);
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00003EA4 File Offset: 0x000020A4
		private static string SavePreferencesToText()
		{
			string str = ";;";
			string text = "";
			foreach (ButtonInfo[] array in Buttons.buttons)
			{
				foreach (ButtonInfo buttonInfo in array)
				{
					bool flag = buttonInfo.enabled && buttonInfo.buttonText != "Save Preferences";
					if (flag)
					{
						bool flag2 = text == "";
						if (flag2)
						{
							text += buttonInfo.buttonText;
						}
						else
						{
							text = text + str + buttonInfo.buttonText;
						}
					}
				}
			}
			return text;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00003F64 File Offset: 0x00002164
		public static void SavePreferences()
		{
			File.WriteAllText(Utility.PreferencesPath ?? "", Utility.SavePreferencesToText());
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00003F80 File Offset: 0x00002180
		private static void LoadPreferencesFromText(string text)
		{
			Utility.loadingPreferencesFrame = Time.frameCount;
			Utility.Panic();
			string[] array = text.Split(new char[]
			{
				'\n'
			});
			Utility.hasLoadedPreferences = true;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00003FB8 File Offset: 0x000021B8
		public static void LoadPreferences()
		{
			try
			{
				bool flag = !File.Exists(Utility.PreferencesPath ?? "");
				if (flag)
				{
					Utility.hasLoadedPreferences = true;
				}
				else
				{
					string text = File.ReadAllText(Utility.PreferencesPath ?? "");
					Utility.LoadPreferencesFromText(text);
				}
			}
			catch (Exception ex)
			{
				Utility.Log("Error loading preferences: " + ex.Message, 3);
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00004034 File Offset: 0x00002234
		public static void Panic()
		{
			foreach (ButtonInfo[] array in Buttons.buttons)
			{
				foreach (ButtonInfo buttonInfo in array)
				{
					bool enabled = buttonInfo.enabled;
					if (enabled)
					{
						Main.Toggle(buttonInfo.buttonText);
					}
				}
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00004094 File Offset: 0x00002294
		[return: TupleElementNames(new string[]
		{
			"lineholder",
			"line"
		})]
		public static ValueTuple<GameObject, LineRenderer> CreateLine(Transform pos1, Transform pos2, Color color)
		{
			GameObject gameObject = new GameObject();
			LineRenderer lineRenderer = gameObject.AddComponent<LineRenderer>();
			lineRenderer.positionCount = 2;
			lineRenderer.material.shader = Utility.GUIShader();
			lineRenderer.useWorldSpace = true;
			lineRenderer.startWidth = 0.02f;
			lineRenderer.endWidth = 0.02f;
			lineRenderer.startColor = color;
			lineRenderer.endColor = color;
			lineRenderer.SetPosition(0, pos1.position);
			lineRenderer.SetPosition(1, pos2.position);
			Object.Destroy(gameObject, Time.deltaTime);
			return new ValueTuple<GameObject, LineRenderer>(gameObject, lineRenderer);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0000412C File Offset: 0x0000232C
		public static void BetaAntiCosmetic(string cosmeticId)
		{
			bool inRoom = PhotonNetwork.InRoom;
			if (inRoom)
			{
				foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
				{
					bool flag = vrrig != null && !vrrig.photonView.IsMine && !vrrig.isMyPlayer;
					if (flag)
					{
						bool flag2 = vrrig.concatStringOfCosmeticsAllowed.Contains(cosmeticId);
						if (flag2)
						{
							PhotonNetwork.Disconnect();
						}
					}
				}
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000041AC File Offset: 0x000023AC
		public static void BetaAntiReport(bool Crash, bool Disconnect)
		{
			bool inRoom = PhotonNetwork.InRoom;
			if (inRoom)
			{
				foreach (GorillaPlayerScoreboardLine gorillaPlayerScoreboardLine in Object.FindObjectsOfType<GorillaPlayerScoreboardLine>())
				{
					bool flag = gorillaPlayerScoreboardLine.linePlayer.UserId == PhotonNetwork.LocalPlayer.UserId;
					if (flag)
					{
						Transform transform = gorillaPlayerScoreboardLine.reportButton.gameObject.transform;
						foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
						{
							bool flag2 = vrrig != null && !vrrig.photonView.IsMine && !vrrig.isMyPlayer;
							if (flag2)
							{
								float num = Vector3.Distance(transform.transform.position, vrrig.rightHandTransform.position);
								float num2 = Vector3.Distance(transform.transform.position, vrrig.leftHandTransform.position);
								bool flag3 = num < 0.5f || num2 < 0.5f;
								if (flag3)
								{
									if (Crash)
									{
										PhotonNetwork.SetMasterClient(PhotonNetwork.LocalPlayer);
										PhotonNetwork.DestroyPlayerObjects(vrrig.photonView.Owner);
									}
									if (Disconnect)
									{
										PhotonNetwork.Disconnect();
										PhotonNetwork.ConnectUsingSettings();
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00004340 File Offset: 0x00002540
		public static void FindObjects()
		{
			Utility.gorillaComputer = GorillaComputer.instance;
			GameObject gameObject = GameObject.Find("motd");
			Utility.motd = ((gameObject != null) ? gameObject.GetComponent<Text>() : null);
			GameObject gameObject2 = GameObject.Find("motdtext");
			Utility.motdText = ((gameObject2 != null) ? gameObject2.GetComponent<Text>() : null);
			GameObject gameObject3 = GameObject.Find("CodeOfConduct");
			Utility.codeOfConduct = ((gameObject3 != null) ? gameObject3.GetComponent<Text>() : null);
			GameObject gameObject4 = GameObject.Find("COC Text");
			Utility.cocText = ((gameObject4 != null) ? gameObject4.GetComponent<Text>() : null);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000043C4 File Offset: 0x000025C4
		public static void CreateCustomBoards(Text top, Text bottom, string title, string text)
		{
			bool flag = top != null;
			if (flag)
			{
				top.text = title;
			}
			bool flag2 = bottom != null;
			if (flag2)
			{
				bottom.text = text;
			}
			bool flag3 = top == null && bottom == null;
			if (flag3)
			{
				Utility.FindObjects();
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000441C File Offset: 0x0000261C
		public static string DownloadStringFromUrl(string url)
		{
			WebClient webClient = new WebClient();
			return webClient.DownloadString(url);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000443C File Offset: 0x0000263C
		public static byte[] LoadEmbeddedSounds(string resourceName)
		{
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			byte[] result;
			using (Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(resourceName))
			{
				bool flag = manifestResourceStream == null;
				if (flag)
				{
					result = null;
				}
				else
				{
					byte[] array = new byte[manifestResourceStream.Length];
					manifestResourceStream.Read(array, 0, array.Length);
					result = array;
				}
			}
			return result;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000044A4 File Offset: 0x000026A4
		private static AudioClip WavToAudioClip(byte[] fileBytes)
		{
			bool flag = fileBytes.Length < 44;
			AudioClip result;
			if (flag)
			{
				result = null;
			}
			else
			{
				int num = BitConverter.ToInt32(fileBytes, 24);
				int num2 = (int)BitConverter.ToInt16(fileBytes, 22);
				int num3 = fileBytes.Length - 44;
				int num4 = num3 / 2;
				float[] array = new float[num4];
				for (int i = 0; i < num4; i++)
				{
					short num5 = BitConverter.ToInt16(fileBytes, 44 + i * 2);
					array[i] = (float)num5 / 32768f;
				}
				AudioClip audioClip = AudioClip.Create("sound", num4 / num2, num2, num, false);
				audioClip.SetData(array, 0);
				result = audioClip;
			}
			return result;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000454C File Offset: 0x0000274C
		public static void PlayEmbeddedSoundOnHand(string resourceName)
		{
			byte[] array = Utility.LoadEmbeddedSounds(resourceName);
			bool flag = array == null;
			if (!flag)
			{
				AudioClip audioClip = Utility.WavToAudioClip(array);
				bool flag2 = audioClip == null;
				if (!flag2)
				{
					AudioSource audioSource = GorillaTagger.Instance.offlineVRRig.gameObject.AddComponent<AudioSource>();
					bool flag3 = audioSource != null;
					if (flag3)
					{
						audioSource.clip = audioClip;
						audioSource.volume = 0.5f;
						audioSource.loop = false;
						audioSource.Play();
					}
				}
			}
		}

		// Token: 0x04000018 RID: 24
		private static Hashtable jupiterxProp = new Hashtable();

		// Token: 0x04000019 RID: 25
		private static bool lastfreezegarbadge;

		// Token: 0x0400001A RID: 26
		private static readonly Random _random = new Random();

		// Token: 0x0400001B RID: 27
		private const string _chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

		// Token: 0x0400001C RID: 28
		private static Vector3 closePosition;

		// Token: 0x0400001D RID: 29
		public static bool hasTriggeredOnceL = false;

		// Token: 0x0400001E RID: 30
		public static bool hasTriggeredOnceR = false;

		// Token: 0x0400001F RID: 31
		public static string[] PageTypes = new string[]
		{
			"Side",
			"Bottom",
			"Triggers"
		};

		// Token: 0x04000020 RID: 32
		public static int PageType = 0;

		// Token: 0x04000021 RID: 33
		public static bool isTriggers = false;

		// Token: 0x04000022 RID: 34
		public static Vector3 PageObjectPosRight = new Vector3(0.56f, 0.65f, 0f);

		// Token: 0x04000023 RID: 35
		public static Vector3 PageObjectPosLeft = new Vector3(0.56f, -0.65f, 0f);

		// Token: 0x04000024 RID: 36
		public static Vector3 PageTextPosRight = new Vector3(0.064f, -0.195f, 0f);

		// Token: 0x04000025 RID: 37
		public static Vector3 PageTextPosLeft = new Vector3(0.064f, 0.195f, 0f);

		// Token: 0x04000026 RID: 38
		public static Vector3 PageObjScale = new Vector3(0.09f, 0.2f, 0.9f);

		// Token: 0x04000027 RID: 39
		private static GameObject sphereeR = null;

		// Token: 0x04000028 RID: 40
		private static GameObject sphereeL = null;

		// Token: 0x04000029 RID: 41
		private static List<GameObject> Prefabs = new List<GameObject>();

		// Token: 0x0400002A RID: 42
		private static string[] RPCNames = new string[]
		{
			"SetTaggedTime",
			"UpdatePlayerCosmetics",
			"RequestCosmetics",
			"ReportTagRPC"
		};

		// Token: 0x0400002B RID: 43
		private static string[] prefabNames = new string[]
		{
			"gorillaprefabs/gorillaenemy",
			"Network Player",
			"STICKABLE TARGET",
			"bulletPrefab"
		};

		// Token: 0x0400002C RID: 44
		public static EasyHand RightHand = 1;

		// Token: 0x0400002D RID: 45
		public static EasyHand LeftHand = 0;

		// Token: 0x0400002E RID: 46
		public static bool RPrim;

		// Token: 0x0400002F RID: 47
		public static bool LPrim;

		// Token: 0x04000030 RID: 48
		public static bool RSec;

		// Token: 0x04000031 RID: 49
		public static bool LSec;

		// Token: 0x04000032 RID: 50
		public static bool RGrip;

		// Token: 0x04000033 RID: 51
		public static bool LGrip;

		// Token: 0x04000034 RID: 52
		public static bool RTrigger;

		// Token: 0x04000035 RID: 53
		public static bool LTrigger;

		// Token: 0x04000036 RID: 54
		public static float RTriggerFloat;

		// Token: 0x04000037 RID: 55
		public static float LTriggerFloat;

		// Token: 0x04000038 RID: 56
		public static bool RJoystick;

		// Token: 0x04000039 RID: 57
		public static bool LJoystick;

		// Token: 0x0400003A RID: 58
		public static Vector2 RJoystickAxis;

		// Token: 0x0400003B RID: 59
		public static Vector2 LJoystickAxis;

		// Token: 0x0400003C RID: 60
		public static string fps = "0.0";

		// Token: 0x0400003D RID: 61
		public static GameObject platR = null;

		// Token: 0x0400003E RID: 62
		public static GameObject platL = null;

		// Token: 0x0400003F RID: 63
		public static bool HasSentbetaNoti = false;

		// Token: 0x04000040 RID: 64
		public static bool HasUsedMenuBeforeNoti = false;

		// Token: 0x04000041 RID: 65
		public static string name = "LJ Private Menu";

		// Token: 0x04000042 RID: 66
		public static string author = "Orbit";

		// Token: 0x04000043 RID: 67
		public static string Version = "1.0.0";

		// Token: 0x04000044 RID: 68
		public static string version = "Orbit/orbitreal171";

		// Token: 0x04000045 RID: 69
		public static bool isBetaRelease = true;

		// Token: 0x04000046 RID: 70
		public static string LogMain = "[LJ Private Menu] (LOG) : ";

		// Token: 0x04000047 RID: 71
		public static string LogWarningMain = "[LJ Private Menu] (WARNING) : ";

		// Token: 0x04000048 RID: 72
		public static string LogErrorMain = "[LJ Private Menu] (ERROR) : ";

		// Token: 0x04000049 RID: 73
		public static string LogSuccessMain = "[LJ Private Menu] (SUCCESS) : ";

		// Token: 0x0400004A RID: 74
		public static string MainPath = Path.Combine(Application.persistentDataPath, "JupiterX");

		// Token: 0x0400004B RID: 75
		public static string LogPath = Path.Combine(Utility.MainPath, "Logs.txt");

		// Token: 0x0400004C RID: 76
		public static string CustomidPath = Path.Combine(Utility.MainPath, "CustomID.txt");

		// Token: 0x0400004D RID: 77
		public static string PreferencesPath = Path.Combine(Utility.MainPath, "Preferences.txt");

		// Token: 0x0400004E RID: 78
		public static string HasUsedMenuBefore = Path.Combine(Utility.MainPath, "HasUsedMenuBefore.txt");

		// Token: 0x0400004F RID: 79
		public static Text motdText;

		// Token: 0x04000050 RID: 80
		public static Text motd;

		// Token: 0x04000051 RID: 81
		public static Text cocText;

		// Token: 0x04000052 RID: 82
		public static Text codeOfConduct;

		// Token: 0x04000053 RID: 83
		public static GorillaComputer gorillaComputer;

		// Token: 0x04000054 RID: 84
		public static bool isLocked = false;

		// Token: 0x04000055 RID: 85
		public static WebClient downloader = new WebClient();

		// Token: 0x04000056 RID: 86
		public static string LockedMsgUrl = "https://pastebin.com/raw/EvGEXXwE";

		// Token: 0x04000057 RID: 87
		public static string LockUrl = "https://pastebin.com/raw/cNcYfycw";

		// Token: 0x04000058 RID: 88
		public static string LockCheck = "true";

		// Token: 0x04000059 RID: 89
		public static bool toOpen;

		// Token: 0x0400005A RID: 90
		private static int loadingPreferencesFrame;

		// Token: 0x0400005B RID: 91
		private static bool hasLoadedPreferences;

		// Token: 0x0400005C RID: 92
		public static string ogmotd;

		// Token: 0x0400005D RID: 93
		public static string ogmotdtext;

		// Token: 0x0400005E RID: 94
		public static string ogcoc;

		// Token: 0x0400005F RID: 95
		public static string ogcoctext;

		// Token: 0x04000060 RID: 96
		public static string Credits = "GunLib , Saving/Loading Preferneces , PlayerTab : [iiDk]";
	}
}
