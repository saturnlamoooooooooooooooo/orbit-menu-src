using System;
using easyInputs;
using GorillaLocomotion;
using Photon.Pun;
using UnityEngine;

namespace IIDKQuest.Mods
{
    internal class spamenemyredandblack
    {
        public static void EnemySpam()
        {
            if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
            {
                GameObject enemy = PhotonNetwork.Instantiate("gorillaprefabs/gorillaenemy", Player.Instance.rightHandTransform.position, Player.Instance.rightHandTransform.rotation, 0, null);
                enemy.AddComponent<FlashingColor>();
            }

            if (EasyInputs.GetGripButtonDown(EasyHand.LeftHand))
            {
                GameObject enemy = PhotonNetwork.Instantiate("gorillaprefabs/gorillaenemy", Player.Instance.leftHandTransform.position, Player.Instance.leftHandTransform.rotation, 0, null);
                enemy.AddComponent<FlashingColor>();
            }
        }
    }

    public class FlashingColor : MonoBehaviour
    {
        private Renderer[] renderers;

        private void Start()
        {
            // Get all renderers in this object and its children
            renderers = GetComponentsInChildren<Renderer>();

            // Use an unlit shader so the color is always fully visible
            foreach (var r in renderers)
            {
                if (r.material != null)
                {
                    r.material.shader = Shader.Find("Unlit/Color");
                }
            }
        }

        private void Update()
        {
            // Pulse between red and black
            float t = Mathf.PingPong(Time.time * 4f, 1f);
            Color pulseColor = Color.Lerp(Color.red, Color.black, t);

            foreach (var r in renderers)
            {
                if (r != null && r.material != null)
                {
                    r.material.color = pulseColor;
                }
            }
        }
    }
}
