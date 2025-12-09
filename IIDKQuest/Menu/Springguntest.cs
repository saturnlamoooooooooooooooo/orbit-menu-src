using UnityEngine;
using easyInputs;
using GorillaLocomotion;
using Photon.Pun; // Make sure you have this if using Photon

namespace IIDKQuest.Mods
{
    public class SpringGun : MonoBehaviour
    {
        private static LineRenderer spring;
        private const int coilResolution = 120;
        private const float radius = 0.05f;
        private static float animationSpeed = 5f;
        private static int coilsMin = 3;
        private static int coilsMax = 10;

        // Change the type of tipMarker from 'object' to 'GameObject' to fix the error
        public static GameObject tipMarker { get; private set; }

        void Update()
        {
            if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
            {
                Activate();
            }
        }

        public static void Activate()
        {
            Vector3 origin = Player.Instance.rightHandTransform.position;
            Vector3 direction = Player.Instance.rightHandTransform.forward;

            if (Physics.Raycast(origin, direction, out RaycastHit hit))
            {
                Vector3 end = hit.point;

                // Create the spring if not yet made
                if (spring == null)
                {
                    GameObject springObj = new GameObject("AnimatedSpring");
                    spring = springObj.AddComponent<LineRenderer>();
                    spring.material = new Material(Shader.Find("Sprites/Default")); // Simple shader that supports color
                    spring.startWidth = 0.02f;
                    spring.endWidth = 0.02f;
                    spring.positionCount = coilResolution;
                }

                // ✨ Animate spring color from red to black
                float pulse = Mathf.PingPong(Time.time * 2f, 1f); // Pulse speed
                Color pulseColor = Color.Lerp(Color.black, Color.red, pulse);
                spring.material.color = pulseColor;

                // Create or move tip marker
                if (tipMarker == null)
                {
                    tipMarker = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                    tipMarker.name = "SpringTipMarker";
                    tipMarker.transform.localScale = Vector3.one * 0.1f;
                    var renderer = tipMarker.GetComponent<Renderer>();
                    renderer.material = new Material(Shader.Find("Unlit/Color"));
                    renderer.material.color = Color.red;
                }

                tipMarker.transform.position = end;

                float distance = Vector3.Distance(origin, end);
                Vector3 forward = (end - origin).normalized;
                Vector3 up = Vector3.up;

                if (Vector3.Dot(forward, up) > 0.9f)
                    up = Vector3.right;

                Vector3 right = Vector3.Cross(forward, up).normalized;
                up = Vector3.Cross(right, forward).normalized;

                float tOffset = Time.time * animationSpeed;
                int coils = Mathf.RoundToInt(Mathf.Lerp(coilsMin, coilsMax, distance / 8f));

                for (int i = 0; i < coilResolution; i++)
                {
                    float t = (float)i / (coilResolution - 1);
                    float angle = t * coils * 2f * 3.1415927f + tOffset;

                    Vector3 offset = (Mathf.Cos(angle) * right + Mathf.Sin(angle) * up) * radius;
                    Vector3 point = Vector3.Lerp(origin, end, t) + offset;
                    spring.SetPosition(i, point);
                }
            }
            else
            {
                if (spring != null)
                {
                    GameObject.Destroy(spring.gameObject);
                    spring = null;
                }

                if (tipMarker != null)
                {
                    GameObject.Destroy(tipMarker);
                    tipMarker = null;
                }
            }
        }
    }
}
