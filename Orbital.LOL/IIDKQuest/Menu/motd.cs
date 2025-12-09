using System;
using GorillaNetworking;
using Mono.CSharp.Linq;
using Photon.Pun;
using PlayFab;
using TMPro;
using Unity.XR.Oculus;
using UnityEngine;
using UnityEngine.UI;

namespace Orbital.LOL.Menu
{
    // Token: 0x02000010 RID: 16
    internal class MOTD : MonoBehaviour
    {
        public static Color MenuColor { get; private set; }
        public static GameObject Computer { get; private set; }
        public static GameObject KeyBoard { get; private set; } // Changed type from 'object' to 'GameObject'

        // Token: 0x06000052 RID: 82 RVA: 0x00004814 File Offset: 0x00002A14
        public static void Boards()
        {
            GameObject.Find("motdtext").GetComponent<Text>().text =
                "<b><color=#00ffff>🌐 ORBITAL.LOL — Update V12</color></b>\n\n" +
                "• Orbits Life" 
              ;

            GameObject.Find("CodeOfConduct").GetComponent<Text>().text = "Info Pulled By Orbital.LOL:";

            GameObject.Find("COC Text").GetComponent<Text>().text = string.Concat(new string[]
            {
        "TitleID: ", PlayFabSettings.TitleId,
        "\nRealtime: ", PhotonNetwork.PhotonServerSettings.AppSettings.AppIdRealtime,
        "\nVoice: ", PhotonNetwork.PhotonServerSettings.AppSettings.AppIdVoice,
        "\nVersion: ", PhotonNetwork.PhotonServerSettings.AppSettings.AppVersion,
        "\nPlayerID: ", PlayFabSettings.staticPlayer?.PlayFabId ?? "Unavailable",
        "\nOrbital.LOL"
            });

            GameObject.Find("motd").GetComponent<Text>().text = "<b><color=#00ffff>🌐 ORBITAL.LOL — Update V12</color></b>\n\n" +
                "• AntiReport System\n" +
                "• Ghost Monkey Mode\n" +
                "• BananaOS Display\n" +
                "• Fat UI Menu Support\n" +
                "• Become Ball Feature\n" +
                "• Updated Gradient Ball Colors\n\n" +
                "<color=green>Download: orbital.lol</color>\n" +
                "<i>Use in Safe Envoriment to not get banned [ holy spelling ]</i>"; ;
        }



    }
}
