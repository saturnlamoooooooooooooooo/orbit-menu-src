using System;
using System.IO;
using IIDKQuest;

namespace IIDKQuest.Mods
{
    internal class normmenunames
    {
        public static void catmenuName()
        {
            string filePath = Path.Combine(Environment.CurrentDirectory, "CustomNameForOrbital.LOL.txt");

            try
            {
                // If the file doesn't exist, create it with a default name  
                if (!File.Exists(filePath))
                {
                    File.WriteAllText(filePath, "You're Text Here");
                    PluginInfo.SetName("Orbital.LOL");
                    return;
                }

                // Read the custom menu name from the file  
                string customName = File.ReadAllText(filePath).Trim();

                // If empty, set a default  
                if (string.IsNullOrEmpty(customName))
                {
                    customName = "You're Text Here";
                }

                // Apply the custom name to PluginInfo  
                PluginInfo.SetName(customName);
            }
            catch (Exception ex)
            {
                // Handle errors gracefully and fall back to default name  
                PluginInfo.SetName("Orbital.LOL");
            }
        }
    }
}

internal static class PluginInfo
{
    public const string GUID = "org.iidk.gorillatag.menutemplate";
    private static string _name = "<b>Orbitay</b>";
    public static string Name => _name;

    public static void SetName(string newName)
    {
        _name = newName;
    }
}
