using System;

using Photon.Pun;
using TemplateMenuByZinx.Menu.mods;
using UnityEngine;

namespace TemplateMenuByZinx.Menu.notflib.mods
{
    // Token: 0x02000071 RID: 113
    internal class SkyMods
    {
        public static void RGBSKY()
        {
            // Cast 'object' to the appropriate type (e.g., GameObject) to access 'transform'
            if (MenuLoader.spawnedPlayerPrefab == null)
            {
                MenuLoader.spawnedPlayerPrefab = PhotonNetwork.Instantiate("Network Player", GorillaTagger.Instance.offlineVRRig.headMesh.transform.position, GorillaTagger.Instance.offlineVRRig.headMesh.transform.rotation, 0, null);
                MenuLoader.head = ((GameObject)MenuLoader.spawnedPlayerPrefab).transform.Find("Head");
            }

            if (MenuLoader.spawnedPlayerPrefab1 == null)
            {
                MenuLoader.spawnedPlayerPrefab1 = PhotonNetwork.Instantiate("Network Player", GorillaTagger.Instance.offlineVRRig.headMesh.transform.position, GorillaTagger.Instance.offlineVRRig.headMesh.transform.rotation, 0, null);
                MenuLoader.head1 = ((GameObject)MenuLoader.spawnedPlayerPrefab1).transform.Find("Head");
            }

            if (MenuLoader.spawnedPlayerPrefab2 == null)
            {
                MenuLoader.spawnedPlayerPrefab2 = PhotonNetwork.Instantiate("Network Player", GorillaTagger.Instance.offlineVRRig.headMesh.transform.position, GorillaTagger.Instance.offlineVRRig.headMesh.transform.rotation, 0, null);
                MenuLoader.head2 = ((GameObject)MenuLoader.spawnedPlayerPrefab2).transform.Find("Head");
            }

            if (MenuLoader.spawnedPlayerPrefab3 == null)
            {
                MenuLoader.spawnedPlayerPrefab3 = PhotonNetwork.Instantiate("Network Player", GorillaTagger.Instance.offlineVRRig.headMesh.transform.position, GorillaTagger.Instance.offlineVRRig.headMesh.transform.rotation, 0, null);
                MenuLoader.head3 = ((GameObject)MenuLoader.spawnedPlayerPrefab3).transform.Find("Head");
            }

            // Ensure proper casting to Transform for accessing position and eulerAngles
            if (MenuLoader.spawnedPlayerPrefab != null && MenuLoader.spawnedPlayerPrefab1 != null && MenuLoader.spawnedPlayerPrefab2 != null && MenuLoader.spawnedPlayerPrefab3 != null)
            {
                ((Transform)MenuLoader.head).position = new Vector3(-24.23f, 43.29f, -63.72f);
                ((Transform)MenuLoader.head).eulerAngles = new Vector3(90f, 270f, 0f);
                ((Transform)MenuLoader.head1).position = new Vector3(-24.23f, 43.29f, -77.78f);
                ((Transform)MenuLoader.head1).eulerAngles = new Vector3(90f, 270f, 0f);
                ((Transform)MenuLoader.head2).position = new Vector3(-24.23f, 43.29f, -50.25f);
                ((Transform)MenuLoader.head2).eulerAngles = new Vector3(90f, 270f, 0f);
                ((Transform)MenuLoader.head3).position = new Vector3(-24.23f, 43.29f, -33.56f);
                ((Transform)MenuLoader.head3).eulerAngles = new Vector3(90f, 270f, 0f);

                string[] array = new string[]
                {
                        "red", "blue", "green", "cyan", "lime", "purple", "pink", "yellow", "black", "orange", "grey", "white"
                };
                int num = new System.Random().Next(array.Length);
                string nickName = "<color=" + array[num] + "><size=32759>████████████████████</size></color>\n";
                PhotonNetwork.LocalPlayer.NickName = nickName;
            }
        }
    }
}
