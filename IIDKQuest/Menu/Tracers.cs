using Photon.Pun;
using System;
using UnityEngine;
using Object = UnityEngine.Object;

namespace IIDKQuest.Mods
{
    internal class Tracers
    {
        public static void TracerMod()
        {
            GameObject hand = GameObject.Find("RightHand Controller");
            if (hand == null) return;

            foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
            {
                if (vrrig == null || vrrig == GorillaTagger.Instance.offlineVRRig) continue;

                GameObject tracer = new GameObject("TracerLine");
                LineRenderer lineRenderer = tracer.AddComponent<LineRenderer>();

                // ✨ Use a better shader
                lineRenderer.material = new Material(Shader.Find("Sprites/Default"));

                // ✅ Animate color from red to black (pulse)
                float pulse = Mathf.PingPong(Time.time * 2f, 1f);
                Color startColor = Color.Lerp(Color.red, Color.black, pulse);
                Color endColor = new Color(0f, 0f, 0f, 0f); // Fade to transparent black

                Gradient gradient = new Gradient();
                gradient.SetKeys(
                    new GradientColorKey[] {
                        new GradientColorKey(startColor, 0f),
                        new GradientColorKey(endColor, 1f)
                    },
                    new GradientAlphaKey[] {
                        new GradientAlphaKey(1f, 0f),
                        new GradientAlphaKey(0f, 1f)
                    }
                );
                lineRenderer.colorGradient = gradient;

                // 📏 Size + taper
                lineRenderer.startWidth = 0.015f;
                lineRenderer.endWidth = 0.001f;
                lineRenderer.positionCount = 2;
                lineRenderer.numCapVertices = 4; // Smooth caps

                lineRenderer.SetPositions(new Vector3[]
                {
                    hand.transform.position,
                    vrrig.headMesh.transform.position
                });

                // 🕒 Destroy after short delay (0.1s for tracer effect)
                Object.Destroy(tracer, 0.1f);
            }
        }
    }
}
