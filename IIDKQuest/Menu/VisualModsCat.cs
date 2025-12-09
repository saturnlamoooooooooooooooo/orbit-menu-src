using System;
using System.Collections.Generic;
using UnityEngine;

namespace IIDKQuest.Mods
{
    public class ESPBoxDrawer : MonoBehaviour
    {
        private Camera mainCam;
        private Color currentColor;
        private float pulseSpeed = 2f;
        public void ok()
        {
            
            Debug.Log("Just using the void i dont use debuglog for nun");
        }

        void Start()
        {
            mainCam = Camera.main;
        }

        void OnGUI()
        {
            if (mainCam == null) return;

            float t = Mathf.PingPong(Time.time * pulseSpeed, 1f);
            currentColor = Color.Lerp(Color.black, Color.red, t);

            foreach (VRRig vrrig in FindObjectsOfType<VRRig>())
            {
                if (vrrig == null || vrrig.headMesh == null) continue;

                Vector3 worldPos = vrrig.headMesh.transform.position;
                Vector3 screenPos = mainCam.WorldToScreenPoint(worldPos);

                if (screenPos.z > 0)
                {
                    // Draw a simple 2D box slightly above their head
                    float boxWidth = 80;
                    float boxHeight = 120;
                    float x = screenPos.x - boxWidth / 2;
                    float y = Screen.height - screenPos.y - boxHeight / 2;

                    DrawBox(new Rect(x, y, boxWidth, boxHeight), currentColor);
                }
            }
        }

        public void DrawBox(Rect rect, Color color)
        {
            Color originalColor = GUI.color;
            GUI.color = color;
            GUI.DrawTexture(new Rect(rect.x, rect.y, rect.width, 1), Texture2D.whiteTexture); // Top
            GUI.DrawTexture(new Rect(rect.x, rect.y + rect.height, rect.width, 1), Texture2D.whiteTexture); // Bottom
            GUI.DrawTexture(new Rect(rect.x, rect.y, 1, rect.height), Texture2D.whiteTexture); // Left
            GUI.DrawTexture(new Rect(rect.x + rect.width, rect.y, 1, rect.height), Texture2D.whiteTexture); // Right
            GUI.color = originalColor;
        }

        internal static void DrawBox()
        {
            throw new NotImplementedException();
        }
    }
}
