using easyInputs;
using GorillaNetworking;
using Il2CppSystem.Numerics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace EclipseX.Mods
{
    /*
     This menu has no skidded mods
     if you remove this it is skidding
     Dm LJ/owner if these any bug
     And this is a beta
     Mods i need to work - Platforms/MovementMods and thats it
     */
    internal class MovementMods
    {
        #region checkpount
        public static GameObject tspmo;
        public static Vector3 tspmopos;
        #endregion checkpount
        public static void NoClip()
        {
            if (EasyInputs.GetTriggerButtonDown((EasyHand)1))
            {
                foreach (MeshCollider item in UnityEngine.Object.FindObjectsOfType<MeshCollider>())
                {
                    ((Collider)item).enabled = false;
                }
                return;
            }
            foreach (MeshCollider item2 in UnityEngine.Object.FindObjectsOfType<MeshCollider>())
            {
                ((Collider)item2).enabled = true;
            }
        }
        public static void ReverseGravity()
        {
            GorillaLocomotion.Player.Instance.playerRigidBody.velocity = new Vector3(0f, 50f, 0f);
        }

        public static void NoGravity()
        {
            GorillaLocomotion.Player.Instance.playerRigidBody.useGravity = false;
        }

        public static void FixGravity()
        {
            GorillaLocomotion.Player.Instance.playerRigidBody.useGravity = true;
        }
        public static void HighGravity()
        {
            GorillaLocomotion.Player.Instance.playerRigidBody.velocity = new Vector3(0f, -50f, 0f);
        }
        public static void BreakGravity()
        {
            GorillaLocomotion.Player.Instance.playerRigidBody.velocity = new Vector3(0f, 0f, 0f);
        }
        public static void GripNoGravity()
        {
            if (EasyInputs.GetGripButtonDown((EasyHand)1))
            {
                GorillaLocomotion.Player.Instance.playerRigidBody.velocity = new Vector3(0f, 50f, 0f);
            }
        }
        public static void GripReverseGravity()
        {
            if (EasyInputs.GetGripButtonDown((EasyHand)1))
            {
                GorillaLocomotion.Player.Instance.playerRigidBody.useGravity = false;
            }
        }
        public static void GripHighGravity()
        {
            if (EasyInputs.GetGripButtonDown((EasyHand)1))
            {
                GorillaLocomotion.Player.Instance.playerRigidBody.velocity = new Vector3(0f, -50f, 0f);
            }
        }
        public static void GripBreakGravity()
        {
            if (EasyInputs.GetGripButtonDown((EasyHand)1))
            {
                GorillaLocomotion.Player.Instance.playerRigidBody.velocity = new Vector3(0f, 0f, 0f);
            }
        }
        public static void GripSpeedBoost()
        {
            if (EasyInputs.GetGripButtonDown((EasyHand)1))
            {
                GorillaLocomotion.Player.Instance.jumpMultiplier = 4; GorillaLocomotion.Player.Instance.maxJumpSpeed = 4;
            }
        }
        public static void GripMosaBoost()
        {
            if (EasyInputs.GetGripButtonDown((EasyHand)1))
            {
                GorillaLocomotion.Player.Instance.jumpMultiplier = 2; GorillaLocomotion.Player.Instance.maxJumpSpeed = 2;
            }
        }
        public static void GripUncapMaxVelocity()
        {
            if (EasyInputs.GetGripButtonDown((EasyHand)1))
            {
                GorillaLocomotion.Player.Instance.jumpMultiplier = 1E+14f; GorillaLocomotion.Player.Instance.maxJumpSpeed = 1E+14f;
            }
        }
        public static void LongArms()
        {
            ((Component)GorillaLocomotion.Player.Instance).transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
        }
        public static void FixArms()
        {
            ((Component)GorillaLocomotion.Player.Instance).transform.localScale = new Vector3(1f, 1f, 1f);
        }
        public static void UncapMaxVelocity()
        {
            GorillaLocomotion.Player.Instance.jumpMultiplier = 1E+14f; GorillaLocomotion.Player.Instance.maxJumpSpeed = 1E+14f;
        }
        

        // Credits to jx for this
        public static void Turning()
        {
            if (EasyInputs.GetThumbStickButtonTouched(EasyHand.RightHand))
            {
                GorillaLocomotion.Player.Instance.Turn(EasyInputs.GetThumbStick2DAxis(EasyHand.RightHand).x * GorillaComputer.instance.turnValue);
                GorillaLocomotion.Player.Instance.disableMovement = false;
            }
        }
        public static void MosaBoost()
        {
            GorillaLocomotion.Player.Instance.jumpMultiplier = 2; GorillaLocomotion.Player.Instance.maxJumpSpeed = 2;
        }
        public static void Speedboost()
        {
            GorillaLocomotion.Player.Instance.jumpMultiplier = 4; GorillaLocomotion.Player.Instance.maxJumpSpeed = 4;
        }

        public static void Gripfly()
        {
            if (easyInputs.EasyInputs.GetGripButtonDown(EasyHand.RightHand))
            {
                var skibidi = GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody;
                skibidi.velocity = GorillaTagger.Instance.rightHandTransform.forward * 10f;
            }
        }

        public static void checkpoint()
        {
            if (easyInputs.EasyInputs.GetGripButtonDown(EasyHand.RightHand))
            {
                if (tspmo != null) UnityEngine.Object.Destroy(tspmo);
                tspmopos = GorillaLocomotion.Player.Instance.transform.position;
               tspmo = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                tspmo.GetComponent<Renderer>().material.color = Color.yellow;
                tspmo.transform.position = tspmopos;
                tspmo.transform.localScale = Vector3.one * 0.2f;
            }

            if (easyInputs.EasyInputs.GetSecondaryButtonDown(EasyHand.RightHand))
            {
                GorillaLocomotion.Player.Instance.transform.position = tspmopos;
            }
        }


    }
}
