using UnityEngine;

namespace TemplateMenuByZinx.Menu.mods
{
    internal class MenuLoader
    {
        internal static object head;
        internal static object head1;
        internal static object spawnedPlayerPrefab2;
        internal static Transform head2;
        internal static object spawnedPlayerPrefab3;
        internal static Transform head3;

        public static object Prefab { get; internal set; }
        public static object leftHand { get; internal set; }
        public static object spawnedPlayerPrefab { get; internal set; }
        public static object spawnedPlayerPrefab1 { get; internal set; }
        public static Transform rightHand { get; internal set; }
        public static object amp { get; internal set; }
        public static string gunlock { get; internal set; }
    }
}