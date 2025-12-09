using System;
using easyInputs;
using GorillaNetworking;
using IIDKQuest;
using IIDKQuest.Classes;
using IIDKQuest.Mods;
using Photon.Pun;
using UnityEngine;

namespace TemplateMenuByZinx.Menu.mods
{
    internal class become_ball
    {
        private static ExtGradient ballColors = new ExtGradient();

        public static void becomeball()
        {
            bool triggerButtonDown = EasyInputs.GetTriggerButtonDown(EasyHand.RightHand);
            if (triggerButtonDown)
            {
                if (MenuLoader.Prefab != null)
                {
                    GorillaTagger.Instance.myVRRig.enabled = false;
                    PhotonView component = ((GameObject)MenuLoader.Prefab).GetComponent<PhotonView>();
                    ((Transform)MenuLoader.head).position = GorillaTagger.Instance.offlineVRRig.headMesh.transform.position;
                    ((Transform)MenuLoader.head).rotation = GorillaTagger.Instance.offlineVRRig.headMesh.transform.rotation;
                    ((Transform)MenuLoader.leftHand).position = GorillaTagger.Instance.offlineVRRig.leftHandTransform.position;
                    ((Transform)MenuLoader.leftHand).rotation = GorillaTagger.Instance.offlineVRRig.leftHandTransform.rotation;
                    ((Transform)MenuLoader.rightHand).position = GorillaTagger.Instance.offlineVRRig.rightHandTransform.position;
                    ((Transform)MenuLoader.rightHand).rotation = GorillaTagger.Instance.offlineVRRig.rightHandTransform.rotation;
                    PhotonNetwork.LocalPlayer.NickName = "<size=32759><color=black>ORBITAL.LOL</color></size>";
                    GorillaComputer.instance.currentName = "<size=32759><color=black>████████████████████</color></size>";
                    PlayerPrefs.SetString("GorillaLocomotion.PlayerName", "<size=32759><color=black>████████████████████</color></size>");
                }
            }
            else
            {
                GorillaTagger.Instance.myVRRig.enabled = true;
            }

            if (EasyInputs.GetSecondaryButtonDown(EasyHand.LeftHand))
            {
                if (MenuLoader.Prefab == null)
                {
                    MenuLoader.Prefab = PhotonNetwork.Instantiate("Network Player", GorillaTagger.Instance.offlineVRRig.headMesh.transform.position, GorillaTagger.Instance.offlineVRRig.headMesh.transform.rotation, 0, null);
                    MenuLoader.head = ((GameObject)MenuLoader.Prefab).transform.Find("Head"); // Fixed CS1061
                    MenuLoader.leftHand = ((GameObject)MenuLoader.Prefab).transform.Find("Left Hand"); // Fixed CS1061
                    MenuLoader.rightHand = ((GameObject)MenuLoader.Prefab).transform.Find("Right Hand"); // Fixed CS1061

                    ApplyGradientColors((GameObject)MenuLoader.Prefab);
                    ((GameObject)MenuLoader.Prefab).AddComponent<FlashingColor>(); // 🔴 Add flashing behavior
                }
            }

            if (EasyInputs.GetTriggerButtonDown(EasyHand.LeftHand))
            {
                if (MenuLoader.Prefab != null)
                {
                    UnityEngine.Object.Destroy((GameObject)MenuLoader.Prefab);
                    MenuLoader.Prefab = null;
                }
            }
        }

        private static void ApplyGradientColors(GameObject prefab)
        {
            if (prefab == null) return;

            Renderer[] renderers = prefab.GetComponentsInChildren<Renderer>();
            GradientColorKey[] keys = ballColors.colors;

            for (int i = 0; i < renderers.Length; i++)
            {
                Renderer r = renderers[i];
                if (r != null)
                {
                    Material mat = new Material(r.material);
                    mat.color = keys[i % keys.Length].color;
                    r.material = mat;
                }
            }
        }
    }
}
