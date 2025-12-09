using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using easyInputs;
using Il2CppSystem.Collections.Generic;  // Make sure EasyInputs namespace is included

namespace IIDKQuest.Mods
{
    public class BananaSpam : MonoBehaviour
    {
        public GameObject bananaPrefab;
        public float spawnInterval = 0.1f;  // seconds between spawns
        public int maxBananas = 100;        // max cubes to keep alive

        private readonly Il2CppSystem.Collections.Generic.Queue<GameObject> spawnedBananas = new Queue<GameObject>();
        private bool isSpamming = false;
        private Coroutine spamCoroutine;
        public static void Ok()
        {

        }

        void Start()
        {
            if (bananaPrefab == null)
            {
                bananaPrefab = GameObject.CreatePrimitive(PrimitiveType.Cube);
                bananaPrefab.transform.localScale = Vector3.one * 0.2f;
                var rend = bananaPrefab.GetComponent<Renderer>();
                rend.material = new Material(Shader.Find("Standard"));
                rend.material.color = Color.yellow;

                var col = bananaPrefab.GetComponent<Collider>();
                if (col) col.enabled = false;

                bananaPrefab.SetActive(false);
            }
        }

        void Update()
        {
            // Toggle banana spam on right hand grip press
            if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
            {
                if (!isSpamming)
                {
                    spamCoroutine = StartCoroutine((Il2CppSystem.Collections.IEnumerator)SpamBananas());
                    isSpamming = true;
                }
                else
                {
                    StopCoroutine(spamCoroutine);
                    isSpamming = false;
                }
            }
        }

        private IEnumerator SpamBananas()
        {
            while (true)
            {
                SpawnBanana();
                yield return new WaitForSeconds(spawnInterval);
            }
        }

        private void SpawnBanana()
        {
            Vector3 spawnPos = Camera.main.transform.position + Camera.main.transform.forward * 2f;
            spawnPos += new Vector3(
                Random.Range(-0.5f, 0.5f),
                Random.Range(-0.5f, 0.5f),
                Random.Range(-0.5f, 0.5f)
            );

            GameObject banana;
            if (spawnedBananas.Count >= maxBananas)
            {
                banana = spawnedBananas.Dequeue();
                banana.transform.position = spawnPos;
                banana.SetActive(true);
            }
            else
            {
                banana = Instantiate(bananaPrefab, spawnPos, Quaternion.identity);
                banana.SetActive(true);
            }

            spawnedBananas.Enqueue(banana);
        }
    }
}
