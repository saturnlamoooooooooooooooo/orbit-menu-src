using System;
using easyInputs;
using Photon.Pun;
using UnityEngine;

namespace IIDKQuest.Mods
{
    // This script makes the object pulse red and black colors over time
    public class RedBlackPulse : MonoBehaviour
    {
        private Renderer rend;

        private void Start()
        {
            rend = GetComponent<Renderer>();
            if (rend == null)
            {
                rend = GetComponentInChildren<Renderer>();
            }
        }

        private void Update()
        {
            if (rend != null)
            {
                // Pulse value between 0 and 1 over time
                float pulse = Mathf.PingPong(Time.time * 3f, 1f);
                // Interpolate between red and black colors
                Color color = Color.Lerp(Color.red, Color.black, pulse);
                rend.material.color = color;
            }
        }
    }

    internal class cuberain
    {
        public static void Cuberain()
        {
            bool primaryButtonDown = EasyInputs.GetPrimaryButtonDown(EasyHand.LeftHand);
            if (primaryButtonDown)
            {
                PhotonNetwork.DestroyPlayerObjects(PhotonNetwork.LocalPlayer);
            }

            Vector3 basePosition = GorillaTagger.Instance.myVRRig.transform.position + new Vector3(0f, 10f, 0f);
            Quaternion rotation = GorillaTagger.Instance.myVRRig.transform.rotation * Quaternion.Euler(0f, 90f, 0f);

            for (int i = 0; i < 6; i++)
            {
                Vector3 spawnPos = basePosition + GorillaTagger.Instance.myVRRig.transform.up.normalized * (i * 0.5f);

                GameObject cube = PhotonNetwork.Instantiate("bulletPrefab", spawnPos, rotation, 0, null);

                // Add the pulsing red/black color effect to each spawned cube
                cube.AddComponent<RedBlackPulse>();
            }
        }
    }
}
