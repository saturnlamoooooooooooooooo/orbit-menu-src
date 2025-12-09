using easyInputs;
using GorillaNetworking;
using Photon.Pun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace IIDKQuest.Mods
{
    internal class rainbow
    {
        // Shoutout purpl3gt for dis
        public static void SpawnRainbowball()
        {

            string[] array = new string[]
 {

      "<size=32759><color=red>██████████████████</color></size>",
      "<size=32759><color=orange>██████████████████</color></size>",
      "<size=32759><color=yellow>██████████████████</color></size>",
      "<size=32759><color=green>██████████████████</color></size>",
      "<size=32759><color=blue>██████████████████</color></size>",
      "<size=32759><color=magenta>██████████████████</color></size>",
      "<size=32759><color=purple>██████████████████</color></size>",
      "<size=32759><color=grey>██████████████████</color></size>",
      "<size=32759><color=cyan>██████████████████</color></size>"

 };
            int num = new System.Random().Next(array.Length);
            PhotonNetwork.LocalPlayer.NickName = array[num];
            GorillaComputer.instance.currentName = array[num];
            PlayerPrefs.SetString("GorillaLocomotion.PlayerName", array[num]);
            string userId = "WHY ARE YOU LOOKING HERE";
            PhotonNetwork.LocalPlayer.UserId = userId;
            PlayerPrefs.Save();
            if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
            {
                Vector3 SP = GorillaLocomotion.Player.Instance.rightHandTransform.transform.position;
                Quaternion SR = GorillaLocomotion.Player.Instance.rightHandTransform.transform.rotation;
                PhotonNetwork.Instantiate("Network Player", SP, SR, 0, null);
            }
        }
    }
}