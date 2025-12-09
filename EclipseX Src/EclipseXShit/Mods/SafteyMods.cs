using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Photon.Pun;
using UnityEngine;

namespace EclipseX.Mods
{
    internal class SafteyMods
    {
        public static void AntiReport()
        {
            foreach (GorillaPlayerScoreboardLine gorillaPlayerScoreboardLine in UnityEngine.Object.FindObjectsOfType<GorillaPlayerScoreboardLine>())
            {
                if (gorillaPlayerScoreboardLine.linePlayer.UserId == PhotonNetwork.LocalPlayer.UserId)
                {
                    foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
                    {
                        if (Vector3.Distance(vrrig.leftHandTransform.position, gorillaPlayerScoreboardLine.reportButton.transform.position) < 4f)
                        {
                            PhotonNetwork.Disconnect();
                            PhotonNetwork.ConnectUsingSettings();
                        }
                        if (Vector3.Distance(vrrig.rightHandTransform.position, gorillaPlayerScoreboardLine.reportButton.transform.position) < 4f)
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
