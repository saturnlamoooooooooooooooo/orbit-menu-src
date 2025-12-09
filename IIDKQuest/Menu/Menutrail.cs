using System;   
using UnityEngine;

namespace IIDKQuest.Mods
{
    
    public class MenuHalo : MonoBehaviour
    {
        public int segments = 100;              // Smoothness of the ring
        public float baseRadius = 0.2f;         // Base radius of the halo
        public float pulseAmplitude = 0.05f;    // How much it pulses
        public float pulseSpeed = 2f;           // Speed of pulsing
        public float spinSpeed = 50f;           // Degrees per second spin

        private LineRenderer halo;
        private Transform menuTransform;
        public static void HideMenuHalo()
        {
            MenuHalo halo = GameObject.FindObjectOfType<MenuHalo>();
            if (halo != null)
            {
                halo.gameObject.SetActive(true);
            }
        }
        void Start()
        {
            halo = gameObject.AddComponent<LineRenderer>();
            halo.positionCount = segments + 1;
            halo.loop = true;
            halo.widthMultiplier = 0.01f;
            halo.material = new Material(Shader.Find("Sprites/Default"));


            Color rgbColor = Color.Lerp(Color.red, Color.black, Mathf.PingPong(Time.time, 1f));



        }

        void Update()
        {
            // Follow the menu position
            if (menuTransform != null)
                transform.position = menuTransform.position;

            // Rotate the halo
            transform.Rotate(Vector3.up, spinSpeed * Time.deltaTime);

            // Pulsing radius (sin wave)
            float pulse = baseRadius + Mathf.Sin(Time.time * pulseSpeed) * pulseAmplitude;

            // Draw circle points
            for (int i = 0; i <= segments; i++)
            {
                const float Deg2Rad = (float)(Math.PI / 180.0);

                float angle = i * Deg2Rad * 360f / segments;





                float x = Mathf.Cos(angle) * pulse;
                float z = Mathf.Sin(angle) * pulse; // Use XZ plane for horizontal ring
                halo.SetPosition(i, new Vector3(x, 0, z));
            }

            // Smoothly lerp halo colors between cyan and magenta for a subtle effect
            float t = (Mathf.Sin(Time.time * 2f) + 1f) / 2f;
            Color color = Color.Lerp(Color.cyan, Color.magenta, t);
            halo.startColor = color;
            halo.endColor = color;
        }
    }

    internal class RequireComponentAttribute : Attribute
    {
    }
}
