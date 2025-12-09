using System.IO;
using TMPro;
using UnityEngine;

namespace IIDKQuest.Mods
{
    internal class StumpTextCustomizedByLunar
    {
        public static TMP_FontAsset ArialFontAsset;
        private static GameObject StumpObj;
        private static string textFilePath = Path.Combine(Application.persistentDataPath, "CustomStumpText.txt");

        public static void StumpTexty()
        {
            if (!File.Exists(textFilePath))
            {
                // Create the file with default text if it doesn't exist
                File.WriteAllText(textFilePath, "<color=#cc99ff>Welcome to Orbit.LOL</color>\n<color=red>[ Version: 3.0.2 ]</color>");
            }

            string fileText = File.ReadAllText(textFilePath);

            if (StumpObj == null)
            {
                StumpObj = new GameObject("STUMPOBJ");
                TextMeshPro tmp = StumpObj.AddComponent<TextMeshPro>();
                tmp.text = fileText;
                tmp.fontSize = 2f;
                tmp.alignment = TextAlignmentOptions.Center;
                tmp.color = Color.white;
                tmp.font = ArialFontAsset;

                Transform t = StumpObj.transform;
                t.localScale = new Vector3(0.6f, 0.6f, 0.6f);
                t.position = new Vector3(-67.125f, 12.249f, -82.66959f);
            }

            // Make it face the player
            Transform trans = StumpObj.transform;
            trans.LookAt(Camera.main.transform.position);
            trans.Rotate(0f, 180f, 0f);
        }

        public static void DestroyStumpText()
        {
            Object.Destroy(StumpObj);
            StumpObj = null;
        }

        public static void RefreshText()
        {
            if (StumpObj != null && File.Exists(textFilePath))
            {
                string updatedText = File.ReadAllText(textFilePath);
                TextMeshPro tmp = StumpObj.GetComponent<TextMeshPro>();
                if (tmp != null)
                {
                    tmp.text = updatedText;
                }
            }
        }
    }
}
