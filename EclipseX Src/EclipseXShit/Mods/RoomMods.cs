using easyInputs;
using GorillaNetworking;
using Photon.Pun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace EclipseX.Mods
{
    /*
     This menu has no skidded mods
     if you remove this it is skidding
     Dm LJ/owner if these any bug
     And this is a beta
     */
    internal class RoomMods
    {
        
        public static void QuitApp()
        {
            Application.Quit();
        }

        public static void Disconnect()
        {
            PhotonNetwork.Disconnect();
        }

        public static void JoinRandomPub()
        {
            PhotonNetwork.JoinRandomRoom();
        }

        public static void GripDisconnect()
        {
            if (EasyInputs.GetGripButtonDown((EasyHand)1))
            {
                PhotonNetwork.Disconnect();
            }
        }

        public static void TriggerDisconnect()
        {
            if (EasyInputs.GetTriggerButtonDown((EasyHand)1))
            {
                PhotonNetwork.Disconnect();
            }
        }

        public static void Reconnect()
        {
            PhotonNetwork.Reconnect();
        }
    }
}
