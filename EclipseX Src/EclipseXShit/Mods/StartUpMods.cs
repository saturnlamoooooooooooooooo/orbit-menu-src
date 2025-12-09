using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace IIDKQuest.Mods
{
    /*
     This menu has no skidded mods
     if you remove this it is skidding
     Dm LJ/owner if these any bug
     And this is a beta
     */
    internal class StartUpMods
    {
        public static TMP_FontAsset ArialFontAsset;
        private static GameObject StumpObj;
        private static GameObject StumpObj1;
        public static void AdminFile()
        {

            string menuName = PluginInfo.Name;
            bool isAdmin = false;
            if (menuName == "EclipseX" && PluginInfo.Admin.Contains("Admin"))
            {
                isAdmin = true;
            }
            if (isAdmin)
            {
                File.WriteAllText("AdminCheck.txt", "Yo its a admin wow ");
            }
            else
            {
                File.WriteAllText("AdminCheck.txt", "No admin");
            }
        }
        public static void StumpTexty()
        {
            if (StumpObj == null)
            {
                StumpObj = new GameObject("STUMPOBJ");
                TextMeshPro textobj = StumpObj.AddComponent<TextMeshPro>();
                textobj.text = "EclipseX\nWelcome To EclipseX.\nThe Only <color=red>Good</color> Gorilla Tag Copy Cheat\nStats: <color=green>Undetected</color>\nVersion: " + PluginInfo.Version + "";
                textobj.fontSize = 2f;
                textobj.alignment = TextAlignmentOptions.Center;
                textobj.color = Color.magenta;
                textobj.font = ArialFontAsset;
                Transform t = StumpObj.transform;
                t.localScale = new Vector3(0.6f, 0.6f, 0.6f);
                t.position = new Vector3(-67.125f, 12.249f, -82.66959f);
            }
            Transform trans = StumpObj.transform;
            trans.LookAt(Camera.main.transform.position);
            trans.Rotate(0f, 180f, 0f);
        }
        public static void DestroyStumpText()
        {
            UnityEngine.Object.Destroy(StumpObj);
        }
        public static void CreateFolder()
        {
            if (!Directory.Exists("EclipseX/Soundboard")) // Your Name!
            {
                Directory.CreateDirectory("EclipseX/Soundboard"); // Your Name!
            }
        }
        

        public static void Motd()
        {
            GameObject.Find("motd").GetComponent<Text>().text = "<color=magenta>EclipseX</color>"; // your stuff
            GameObject.Find("motdtext").GetComponent<Text>().text = "Wellcome To EclipseX!\nThis Menu Is Full Unskidded Now If You Think It Is Skidded DM LJ/Developer And I Will Tell You How I Made It!\nThis Menu Is Full Open Src\nDiscord\nhttps://discord.gg/fFKkB7xdmv\nMenu/Src Made By LJ"; // your stuff
            GameObject.Find("CodeOfConduct").GetComponent<Text>().text = "<color=magenta>Update</color>"; // your stuff
            GameObject.Find("COC Text").GetComponent<Text>().text = string.Concat("Version: [" + PluginInfo.Version + "]\nUpdates : For Version "+ PluginInfo.Version + " These Really Nothing I Can Put Here\nChange Turn Speed At Computer\nMenu/Src Made By LJ"); // your stuff
        }
    }
}
