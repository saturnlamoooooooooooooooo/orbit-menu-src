using System;
using UnityEngine;

namespace IIDKQuest.Mods
{
    // Token: 0x02000008 RID: 8
    internal class bannaOS
    {
        // Token: 0x06000012 RID: 18 RVA: 0x00002846 File Offset: 0x00000A46
        public static void GiveBananaOS()
        {
            GameObject.Find("OfflineVRRig/Actual Gorilla/rig/body/shoulder.L/upper_arm.L/forearm.L/hand.L/bananaoswatch").SetActive(true);
        }
    }
}
