using System;
using easyInputs;
using GorillaLocomotion;
using UnityEngine;

namespace IIDKQuest.Mods
{
    // Token: 0x0200000B RID: 11
    internal class InvMonk
    {
        public static void Invis()
        {
            bool triggerButtonDown = EasyInputs.GetTriggerButtonDown(EasyHand.LeftHand);
            if (triggerButtonDown)
            {
                GorillaTagger.Instance.myVRRig.transform.position = new Vector3(100f, 100f, 100f);
                GorillaTagger.Instance.offlineVRRig.transform.position = new Vector3(100f, 100f, 100f);
                GorillaTagger.Instance.myVRRig.enabled = false;
                GorillaTagger.Instance.offlineVRRig.enabled = false;
            }
            else
            {
                GorillaTagger.Instance.offlineVRRig.enabled = true;
                GorillaTagger.Instance.myVRRig.enabled = true;
            }
        }
    }
}
