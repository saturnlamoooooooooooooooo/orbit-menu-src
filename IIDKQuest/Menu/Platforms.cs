
using UnityEngine;
using easyInputs;
using UnityEngine.EventSystems;
using GorillaLocomotion;

namespace IIDKQuest.Mods
{
    internal class Platforms
    {
        public static float platformCooldown;
        public static float platformCooldown2;
        public static GameObject rightHandPlatform;
        public static GameObject leftHandPlatform;

        public static void Platform()
        {
            bool gripButtonDown = EasyInputs.GetGripButtonDown(EasyHand.LeftHand);
            bool gripButtonDown2 = EasyInputs.GetGripButtonDown(EasyHand.RightHand);
            Color rgbColor = Color.Lerp(Color.red, Color.black, Mathf.PingPong(Time.time, 1f));

            Shader unlitShader = Shader.Find("Unlit/Color");

            if (rightHandPlatform != null)
            {
                Material mat = new Material(unlitShader);
                mat.color = rgbColor;
                rightHandPlatform.GetComponent<Renderer>().material = mat;
            }

            if (leftHandPlatform != null)
            {
                Material mat = new Material(unlitShader);
                mat.color = rgbColor;
                leftHandPlatform.GetComponent<Renderer>().material = mat;
            }

            if (platformCooldown == 0f && gripButtonDown2)
            {
                platformCooldown = 1f;
                rightHandPlatform = GameObject.CreatePrimitive(PrimitiveType.Cube);
                Material mat = new Material(unlitShader);
                mat.color = rgbColor;
                rightHandPlatform.GetComponent<Renderer>().material = mat;
                Object.Destroy(rightHandPlatform.GetComponent<Rigidbody>());
                rightHandPlatform.transform.localScale = new Vector3(0.0125f, 0.28f, 0.3825f);
                rightHandPlatform.transform.position = new Vector3(0f, -0.0075f, 0f) + GorillaTagger.Instance.rightHandTransform.position;
                rightHandPlatform.transform.rotation = GorillaTagger.Instance.rightHandTransform.rotation;
            }
            else if (platformCooldown == 1f && !gripButtonDown2)
            {
                platformCooldown = 0f;
                Object.DestroyImmediate(rightHandPlatform);
                rightHandPlatform = null;
            }

            if (platformCooldown2 == 0f && gripButtonDown)
            {
                platformCooldown2 = 1f;
                leftHandPlatform = GameObject.CreatePrimitive(PrimitiveType.Cube);
                Material mat = new Material(unlitShader);
                mat.color = rgbColor;
                leftHandPlatform.GetComponent<Renderer>().material = mat;
                Object.Destroy(leftHandPlatform.GetComponent<Rigidbody>());
                leftHandPlatform.transform.localScale = new Vector3(0.0125f, 0.28f, 0.3825f);
                leftHandPlatform.transform.position = new Vector3(0f, -0.0075f, 0f) + GorillaTagger.Instance.leftHandTransform.position;
                leftHandPlatform.transform.rotation = GorillaTagger.Instance.leftHandTransform.rotation;
            }
            else if (platformCooldown2 == 1f && !gripButtonDown)
            {
                platformCooldown2 = 0f;
                Object.DestroyImmediate(leftHandPlatform);
                leftHandPlatform = null;
            }
        }
    }
}