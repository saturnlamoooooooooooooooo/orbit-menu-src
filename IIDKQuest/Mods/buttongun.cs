using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using GorillaLocomotion;
using easyInputs;

namespace IIDKQuest.Mods
{
    public class buttongun : MonoBehaviour
    {
        static GameObject pointer;
        static LineRenderer laser;

        public static void Buttonactivate()
        {
            if (!EasyInputs.GetGripButtonDown(EasyHand.RightHand))
            {
                if (pointer != null) Object.Destroy(pointer);
                if (laser != null) Object.Destroy(laser.gameObject);
                return;
            }

            Vector3 origin = GorillaLocomotion.Player.Instance.rightHandTransform.position;
            Vector3 direction = GorillaLocomotion.Player.Instance.rightHandTransform.position;

            if (Physics.Raycast(origin, direction, out RaycastHit hit))
            {
                if (pointer == null)
                {
                    pointer = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                    Object.Destroy(pointer.GetComponent<Rigidbody>());
                    Object.Destroy(pointer.GetComponent<Collider>());
                    pointer.transform.localScale = Vector3.one * 0.1f;
                    pointer.GetComponent<Renderer>().material.color = Color.black;
                }

                if (laser == null)
                {
                    GameObject laserObj = new GameObject("LaserBeam");
                    laser = laserObj.AddComponent<LineRenderer>();
                    laser.positionCount = 2;
                    laser.startWidth = 0.01f;
                    laser.endWidth = 0.01f;
                    laser.material = new Material(Shader.Find("Sprites/Default"));
                    laser.startColor = Color.red;
                    laser.endColor = Color.red;
                }

                pointer.transform.position = hit.point;
                laser.SetPosition(0, origin);
                laser.SetPosition(1, hit.point);

                if (EasyInputs.GetTriggerButtonDown(EasyHand.RightHand))
                {
                    for (int i = 0; i < 1; i++)
                    {
                        PhotonNetwork.Instantiate("gorillaprefabs/GorillaScoreBoard", hit.point, GorillaLocomotion.Player.Instance.leftHandTransform.rotation);
                    }
                }
            }
        }
    }
}