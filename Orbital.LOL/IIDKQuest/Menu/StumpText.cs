using TMPro;
using UnityEngine;

namespace IIDKQuest.Mods
{
    internal class StumpText
    {
        private static GameObject StumpObj;
        public static TMP_FontAsset ArialFontAsset;

        public static void StumpTexty()
        {
            if (StumpObj == null)
            {
                StumpObj = new GameObject("STUMPOBJ");
                var textMeshPro = StumpObj.AddComponent<TextMeshPro>();

                // Colored welcome text with version
                textMeshPro.text =
                    "<color=#cc99ff>O</color><color=#b38dff>r</color><color=#997fff>b</color><color=#7f70ff>i</color><color=#6662ff>t</color> Welcome To Orbital.LOL \n\n<color=red>[ Version: 6.0.2 ]</color>";

                textMeshPro.fontSize = 2f;
                textMeshPro.alignment = TextAlignmentOptions.Center;
                textMeshPro.color = Color.red;
                textMeshPro.font = ArialFontAsset;

                StumpObj.transform.localScale = new Vector3(0.6f, 0.6f, 0.6f);
                StumpObj.transform.position = new Vector3(-67.125f, 12.249f, -82.66959f);

                // Add flashing color script (by Lunar)
                StumpObj.AddComponent<StumpFlasher>();
            }

            // Make the text face the camera
            if (Camera.main != null)
            {
                StumpObj.transform.LookAt(Camera.main.transform.position);
                StumpObj.transform.Rotate(0f, 180f, 0f);
            }
        }

        // Call this to destroy the text object when you want to hide the message
        public static void DestroyStumpText()
        {
            if (StumpObj != null)
            {
                Object.Destroy(StumpObj);
                StumpObj = null;
            }
        }
    }

    internal class StumpFlasher : MonoBehaviour
    {
        private TextMeshPro text;
        private float speed = 2f;

        void Start()
        {
            text = GetComponent<TextMeshPro>();
        }

        void Update()
        {
            if (text != null)
            {
                // Flash between black and red smoothly
                float t = Mathf.PingPong(Time.time * speed, 1f);
                text.color = Color.Lerp(Color.black, Color.red, t);
            }
        }
    }
}
