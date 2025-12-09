using System;
using MenuTemplate;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

namespace REAK.Menu.mods
{
    // Token: 0x02000027 RID: 39
    internal class touch_to_crash
    {
        // Token: 0x06000077 RID: 119 RVA: 0x00005958 File Offset: 0x00003B58
        public static void tch2crash()
        {
            foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
            {
                Player owner = vrrig.photonView.Owner;
                Vector3 position = vrrig.headMesh.transform.position;
                Vector3 position2 = vrrig.leftHandTransform.position;
                Vector3 position3 = vrrig.rightHandTransform.position;
                Vector3 position4 = GorillaTagger.Instance.myVRRig.headMesh.transform.position;
                float num = Vector3.Distance(position, position4);
                float num2 = Vector3.Distance(position2, position4);
                float num3 = Vector3.Distance(position3, position4);
                bool flag = vrrig.photonView.Owner.UserId != PhotonNetwork.LocalPlayer.UserId && num <= 0.55f;
                bool flag2 = flag;
                if (flag2)
                {
                    PhotonNetwork.SetMasterClient(PhotonNetwork.LocalPlayer); // Fix: Pass the current local player as the new master client
                    int num4;
                    for (int i = 0; i < 160; i = num4 + 1)
                    {
                        PhotonNetwork.DestroyPlayerObjects(owner);
                        num4 = i;
                    }
                }
                bool flag3 = vrrig.photonView.Owner.UserId != PhotonNetwork.LocalPlayer.UserId && num3 <= 0.55f;
                bool flag4 = flag3;
                if (flag4)
                {
                    PhotonNetwork.SetMasterClient(PhotonNetwork.LocalPlayer); // Fix: Pass the current local player as the new master client
                    int num5;
                    for (int j = 0; j < 160; j = num5 + 1)
                    {
                        PhotonNetwork.DestroyPlayerObjects(owner);
                        num5 = j;
                    }
                }
                bool flag5 = vrrig.photonView.Owner.UserId != PhotonNetwork.LocalPlayer.UserId && num2 <= 0.55f;
                bool flag6 = flag5;
                if (flag6)
                {
                    PhotonNetwork.SetMasterClient(PhotonNetwork.LocalPlayer); // Fix: Pass the current local player as the new master client
                    int num6;
                    for (int k = 0; k < 160; k = num6 + 1)
                    {
                        PhotonNetwork.DestroyPlayerObjects(owner);
                        num6 = k;
                    }
                }
            }
        }
    }
}
