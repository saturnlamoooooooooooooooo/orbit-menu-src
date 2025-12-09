using easyInputs;
using IIDKQuest;
using Photon.Pun;
using Photon.Realtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Animations.Rigging;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.HID;
using static UnityEngine.UI.GridLayoutGroup;

namespace EclipseX.Mods
{
    /*
     This menu has no skidded mods
     if you remove this it is skidding
     Dm LJ/owner if these any bug
     And this is a beta
     */
    internal class OverpoweredMods
    {
        private static GameObject GunSphere;  // the sphere object 
        private static LineRenderer lineRenderer;  // The lineRenderer 
        private static float timeCounter = 0f;  // just a timer for animations
        private static Vector3[] linePositions;  // stores positions
        private static Vector3 previousControllerPosition;  // stores previous positions
        public static void CrashAllV3()
        {
            if (EasyInputs.GetGripButtonDown((EasyHand)1))
            {
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
            }
        }
        public static void CrashAllV2()
        {
            if (EasyInputs.GetGripButtonDown((EasyHand)1))
            {
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
            }
        }
        public static void CrashAllV1()
        {
            if (EasyInputs.GetGripButtonDown((EasyHand)1))
            {
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
            }
        }
        public static GameObject pointer;
        public static GameObject beamLine;

        public static void CrashGunV1()
        {
           
            if (EasyInputs.GetGripButtonFloat(EasyHand.RightHand) > 0.1f || Mouse.current.rightButton.isPressed)
            {
                if (Physics.Raycast(
                        GorillaLocomotion.Player.Instance.rightHandTransform.position,
                        -GorillaLocomotion.Player.Instance.rightHandTransform.up, out var hitinfo))
                {
                    
                    if (Mouse.current.rightButton.isPressed)
                    {
                        Camera cam = GameObject.Find("Shoulder Camera").GetComponent<Camera>();
                        Ray ray = cam.ScreenPointToRay(Mouse.current.position.ReadValue());
                        Physics.Raycast(ray, out hitinfo, 100); // how far away from camera
                    }

                    if (GunSphere == null)
                    {
                        GunSphere = GameObject.CreatePrimitive(PrimitiveType.Sphere); 
                        GunSphere.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                        GunSphere.GetComponent<Renderer>().material.shader = Shader.Find("Standard");
                        GunSphere.GetComponent<Renderer>().material.color = Color.green; 

              
                        GameObject.Destroy(GunSphere.GetComponent<BoxCollider>());
                        GameObject.Destroy(GunSphere.GetComponent<Rigidbody>());
                        GameObject.Destroy(GunSphere.GetComponent<Collider>());

                        lineRenderer = GunSphere.AddComponent<LineRenderer>();
                        lineRenderer.material = new Material(Shader.Find("Sprites/Default"));
                        lineRenderer.widthCurve = AnimationCurve.Linear(0, 0.01f, 1, 0.01f);
                        lineRenderer.startColor = Color.black;
                        lineRenderer.endColor = Color.magenta;

                        linePositions = new Vector3[50];
                        for (int i = 0; i < linePositions.Length; i++)
                        {
                            linePositions[i] = GorillaLocomotion.Player.Instance.rightHandTransform.position; 
                        }
                    }

                    GunSphere.transform.position = hitinfo.point;

                    timeCounter += Time.deltaTime;

                    Vector3 pos1 = GorillaLocomotion.Player.Instance.rightHandTransform.position;
                    float distance = Vector3.Distance(pos1, hitinfo.point);  
                    previousControllerPosition = pos1;  

                    const float spiralTurns = 4f; 
                    const float maxAmplitude = 0.1f;  

                    for (int i = 0; i < linePositions.Length; i++)
                    {
                        float t = i / (float)(linePositions.Length - 1);  
                        Vector3 basePos = Vector3.Lerp(pos1, hitinfo.point, t);  
                        Vector3 forward = (hitinfo.point - pos1).normalized;  
                        Vector3 up = Vector3.up;
                        if (Mathf.Abs(Vector3.Dot(forward, up)) > 0.9f)
                        {
                            up = Vector3.right;
                        }
                        Vector3 right = Vector3.Cross(forward, up).normalized;
                        up = Vector3.Cross(right, forward).normalized;
                        float spiralAngle = t * 2f * (float)Math.PI * spiralTurns + timeCounter;
                        float spiralAmplitude = (1f - t) * maxAmplitude;
                        Vector3 offset = right * (Mathf.Cos(spiralAngle) * spiralAmplitude) +
                        up * (Mathf.Sin(spiralAngle) * spiralAmplitude);
                        Vector3 newPos = basePos + offset;  
                        linePositions[i] = Vector3.Lerp(linePositions[i], newPos, Time.deltaTime * 5f);  
                    }

            
                    if (EasyInputs.GetTriggerButtonFloat(EasyHand.RightHand) > 0.1f || Mouse.current.leftButton.isPressed)
                    {
         
                        PhotonView targetView = hitinfo.collider.GetComponentInParent<PhotonView>();
                        if (targetView != null)
                        {
                            Photon.Realtime.Player owner = targetView.Owner;

                            if (EasyInputs.GetTriggerButtonDown(EasyHand.RightHand))
                            {
                                pointer.GetComponent<Renderer>().material.color = Color.red;

                                if (owner != null && PhotonNetwork.IsMasterClient)
                                {
                                    for (int i = 0; i < 150; i++)
                                    {
                                        PhotonNetwork.DestroyPlayerObjects(owner);
                                        PhotonNetwork.DestroyPlayerObjects(owner);
                                        PhotonNetwork.DestroyPlayerObjects(owner);
                                        PhotonNetwork.DestroyPlayerObjects(owner);
                                        PhotonNetwork.DestroyPlayerObjects(owner);
                                        PhotonNetwork.DestroyPlayerObjects(owner);
                                    }
                                }

                                Utility.SetMaster();
                            }
                            else
                            {
                               GunSphere.GetComponent<Renderer>().material.color = Color.red;
                            }
                        }
                    }


                    lineRenderer.positionCount = linePositions.Length;
                    lineRenderer.SetPositions(linePositions);


                    float colorLerp = Mathf.PingPong(timeCounter, 1f);
                    Color lineColor = Color.Lerp(Color.black, Color.magenta, colorLerp);
                    lineRenderer.startColor = lineColor;
                    lineRenderer.endColor = lineColor;
                }
            }

            else if (GunSphere != null && (EasyInputs.GetGripButtonFloat(EasyHand.RightHand) <= 0.1f && !Mouse.current.rightButton.isPressed))
            {
                GameObject.Destroy(GunSphere);  
                GameObject.Destroy(lineRenderer);  
                timeCounter = 0f;  
                linePositions = null; 
            }
        }

        public static void CrashGunV2()
        {
            if (!EasyInputs.GetGripButtonDown(EasyHand.RightHand))
            {
                if (pointer != null) UnityEngine.Object.Destroy(pointer);
                if (beamLine != null) UnityEngine.Object.Destroy(beamLine);
                return;
            }

            Vector3 origin = GorillaLocomotion.Player.Instance.rightHandTransform.position;
            Vector3 direction = GorillaLocomotion.Player.Instance.rightHandTransform.forward;

            RaycastHit hit;

            if (Physics.Raycast(origin, direction, out hit, 50f))
            {
                if (pointer == null)
                {
                    pointer = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                    UnityEngine.Object.Destroy(pointer.GetComponent<Rigidbody>());
                    UnityEngine.Object.Destroy(pointer.GetComponent<SphereCollider>());
                    pointer.transform.localScale = Vector3.one * 0.067f;
                    pointer.GetComponent<Renderer>().material.color = Color.red;
                }

                if (beamLine == null)
                {
                    beamLine = new GameObject("BeamLine");
                    LineRenderer lr = beamLine.AddComponent<LineRenderer>();
                    lr.startWidth = 0.01f;
                    lr.endWidth = 0.01f;
                    lr.material = new Material(Shader.Find("Sprites/Default"));
                    lr.startColor = Color.red;
                    lr.endColor = Color.red;
                }

                pointer.transform.position = hit.point;

                LineRenderer lineRenderer = beamLine.GetComponent<LineRenderer>();
                lineRenderer.SetPosition(0, origin);
                lineRenderer.SetPosition(1, pointer.transform.position);

                PhotonView targetView = hit.collider.GetComponentInParent<PhotonView>();
                if (targetView != null)
                {
                    Photon.Realtime.Player owner = targetView.Owner;

                    if (EasyInputs.GetTriggerButtonDown(EasyHand.RightHand))
                    {
                        pointer.GetComponent<Renderer>().material.color = Color.red;

                        if (owner != null && PhotonNetwork.IsMasterClient)
                        {
                            for (int i = 0; i < 150; i++)
                            {
                                PhotonNetwork.DestroyPlayerObjects(owner);
                                PhotonNetwork.DestroyPlayerObjects(owner);
                                PhotonNetwork.DestroyPlayerObjects(owner);
                                PhotonNetwork.DestroyPlayerObjects(owner);
                                PhotonNetwork.DestroyPlayerObjects(owner);
                                PhotonNetwork.DestroyPlayerObjects(owner);
                            }
                        }

                        Utility.SetMaster();
                    }
                    else
                    {
                        pointer.GetComponent<Renderer>().material.color = Color.red;
                    }
                }
            }
        }
        private class targetView
        {
            public static Player Owner { get; internal set; }
        }
        public static void CrashGunV3()
        {
            if (!EasyInputs.GetGripButtonDown(EasyHand.RightHand))
            {
                if (pointer != null) UnityEngine.Object.Destroy(pointer);
                if (beamLine != null) UnityEngine.Object.Destroy(beamLine);
                return;
            }

            Vector3 origin = GorillaLocomotion.Player.Instance.rightHandTransform.position;
            Vector3 direction = GorillaLocomotion.Player.Instance.rightHandTransform.forward;

            RaycastHit hit;

            if (Physics.Raycast(origin, direction, out hit, 50f))
            {
                if (pointer == null)
                {
                    pointer = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                    UnityEngine.Object.Destroy(pointer.GetComponent<Rigidbody>());
                    UnityEngine.Object.Destroy(pointer.GetComponent<SphereCollider>());
                    pointer.transform.localScale = Vector3.one * 0.067f;
                    pointer.GetComponent<Renderer>().material.color = Color.magenta;
                }

                if (beamLine == null)
                {
                    beamLine = new GameObject("BeamLine");
                    LineRenderer lr = beamLine.AddComponent<LineRenderer>();
                    lr.startWidth = 0.01f;
                    lr.endWidth = 0.01f;
                    lr.material = new Material(Shader.Find("Sprites/Default"));
                    lr.startColor = Color.magenta;
                    lr.endColor = Color.magenta;
                }

                pointer.transform.position = hit.point;

                LineRenderer lineRenderer = beamLine.GetComponent<LineRenderer>();
                lineRenderer.SetPosition(0, origin);
                lineRenderer.SetPosition(1, pointer.transform.position);

                PhotonView targetView = hit.collider.GetComponentInParent<PhotonView>();
                if (targetView != null)
                {
                    Photon.Realtime.Player owner = targetView.Owner;

                    if (EasyInputs.GetTriggerButtonDown(EasyHand.RightHand))
                    {
                        pointer.GetComponent<Renderer>().material.color = Color.magenta;

                        if (owner != null && PhotonNetwork.IsMasterClient)
                        {
                            for (int i = 0; i < 150; i++)
                            {
                                PhotonNetwork.DestroyPlayerObjects(owner);
                                PhotonNetwork.DestroyPlayerObjects(owner);
                                PhotonNetwork.DestroyPlayerObjects(owner);
                                PhotonNetwork.DestroyPlayerObjects(owner);
                                PhotonNetwork.DestroyPlayerObjects(owner);
                                PhotonNetwork.DestroyPlayerObjects(owner);
                                PhotonNetwork.DestroyPlayerObjects(owner);
                                PhotonNetwork.DestroyPlayerObjects(owner);
                                PhotonNetwork.DestroyPlayerObjects(owner);
                                PhotonNetwork.DestroyPlayerObjects(owner);
                                PhotonNetwork.DestroyPlayerObjects(owner);
                                PhotonNetwork.DestroyPlayerObjects(owner);
                                PhotonNetwork.DestroyPlayerObjects(owner);
                                PhotonNetwork.DestroyPlayerObjects(owner);
                                PhotonNetwork.DestroyPlayerObjects(owner);
                                PhotonNetwork.DestroyPlayerObjects(owner);
                                PhotonNetwork.DestroyPlayerObjects(owner);
                                PhotonNetwork.DestroyPlayerObjects(owner);

                            }
                        }

                        Utility.SetMaster();
                    }
                    else
                    {
                        pointer.GetComponent<Renderer>().material.color = Color.magenta;
                    }
                }
            }
        }
    }
}
