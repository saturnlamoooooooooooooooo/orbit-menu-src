using UnityEngine;
using System.Collections.Generic;
using easyInputs;

namespace IIDKQuest.Mods
{
    internal class ghostmonkey
    {
        private static Material espMaterial;
        private static bool ghostActive = false;
        private static float flashTimer = 0f;
        private static bool flashRed = true;
        private static GameObject ghostRig;

        private static Transform ghostHead, ghostLeftHand, ghostRightHand, ghostBody;
        private static Transform realHead, realLeftHand, realRightHand, realBody;

        public static void GhostMonkey()
        {
            if (EasyInputs.GetSecondaryButtonDown(EasyHand.RightHand))
            {
                ghostActive = !ghostActive;
                if (ghostActive) SpawnGhostRig();
                else RemoveGhostRig();
            }

            if (!ghostActive || ghostRig == null) return;

            flashTimer += Time.deltaTime;
            if (flashTimer > 0.5f)
            {
                flashTimer = 0f;
                flashRed = !flashRed;
                Color flashColor = flashRed ? Color.red : Color.black;
                foreach (var r in ghostRig.GetComponentsInChildren<Renderer>())
                    if (r) r.material.color = flashColor;
            }

            if (realHead && ghostHead) ghostHead.SetPositionAndRotation(realHead.position, realHead.rotation);
            if (realLeftHand && ghostLeftHand) ghostLeftHand.SetPositionAndRotation(realLeftHand.position, realLeftHand.rotation);
            if (realRightHand && ghostRightHand) ghostRightHand.SetPositionAndRotation(realRightHand.position, realRightHand.rotation);
            if (realBody && ghostBody) ghostBody.SetPositionAndRotation(realBody.position, realBody.rotation);
        }

        private static void SpawnGhostRig()
        {
            var realRigGO = GorillaTagger.Instance?.myVRRig?.gameObject;
            if (!realRigGO)
            {
                Debug.LogError("[ghostmonkey] Cannot find real VR rig! Aborting spawn.");
                ghostActive = false;
                return;
            }

            SetupEspMaterial();

            ghostRig = Object.Instantiate(realRigGO);
            Object.DontDestroyOnLoad(ghostRig);
            ghostRig.name = "GhostMonkeyClone";

            foreach (var mb in ghostRig.GetComponentsInChildren<MonoBehaviour>())
                if (!(mb is Transform)) Object.Destroy(mb);

            foreach (var rend in ghostRig.GetComponentsInChildren<Renderer>())
                if (rend)
                {
                    rend.material = new Material(espMaterial);
                    rend.material.color = Color.red;
                }

            System.Func<GameObject, string, Transform> findBone = (root, path) =>
            {
                var t = root.transform.Find(path);
                if (!t) Debug.LogWarning($"[ghostmonkey] Bone missing: {path}");
                return t;
            };

            ghostHead = findBone(ghostRig, "rig/CameraContainer/CameraOffset/MainCamera");
            realHead = findBone(realRigGO, "rig/CameraContainer/CameraOffset/MainCamera");
            ghostLeftHand = findBone(ghostRig, "rig/ShoulderL/UpperArmL/LowerArmL/HandL");
            realLeftHand = findBone(realRigGO, "rig/ShoulderL/UpperArmL/LowerArmL/HandL");
            ghostRightHand = findBone(ghostRig, "rig/ShoulderR/UpperArmR/LowerArmR/HandR");
            realRightHand = findBone(realRigGO, "rig/ShoulderR/UpperArmR/LowerArmR/HandR");
            ghostBody = findBone(ghostRig, "rig");
            realBody = findBone(realRigGO, "rig");

            SetOriginalRigVisible(false);

        }

        private static void SetupEspMaterial()
        {
            if (espMaterial) return;
            espMaterial = new Material(Shader.Find("Standard"));
            espMaterial.SetFloat("_Mode", 3);
            espMaterial.SetInt("_SrcBlend", (int)UnityEngine.Rendering.BlendMode.SrcAlpha);
            espMaterial.SetInt("_DstBlend", (int)UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha);
            espMaterial.SetInt("_ZWrite", 0);
            espMaterial.DisableKeyword("_ALPHATEST_ON");
            espMaterial.EnableKeyword("_ALPHABLEND_ON");
            espMaterial.DisableKeyword("_ALPHAPREMULTIPLY_ON");
            espMaterial.renderQueue = 3000;
        }

        private static void RemoveGhostRig()
        {
            if (ghostRig) Object.Destroy(ghostRig);
            ghostRig = null;
            SetOriginalRigVisible(true);
        
        }

        private static void SetOriginalRigVisible(bool visible)
        {
            var rig = GorillaTagger.Instance?.myVRRig;
            if (!rig) return;

            foreach (var r in rig.GetComponentsInChildren<Renderer>())
                if (r) r.enabled = visible;
        }
    }
}
