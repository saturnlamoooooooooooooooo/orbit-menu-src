using UnityEngine;

namespace IIDKQuest
{
    public static class UIHelpers
    {
        public static bool SoundButton(string label, params GUILayoutOption[] options)
        {
            bool pressed = GUILayout.Button(label, options);
            if (pressed)
            {
                SoundManager.PlayClick();
            }
            return pressed;
        }
    }
}
