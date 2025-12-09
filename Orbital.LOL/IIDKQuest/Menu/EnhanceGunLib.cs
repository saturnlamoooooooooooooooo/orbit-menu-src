using UnityEngine;
using easyInputs;
using GorillaLocomotion;
using Photon.Pun;
using System.Collections;

namespace IIDKQuest.Mods
{
    public class SpringGuns : MonoBehaviour
    {
        public GameObject gunPrefab;
        public AudioClip shootSound;

        private static LineRenderer spring;
        private static GameObject tipMarker;
        private GameObject spawnedGun;
        private AudioSource audioSource;

        private const int coilResolution = 120;
        private const float radius = 0.05f;
        private static float animationSpeed = 5f;
        private static int coilsMin = 3;
        private static int coilsMax = 10;
        public static void Ok()
        {
            
        }

        void Start()
        {
            // Attach gun to right hand
            if (spawnedGun == null && gunPrefab != null)
            {
                Transform hand = Player.Instance.rightHandTransform;
                spawnedGun = Instantiate(gunPrefab, hand);
                spawnedGun.transform.localPosition = new Vector3(0, -0.05f, 0.1f);
                spawnedGun.transform.localRotation = Quaternion.identity;
            }

            // Add audio
            audioSource = gameObject.AddComponent<AudioSource>();
            audioSource.spatialBlend = 1f;
            audioSource.playOnAwake = false;
            audioSource.clip = shootSound;
        }

        void Update()
        {
            if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
            {
                Activate();
            }
        }

        public void Activate()
        {
            Vector3 origin = Player.Instance.rightHandTransform.position;
            Vector3 direction = Player.Instance.rightHandTransform.forward;

            // Play effects
            PlayMuzzleFlash();
            PlayShootSound();
            StartCoroutine((Il2CppSystem.Collections.IEnumerator)Recoil());

            if (Physics.Raycast(origin, direction, out RaycastHit hit))
            {
                Vector3 end = hit.point;

                if (spring == null)
                {
                    GameObject springObj = new GameObject("AnimatedSpring");
                    spring = springObj.AddComponent<LineRenderer>();
                    spring.material = new Material(Shader.Find("Sprites/Default"));
                    spring.startWidth = 0.02f;
                    spring.endWidth = 0.02f;
                    spring.positionCount = coilResolution;
                }

                float pulse = Mathf.PingPong(Time.time * 2f, 1f);
                Color pulseColor = Color.Lerp(Color.black, Color.red, pulse);
                spring.material.color = pulseColor;

                // Tip marker
                if (tipMarker == null)
                {
                    tipMarker = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                    tipMarker.name = "SpringTipMarker";
                    tipMarker.transform.localScale = Vector3.one * 0.1f;
                    var renderer = tipMarker.GetComponent<Renderer>();
                    renderer.material = new Material(Shader.Find("Unlit/Color"));
                    renderer.material.color = Color.red;
                    Destroy(tipMarker.GetComponent<Collider>());
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
                    Destroy(spring.gameObject);
                    spring = null;
                }

                if (tipMarker != null)
                {
                    Destroy(tipMarker);
                    tipMarker = null;
                }
            }
        }

        private void PlayMuzzleFlash()
        {
            GameObject flash = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            flash.transform.position = Player.Instance.rightHandTransform.position + Player.Instance.rightHandTransform.forward * 0.1f;
            flash.transform.localScale = Vector3.one * 0.05f;
            var renderer = flash.GetComponent<Renderer>();
            renderer.material = new Material(Shader.Find("Unlit/Color"));
            renderer.material.color = Color.yellow;
            Destroy(flash.GetComponent<Collider>());
            Destroy(flash, 0.1f);
        }

        private void PlayShootSound()
        {
            if (shootSound != null)
                audioSource.PlayOneShot(shootSound);
        }

        private IEnumerator Recoil()
        {
            if (spawnedGun == null) yield break;

            Transform gun = spawnedGun.transform;
            Vector3 originalPos = gun.localPosition;
            gun.localPosition += new Vector3(0f, 0.01f, -0.05f);
            yield return new WaitForSeconds(0.05f);
            gun.localPosition = originalPos;
        }
    }
}
