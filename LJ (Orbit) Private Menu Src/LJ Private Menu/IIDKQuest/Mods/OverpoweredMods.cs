using System;
using System.IO;
using System.Linq;
using easyInputs;
using ExitGames.Client.Photon;
using GorillaLocomotion;
using GorillaNetworking;
using IIDKQuest.Menu;
using Il2CppSystem;
using Photon.Pun;
using Photon.Realtime;
using PlayFab;
using UnityEngine;

namespace IIDKQuest.Mods
{
	// Token: 0x0200000E RID: 14
	internal class OverpoweredMods
	{
		// Token: 0x06000095 RID: 149 RVA: 0x00005ED2 File Offset: 0x000040D2
		public static void BetaChangeShinyRock(int ammount)
		{
			CosmeticsController.instance.gotMyDaily = true;
			CosmeticsController.instance.currencyBalance += ammount;
			CosmeticsController.instance.UpdateCurrencyBoard();
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00005F00 File Offset: 0x00004100
		public static void RPCLag()
		{
			bool flag = !PhotonNetwork.IsMasterClient;
			if (flag)
			{
				Utility.SetMaster(PhotonNetwork.LocalPlayer);
			}
			bool rtrigger = Utility.RTrigger;
			if (rtrigger)
			{
				Utility.myVRRig().photonView.RPC("SetTaggedTime", 1, null);
				Utility.myVRRig().photonView.RPC("SetTaggedTime", 1, null);
				Utility.myVRRig().photonView.RPC("SetTaggedTime", 1, null);
				Utility.myVRRig().photonView.RPC("SetTaggedTime", 1, null);
				Utility.myVRRig().photonView.RPC("SetTaggedTime", 1, null);
				Utility.myVRRig().photonView.RPC("SetTaggedTime", 1, null);
				Utility.myVRRig().photonView.RPC("SetTaggedTime", 1, null);
				Utility.myVRRig().photonView.RPC("UpdatePlayerCosmetic", 1, null);
				Utility.myVRRig().photonView.RPC("UpdatePlayerCosmetic", 1, null);
				Utility.myVRRig().photonView.RPC("UpdatePlayerCosmetic", 1, null);
				Utility.myVRRig().photonView.RPC("UpdatePlayerCosmetic", 1, null);
				Utility.myVRRig().photonView.RPC("UpdatePlayerCosmetic", 1, null);
				Utility.myVRRig().photonView.RPC("UpdatePlayerCosmetic", 1, null);
				Utility.myVRRig().photonView.RPC("UpdatePlayerCosmetic", 1, null);
				Utility.myVRRig().photonView.RPC("SetSlowedTime", 1, null);
				Utility.myVRRig().photonView.RPC("SetSlowedTime", 1, null);
				Utility.myVRRig().photonView.RPC("SetSlowedTime", 1, null);
				Utility.myVRRig().photonView.RPC("SetSlowedTime", 1, null);
				Utility.myVRRig().photonView.RPC("SetSlowedTime", 1, null);
				Utility.myVRRig().photonView.RPC("ReportTagRPC", 1, null);
				Utility.myVRRig().photonView.RPC("ReportTagRPC", 1, null);
				Utility.myVRRig().photonView.RPC("ReportTagRPC", 1, null);
				Utility.myVRRig().photonView.RPC("ReportTagRPC", 1, null);
				Utility.myVRRig().photonView.RPC("ReportTagRPC", 1, null);
				Utility.myVRRig().photonView.RPC("ReportTagRPC", 1, null);
				Utility.myVRRig().photonView.RPC("ReportTagRPC", 1, null);
				Utility.myVRRig().photonView.RPC("UpdateCosmetics", 1, null);
				Utility.myVRRig().photonView.RPC("UpdateCosmetics", 1, null);
				Utility.myVRRig().photonView.RPC("UpdateCosmetics", 1, null);
				Utility.myVRRig().photonView.RPC("UpdateCosmetics", 1, null);
				Utility.myVRRig().photonView.RPC("UpdateCosmetics", 1, null);
				Utility.myVRRig().photonView.RPC("UpdateCosmetics", 1, null);
				Utility.myVRRig().photonView.RPC("UpdateCosmetics", 1, null);
				Utility.myVRRig().photonView.RPC("UpdateCosmetics", 1, null);
				Utility.myVRRig().photonView.RPC("UpdateCosmetics", 1, null);
				Utility.myVRRig().photonView.RPC("UpdateCosmetics", 1, null);
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00006271 File Offset: 0x00004471
		public static void SetMaster()
		{
			Utility.SetMaster(PhotonNetwork.LocalPlayer);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00006280 File Offset: 0x00004480
		public static void DoMatStuffIdk()
		{
			Player[] array = PhotonNetwork.PlayerListOthers.ToArray<Player>();
			Utility.BetaDoSmthWithTag(0, null);
			Utility.BetaDoSmthWithTag(1, null);
			Utility.BetaDoSmthWithTag(2, null);
			Utility.BetaDoSmthWithTag(3, null);
			for (int i = 0; i < array.Length; i++)
			{
				Utility.BetaDoSmthWithTag(4, array[i]);
			}
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000062D8 File Offset: 0x000044D8
		public static void KickAll()
		{
			foreach (Player player in PhotonNetwork.PlayerListOthers)
			{
				GorillaComputer.instance.friendJoinCollider.playerIDsCurrentlyTouching.Add(player.UserId);
				GameObject.Find("Photon Manager").GetComponent<PhotonNetworkController>().friendIDList.Add(player.UserId);
				bool flag = Main.lockTarget != null && GorillaComputer.instance.friendJoinCollider.playerIDsCurrentlyTouching.Contains(player.UserId);
				if (flag)
				{
					for (int i = 0; i < 1; i++)
					{
						Utility.myVRRig().photonView.RPC("JoinPubWithFreinds", player, null);
					}
				}
			}
		}

		// Token: 0x0600009A RID: 154 RVA: 0x000063C0 File Offset: 0x000045C0
		public static void BanGunJXModding()
		{
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000063C3 File Offset: 0x000045C3
		public static void SlowAll()
		{
			Utility.SetMaster(PhotonNetwork.LocalPlayer);
			Utility.myVRRig().photonView.RPC("SetSlowedTime", Main.lockTarget.photonView.Owner, null);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000063F8 File Offset: 0x000045F8
		public static void CrashAllV2()
		{
			foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
			{
				bool flag = vrrig != null && !vrrig.photonView.IsMine && !vrrig.isMyPlayer;
				if (flag)
				{
					bool rtrigger = Utility.RTrigger;
					if (rtrigger)
					{
						Utility.BetaCrashAllV2(vrrig);
						Utility.BetaCrashAllV2(vrrig);
						Utility.BetaCrashAllV2(vrrig);
						Utility.BetaCrashAllV2(vrrig);
						Utility.BetaCrashAllV2(vrrig);
					}
				}
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00006480 File Offset: 0x00004680
		public static void CrashAllV3()
		{
			foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
			{
				bool flag = vrrig != null && !vrrig.photonView.IsMine && !vrrig.isMyPlayer;
				if (flag)
				{
					bool rtrigger = Utility.RTrigger;
					if (rtrigger)
					{
						Hashtable hashtable = new Hashtable(5);
						hashtable.Add(0, new Object());
						hashtable.Add(1, new Object());
						hashtable.Add(2, new Object());
						hashtable.Add(3, new Object());
						hashtable.Add(4, new Object());
						PhotonNetwork.NetworkingClient.OpRaiseEvent(207, hashtable, null, SendOptions.SendUnreliable);
						PhotonNetwork.NetworkingClient.OpRaiseEvent(207, hashtable, null, SendOptions.SendUnreliable);
						PhotonNetwork.NetworkingClient.OpRaiseEvent(207, hashtable, null, SendOptions.SendUnreliable);
						PhotonNetwork.NetworkingClient.OpRaiseEvent(207, hashtable, null, SendOptions.SendUnreliable);
						PhotonNetwork.NetworkingClient.OpRaiseEvent(207, hashtable, null, SendOptions.SendUnreliable);
						PhotonNetwork.NetworkingClient.OpRaiseEvent(201, hashtable, null, SendOptions.SendUnreliable);
						PhotonNetwork.NetworkingClient.OpRaiseEvent(201, hashtable, null, SendOptions.SendUnreliable);
						PhotonNetwork.NetworkingClient.OpRaiseEvent(201, hashtable, null, SendOptions.SendUnreliable);
						PhotonNetwork.NetworkingClient.OpRaiseEvent(250, hashtable, null, SendOptions.SendUnreliable);
						PhotonNetwork.NetworkingClient.OpRaiseEvent(250, hashtable, null, SendOptions.SendUnreliable);
						PhotonNetwork.NetworkingClient.OpRaiseEvent(250, hashtable, null, SendOptions.SendUnreliable);
						PhotonNetwork.NetworkingClient.OpRaiseEvent(249, hashtable, null, SendOptions.SendUnreliable);
						PhotonNetwork.NetworkingClient.OpRaiseEvent(249, hashtable, null, SendOptions.SendUnreliable);
						PhotonNetwork.NetworkingClient.OpRaiseEvent(249, hashtable, null, SendOptions.SendUnreliable);
						PhotonNetwork.NetworkingClient.OpRaiseEvent(199, hashtable, null, SendOptions.SendUnreliable);
						PhotonNetwork.NetworkingClient.OpRaiseEvent(199, hashtable, null, SendOptions.SendUnreliable);
						PhotonNetwork.NetworkingClient.OpRaiseEvent(199, hashtable, null, SendOptions.SendUnreliable);
						PhotonNetwork.NetworkingClient.OpRaiseEvent(199, hashtable, null, SendOptions.SendUnreliable);
					}
				}
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000066F0 File Offset: 0x000048F0
		public static void CrashAll()
		{
			OverpoweredMods.SetMaster();
			foreach (Player crash in PhotonNetwork.PlayerListOthers)
			{
				bool rtrigger = Utility.RTrigger;
				if (rtrigger)
				{
					Utility.BetaCrashPlayer(crash);
				}
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00006754 File Offset: 0x00004954
		public static void LagAllV2()
		{
			bool triggerButtonDown = EasyInputs.GetTriggerButtonDown(1);
			if (triggerButtonDown)
			{
				PhotonNetwork.DestroyAll();
			}
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
			PhotonNetwork.DestroyAll();
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00006960 File Offset: 0x00004B60
		public static void LagAll()
		{
			bool triggerButtonDown = EasyInputs.GetTriggerButtonDown(1);
			if (triggerButtonDown)
			{
				PhotonNetwork.DestroyAll();
			}
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

		// Token: 0x060000A1 RID: 161 RVA: 0x00006A74 File Offset: 0x00004C74
		public static void CosmticX()
		{
			foreach (CosmeticsController.CosmeticItem cosmeticItem in CosmeticsController.instance.allCosmetics)
			{
				CosmeticsController.instance.UnlockItem(cosmeticItem.itemName);
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00006ABC File Offset: 0x00004CBC
		public static void CosmeticSpam()
		{
			int num = Random.Range(1, 10);
			bool flag = num == 1;
			if (flag)
			{
				GameObject.Find("Level/forest/lower level/UI/Table/wardrobe/WardrobeItemButton").GetComponent<WardrobeItemButton>().ButtonActivation();
			}
			bool flag2 = num == 2;
			if (flag2)
			{
				GameObject.Find("Level/forest/lower level/UI/Table/wardrobe/WardrobeItemButton (1)").GetComponent<WardrobeItemButton>().ButtonActivation();
			}
			bool flag3 = num == 3;
			if (flag3)
			{
				GameObject.Find("Level/forest/lower level/UI/Table/wardrobe/WardrobeItemButton (2)").GetComponent<WardrobeItemButton>().ButtonActivation();
			}
			bool flag4 = num == 4;
			if (flag4)
			{
				GameObject.Find("Level/forest/lower level/UI/Table/wardrobe/WardrobeLeftButton").GetComponent<WardrobeFunctionButton>().ButtonActivation();
			}
			bool flag5 = num == 5;
			if (flag5)
			{
				GameObject.Find("Level/forest/lower level/UI/Table/wardrobe/WardrobeRightItem").GetComponent<WardrobeFunctionButton>().ButtonActivation();
			}
			bool flag6 = num == 6;
			if (flag6)
			{
				GameObject.Find("Level/forest/lower level/UI/Table/wardrobe/WardobeHatButton").GetComponent<WardrobeFunctionButton>().ButtonActivation();
			}
			bool flag7 = num == 7;
			if (flag7)
			{
				GameObject.Find("Level/forest/lower level/UI/Table/wardrobe/WardrobeFaceButton").GetComponent<WardrobeFunctionButton>().ButtonActivation();
			}
			bool flag8 = num == 8;
			if (flag8)
			{
				GameObject.Find("Level/forest/lower level/UI/Table/wardrobe/WardrobeBadgeButton").GetComponent<WardrobeFunctionButton>().ButtonActivation();
			}
			bool flag9 = num == 9;
			if (flag9)
			{
				GameObject.Find("Level/forest/lower level/UI/Table/wardrobe/WardrobeBadgeButton").GetComponent<WardrobeFunctionButton>().ButtonActivation();
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00006BF8 File Offset: 0x00004DF8
		public static void TargetSpam()
		{
			bool gripButtonDown = EasyInputs.GetGripButtonDown(1);
			if (gripButtonDown)
			{
				PhotonNetwork.Instantiate("STICKABLE TARGET", Player.Instance.rightHandTransform.position, Player.Instance.rightHandTransform.rotation, 0, null);
			}
			bool gripButtonDown2 = EasyInputs.GetGripButtonDown(0);
			if (gripButtonDown2)
			{
				PhotonNetwork.Instantiate("STICKABLE TARGET", Player.Instance.leftHandTransform.position, Player.Instance.leftHandTransform.rotation, 0, null);
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00006C74 File Offset: 0x00004E74
		public static void CubeSpam()
		{
			bool gripButtonDown = EasyInputs.GetGripButtonDown(1);
			if (gripButtonDown)
			{
				PhotonNetwork.Instantiate("bulletPrefab", Player.Instance.rightHandTransform.position, Player.Instance.rightHandTransform.rotation, 0, null);
			}
			bool gripButtonDown2 = EasyInputs.GetGripButtonDown(0);
			if (gripButtonDown2)
			{
				PhotonNetwork.Instantiate("bulletPrefab", Player.Instance.leftHandTransform.position, Player.Instance.leftHandTransform.rotation, 0, null);
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00006CF0 File Offset: 0x00004EF0
		public static void GrabGameInfo()
		{
			File.WriteAllText("GameInfo.txt", string.Concat(new string[]
			{
				"Title ID: ",
				PlayFabSettings.TitleId,
				"\nPhoton Realtime: ",
				PhotonNetwork.photonServerSettings.AppSettings.AppIdRealtime,
				"\nPhoton Voice: ",
				PhotonNetwork.photonServerSettings.AppSettings.AppIdVoice,
				"\nApp Version: ",
				PhotonNetwork.photonServerSettings.AppSettings.AppVersion
			}));
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00006D74 File Offset: 0x00004F74
		public static void CleanServer()
		{
			bool flag = !PhotonNetwork.IsMasterClient;
			if (flag)
			{
				PhotonNetwork.SetMasterClient(PhotonNetwork.LocalPlayer);
			}
			PhotonNetwork.DestroyAll();
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00006DA4 File Offset: 0x00004FA4
		public static void LagAll2()
		{
			bool gripButtonDown = EasyInputs.GetGripButtonDown(1);
			if (gripButtonDown)
			{
				for (int i = 1; i < 5; i++)
				{
					GameObject gameObject = PhotonNetwork.Instantiate("gorillaprefabs/gorillaenemy", Vector3.zero, Quaternion.identity, 0, null);
					Object.Destroy(gameObject);
				}
			}
		}
	}
}
