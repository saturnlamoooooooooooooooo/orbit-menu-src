using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using easyInputs;
using GorillaLocomotion;
using Photon.Pun;
using UnityEngine;

namespace IIDKQuest.Mods
{
    internal class KickMods
    {
        private static LineRenderer spring;
        private const int coilResolution = 120;
        private const float radius = 0.05f;
        private static float animationSpeed = 5f;
        private static int coilsMin = 3;
        private static int coilsMax = 10;

        public static void kickal() 
        {
            if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
            {
                _ = PhotonNetwork.EnableCloseConnection;
            }
        }
        public static void kickgun()
        {
            void Update()
            {
                if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
                {
                    PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate(); PhotonNetwork.EnableCloseConnection = true; // <-- this line added
                    Activate();
                    Activate();
                }
            }
        }


        public static void Activate()
        {
            Vector3 origin = Player.Instance.rightHandTransform.position;
            Vector3 direction = Player.Instance.rightHandTransform.forward;

            if (Physics.Raycast(origin, direction, out RaycastHit hit))
            {
                if (spring == null)
                {
                    GameObject obj = new GameObject("AnimatedSpring");
                    spring = obj.AddComponent<LineRenderer>();
                    spring.material = new Material(Shader.Find("Sprites/Default"));
                    spring.startWidth = 0.02f;
                    spring.endWidth = 0.02f;
                    spring.positionCount = coilResolution;
                    spring.startColor = Color.cyan;
                    spring.endColor = Color.magenta;
                }

                Vector3 end = hit.point;
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
                    GameObject.Destroy(spring.gameObject);
            }
        }
    }
}

