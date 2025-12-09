using System;
using UnityEngine;
using TMPro; // Needed for TextMeshPro

namespace IIDKQuest.Mods
{
    internal class Custom
    {
        // 🧠 Easy to modify text here
        private static string customComputerText = "<color=yellow><size=10>🍌 OrbitOS v1.0</size>\nWelcome to the Solar</color>";

        public static void OrbitOS()
        {
            // Find the stump computer GameObject
            GameObject computer = GameObject.Find("Environment Objects/LocalObjects_Prefab/TreeRoom/ComputerUI");

            if (computer != null)
            {
                computer.SetActive(true);

                // Try to get a TextMeshPro component from the children
                TextMeshProUGUI[] textComponents = computer.GetComponentsInChildren<TextMeshProUGUI>(true);

                foreach (var text in textComponents)
                {
                   
                    text.text = customComputerText;
                }

               
            }
            
        }
    }
}
