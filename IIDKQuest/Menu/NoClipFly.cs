using System;
using easyInputs;
using GorillaLocomotion;
using UnityEngine;

namespace IIDKQuest.Mods
{
    // Token: 0x02000008 RID: 8
    internal class NoClipFly
    {
       
        public static void NoclipFly()
        {
            bool primaryButtonDown = EasyInputs.GetPrimaryButtonDown(EasyHand.RightHand);
            if (primaryButtonDown)
            {
                Player.Instance.transform.position += Player.Instance.headCollider.transform.forward * Time.deltaTime * 15f;
                Player.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
                foreach (Collider collider in UnityEngine.Object.FindObjectsOfType<MeshCollider>())
                {
                    collider.enabled = false;
                }
                foreach (Collider collider2 in UnityEngine.Object.FindObjectsOfType<BoxCollider>())
                {
                    collider2.enabled = false;
                }
                foreach (Collider collider3 in UnityEngine.Object.FindObjectsOfType<SphereCollider>())
                {
                    collider3.enabled = false;
                }
                foreach (BoxCollider boxCollider in Resources.FindObjectsOfTypeAll<BoxCollider>())
                {
                    boxCollider.enabled = false;
                }
            }
            else
            {
                foreach (Collider collider4 in UnityEngine.Object.FindObjectsOfType<MeshCollider>())
                {
                    collider4.enabled = true;
                }
                foreach (Collider collider5 in UnityEngine.Object.FindObjectsOfType<BoxCollider>())
                {
                    collider5.enabled = true;
                }
                foreach (Collider collider6 in UnityEngine.Object.FindObjectsOfType<SphereCollider>())
                {
                    collider6.enabled = true;
                }
                foreach (BoxCollider boxCollider2 in Resources.FindObjectsOfTypeAll<BoxCollider>())
                {
                    boxCollider2.enabled = true;
                }
            }
        }
    }
}
