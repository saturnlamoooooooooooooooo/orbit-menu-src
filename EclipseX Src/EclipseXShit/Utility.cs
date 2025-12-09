using easyInputs;
using GorillaNetworking;
using Photon.Pun;
using Photon.Realtime;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Animations.Rigging;

namespace IIDKQuest
{
    /*
     This menu has no skidded mods
     if you remove this it is skidding
     Dm LJ/owner if these any bug
     And this is a beta
     */

    internal class Utility
    {
        public static void GhostMonkey()
        {
            if (EasyInputs.GetPrimaryButtonDown(EasyHand.RightHand))
            {
                GorillaTagger.Instance.myVRRig.enabled = false;
                GorillaTagger.Instance.offlineVRRig.enabled = false;
            }
            else
            {
                GorillaTagger.Instance.myVRRig.enabled = true;
                GorillaTagger.Instance.offlineVRRig.enabled = true;
            }
        }
        public static void InvisMonkey()
        {
            if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
            {
                GorillaTagger.Instance.myVRRig.head.trackingPositionOffset = new Vector3(999f, 0f, 0f);
            }
            else
            {
                GorillaTagger.Instance.myVRRig.head.trackingPositionOffset = new Vector3(0f, -0.15f, 0f);
            }
        }
        public static void JoinMenuRoom()
        {
            PhotonNetworkController.instance.AttemptToJoinSpecificRoom("<color=magenta>EclipseX</color>");
        }
        public static void InstaCrashAll() // Need to fix!
        {
            if (EasyInputs.GetTriggerButtonDown(EasyHand.RightHand))
            {
                Photon.Realtime.Player owner = targetView.Owner;
                
                if (owner != null && PhotonNetwork.IsMasterClient)
                {
                    for (int i = 0; i < 150; i++)
                    {
                        PhotonNetwork.DestroyPlayerObjects(owner);
                       

                    }
                }
            }
        }
        private class targetView
        {
            public static Player Owner { get; internal set; }
        }
        public static void ChangeName(string name)
        {
            PhotonNetwork.LocalPlayer.NickName = name;
        }
        public static void SetMaster()
        {
            if (!PhotonNetwork.IsMasterClient)
            {
                PhotonNetwork.SetMasterClient(PhotonNetwork.LocalPlayer);
            }
        }

    }
}
