using System;
using easyInputs;
using GorillaLocomotion;
using Photon.Pun;
using UnityEngine;

namespace IIDKQuest.Mods
{
    // Token: 0x02000007 RID: 7
    internal class MosaSpeed
    {
        // Token: 0x06000010 RID: 16 RVA: 0x0000280D File Offset: 0x00000A0D
        public static void MosaSpeedByOrbit()
        {
            Player.Instance.maxJumpSpeed = 6.5f;
            Player.Instance.jumpMultiplier = 1.5f;
        }
    }
}
