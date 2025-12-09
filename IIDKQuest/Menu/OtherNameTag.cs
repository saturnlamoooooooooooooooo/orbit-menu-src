using System;
using GorillaNetworking;
using Photon.Pun;
using UnityEngine;

namespace IIDKQuest.Mods
{
    // Token: 0x0200005E RID: 94
    internal class MenuNameTags
    {
        // Token: 0x060000E0 RID: 224 RVA: 0x000064C8 File Offset: 0x000046C8
        public static void MenuNameTagFrFr()
        {
            string[] array = new string[]
            {
                "<color=red>Orbital.lol Menu [ BUYER ]</color>",
                "<color=blue>Orbital.lol Menu [ BUYER ]</color>",
                "<color=red>Orbital.lol Menu [ BUYER ]</color>",
                "<color=blue>Orbital.lol Menu [ BUYER ]</color>"
            };
            int num = new System.Random().Next(array.Length);
            PhotonNetwork.LocalPlayer.NickName = array[num];
            GorillaComputer.instance.currentName = array[num];
            PlayerPrefs.SetString("GorillaLocomotion.PlayerName", array[num]);
            string userId = "  ";
            PhotonNetwork.LocalPlayer.UserId = userId;
        }
    }
}
