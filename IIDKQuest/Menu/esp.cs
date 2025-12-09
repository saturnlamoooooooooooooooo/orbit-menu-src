using System;
using System.Collections.Generic;
using UnityEngine;

namespace IIDKQuest.Mods
{
    internal class esp
    {
        // Tracks ESP state
        public static bool espEnabled = true;

        // CODED BY LUNAR SKIDZZZ
        private static Dictionary<Renderer, Material> originalMaterials = new Dictionary<Renderer, Material>();

        // Material used for my ESP effect
        public static Material ESP = new Material(Shader.Find("GUI/Text Shader"));

        // Call this every frame (like in Update) to apply animated chams
        public static void Chams()
        {
            espEnabled = true;

            // Flashing red/black animation
            float pulse = Mathf.PingPong(Time.time * 2f, 1f);
            Color flashColor = Color.Lerp(Color.red, Color.black, pulse);

            foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
            {
                if (vrrig == null || vrrig.isMyPlayer) continue;

                foreach (Renderer renderer in vrrig.GetComponentsInChildren<Renderer>())
                {
                    if (renderer == null) continue;

                    // Cache original material once
                    if (!originalMaterials.ContainsKey(renderer))
                    {
                        originalMaterials[renderer] = renderer.material;
                    }

                    // Apply ESP material + color
                    renderer.material = ESP;
                    renderer.material.color = flashColor;
                }
            }
        }

    
        public static void DestroyChams()
        {
            foreach (var kvp in originalMaterials)
            {
                if (kvp.Key != null)
                {
                    kvp.Key.material = kvp.Value;
                }
            }

            originalMaterials.Clear();
            espEnabled = false;
        }

        // Toggle method — can hook to button or hotkey
        public static void destroymethod()
        {
            if (espEnabled)
            {
                DestroyChams();
            }
        }
    }
}
