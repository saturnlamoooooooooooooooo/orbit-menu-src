using System;
using GorillaNetworking;
using Photon.Pun;
using UnityEngine;

namespace IIDKQuest.Mods
{
    // Token: 0x0200005E RID: 94
    internal class MenuNameTag
    {
        // Token: 0x060000E0 RID: 224 RVA: 0x000064C8 File Offset: 0x000046C8
        public static void MenuNameTagFrFr()
        {
            string[] array = new string[]
            {
                "<color=magenta>Orbital.lol Menu [ LUNAR]</color>",
                "<color=blue>Orbital.lol Menu [ LUNAR ]</color>",
                "<color=magenta>Orbital.lol Menu [ LUNAR ]</color>",
                "<color=blue>Orbital.lol Menu [ LUNAR]</color>"
            };
            int num = new System.Random().Next(array.Length);
            PhotonNetwork.LocalPlayer.NickName = array[num];
            GorillaComputer.instance.currentName = array[num];
            PlayerPrefs.SetString("GorillaLocomotion.PlayerName", array[num]);
            string userId = " LUNAR BTW IM A <color=green>Co</color>Dev ";
            PhotonNetwork.LocalPlayer.UserId = userId;
        }
    }
}
