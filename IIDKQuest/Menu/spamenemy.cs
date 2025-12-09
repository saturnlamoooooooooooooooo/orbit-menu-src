using System;
using easyInputs;
using GorillaLocomotion;
using Photon.Pun;
using UnityEngine;

namespace IIDKQuest.Mods
{
    internal class spamenemy
    {
        public static void EnemySpam()
        {
            if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
            {
                GameObject enemy = PhotonNetwork.Instantiate("gorillaprefabs/gorillaenemy", Player.Instance.rightHandTransform.position, Player.Instance.rightHandTransform.rotation, 0, null);
                SetEnemyColor(enemy, Color.yellow);
            }
            if (EasyInputs.GetGripButtonDown(EasyHand.LeftHand))
            {
                GameObject enemy = PhotonNetwork.Instantiate("gorillaprefabs/gorillaenemy", Player.Instance.leftHandTransform.position, Player.Instance.leftHandTransform.rotation, 0, null);
                SetEnemyColor(enemy, Color.yellow);
            }
        }

        private static void SetEnemyColor(GameObject enemy, Color color)
        {
            Renderer renderer = enemy.GetComponent<Renderer>();
            if (renderer != null)
            {
                renderer.material.color = color;
            }
            else
            {
                Renderer[] childRenderers = enemy.GetComponentsInChildren<Renderer>();
                foreach (Renderer child in childRenderers)
                {
                    child.material.color = color;
                }
            }
        }
    }
}
