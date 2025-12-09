using System;
using UnityEngine;

namespace IIDKQuest.Mods
{
    internal class AntiCrash
    {
        public static void ClearObjects()
        {
            // List of known crash-causing GameObject names
            string[] objectNames = new string[]
            {
                "bulletPrefab(Clone)",
                "gorillaenemy(Clone)",
                "STICKABLE TARGET(Clone)",
                "Network Player(Clone)",
                "gorillafireball(Clone)",
                "GorillaPlayerScoreboardLine(Clone)",
                "GorillaScoreBoard(Clone)"
            };

            int objectIndex = 0;
            int destroyCounter = 0;

            // Destroy each named GameObject in the list
            while (objectIndex < objectNames.Length)
            {
                string name = objectNames[objectIndex];
                GameObject obj = GameObject.Find(name);

                if (obj != null)
                {
                    UnityEngine.Object.DestroyImmediate(obj);
                }

                objectIndex++;
            }

            // Extra safety pass: run 70 times to possibly clean other objects (if needed later)
            while (destroyCounter < 70)
            {
                // Placeholder: could be used for additional cleanup logic
                destroyCounter++;
            }
        }

        // Empty constructor (only here for structural compatibility)
        public AntiCrash()
        {
            // No initialization needed
        }
    }
}
