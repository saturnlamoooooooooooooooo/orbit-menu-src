using System;
using easyInputs;
using Photon.Pun;
using UnityEngine;

namespace IIDKQuest.Mods
{
    internal class pee
    {
        public static void Piss()
        {
            Vector3 basePosition = GorillaTagger.Instance.myVRRig.transform.position + new Vector3(0f, 1.1f, 0f);
            Quaternion rotation = GorillaTagger.Instance.myVRRig.transform.rotation * Quaternion.Euler(0f, 90f, 0f);

            float[] distances = { 0.5f, 1f, 1.5f, 2f, 2.5f, 3f };
            foreach (float dist in distances)
            {
                Vector3 spawnPos = basePosition + GorillaTagger.Instance.myVRRig.transform.forward.normalized * dist;

                // Instantiate the bullet prefab using PhotonNetwork
                GameObject bullet = PhotonNetwork.Instantiate("bulletPrefab", spawnPos, rotation, 0);

                // Set bullet color to yellow
                Renderer bulletRenderer = bullet.GetComponent<Renderer>();
                if (bulletRenderer != null)
                {
                    bulletRenderer.material.color = Color.yellow;
                }
                else
                {
                    // If the bullet prefab has child objects with renderers, optionally:
                    Renderer childRenderer = bullet.GetComponentInChildren<Renderer>();
                    if (childRenderer != null)
                    {
                        childRenderer.material.color = Color.yellow;
                    }
                }
            }
        }
    }
}
