using System;
using easyInputs;
using GorillaLocomotion;
using UnityEngine;

namespace IIDKQuest.Mods
{
    // Token: 0x0200000B RID: 11
    internal class RigMods
    {
        // Token: 0x06000043 RID: 67 RVA: 0x000043F0 File Offset: 0x000025F0
        public static void NoclipMod()
        {
            if (EasyInputs.GetTriggerButtonDown(EasyHand.RightHand))
            {
                foreach (MeshCollider collider in UnityEngine.Object.FindObjectsOfType<MeshCollider>())
                {
                    collider.enabled = false;
                }
            }
            else
            {
                foreach (MeshCollider collider in UnityEngine.Object.FindObjectsOfType<MeshCollider>())
                {
                    collider.enabled = true;
                }
            }
        }
    }
}
