using System;
using GorillaLocomotion;
using UnityEngine;

namespace IIDKQuest.Mods
{
    // Token: 0x0200000A RID: 10
    internal class LongArms
    {
        public static void LongArmsByOrbit()
        {
            Player.Instance.transform.localScale = new Vector3(1.25f, 1.25f, 1.25f);
            Player.Instance.maxJumpSpeed = 15f;
            Player.Instance.jumpMultiplier = 10f;
        }
    }
}
