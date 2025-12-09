using System;
using TMPro;
using UnityEngine;

namespace IIDKQuest.Mods
{
    internal class bananaOS
    {
        private static GameObject bananaOSObject;
        private static TextMeshPro textMesh;

        /// <summary>
        /// Activates the BananaOS object and optionally sets initial text.
        /// </summary>
        public static void GiveBananaOS(string initialText = "Welcome to OrbitalOS Watch")
        {
            bananaOSObject = GameObject.Find("OfflineVRRig/Actual Gorilla/rig/body/shoulder.L/upper_arm.L/forearm.L/hand.L/bananaoswatch");

         

            bananaOSObject.SetActive(true);

            textMesh = bananaOSObject.GetComponentInChildren<TextMeshPro>();
            if (textMesh == null)
            {
                GameObject textGO = new GameObject("Orbital.lol");
                textGO.transform.SetParent(bananaOSObject.transform);
                textGO.transform.localPosition = Vector3.zero;
                textGO.transform.localRotation = Quaternion.identity;
                textGO.transform.localScale = Vector3.one * 0.01f;

                textMesh = textGO.AddComponent<TextMeshPro>();
                textMesh.alignment = TextAlignmentOptions.Center;
                textMesh.fontSize = 2f;
                textMesh.color = Color.green;
            }

            SetText(initialText);
        }

       
        public static void SetText(string newText)
        {
            if (textMesh != null)
            {
                textMesh.text = newText;
            }
           
        }

       
        public static void HideBananaOS()
        {
            if (bananaOSObject != null)
            {
                bananaOSObject.SetActive(false);
            }
        }
    }
}
