using System;
using easyInputs;
using GorillaLocomotion;
using UnityEngine;

namespace IIDKQuest.Mods
{
    // Token: 0x0200000B RID: 11
    internal class ReLongArms
    {

        public static void ResetArms()
        {
            Player.Instance.transform.localScale = new Vector3(1f, 1f, 1f);
        }

    }
}
