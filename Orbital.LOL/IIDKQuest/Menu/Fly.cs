using System;
using easyInputs;
using GorillaLocomotion;
using UnityEngine;

namespace IIDKQuest.Mods
{
    // Token: 0x02000008 RID: 8
    internal class Fly
    {
        public static void FlyFr()
        {
            bool primaryButtonDown = EasyInputs.GetPrimaryButtonDown(EasyHand.RightHand);
            if (primaryButtonDown)
            {
                Player.Instance.transform.position += Player.Instance.headCollider.transform.forward * Time.deltaTime * 15f;
                Player.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
            }
        }

    }
}
