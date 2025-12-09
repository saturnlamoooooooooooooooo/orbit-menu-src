using System;
using easyInputs;
using Photon.Pun;
using UnityEngine;

namespace IIDKQuest.Mods
{
    internal class poop
    {
        public static void Poop()
        {
            // Adjust base position to approximate "butt" area: lower and slightly behind
            Vector3 basePosition = GorillaTagger.Instance.myVRRig.transform.position
                                   + new Vector3(0f, 0.6f, -0.2f); // Lower & behind

            // Rotate it backwards relative to body rotation
            Quaternion rotation = GorillaTagger.Instance.myVRRig.transform.rotation
                                  * Quaternion.Euler(0f, 180f, 0f); // Pointing backward

            float[] distances = { 0.5f, 1f, 1.5f, 2f, 2.5f, 3f };
            foreach (float dist in distances)
            {
                Vector3 spawnPos = basePosition
                                   + GorillaTagger.Instance.myVRRig.transform.forward.normalized * -dist;

                // Instantiate the poop prefab using PhotonNetwork
                GameObject poop = PhotonNetwork.Instantiate("bulletPrefab", spawnPos, rotation, 0);

                // Set poop color to brown
                Renderer poopRenderer = poop.GetComponent<Renderer>();
                if (poopRenderer != null)
                {
                    poopRenderer.material.color = new Color(0.36f, 0.25f, 0.2f); // Dark brown
                }
                else
                {
                    Renderer childRenderer = poop.GetComponentInChildren<Renderer>();
                    if (childRenderer != null)
                    {
                        childRenderer.material.color = new Color(0.36f, 0.25f, 0.2f); // Dark brown
                    }
                }
            }
        }
    }
}
