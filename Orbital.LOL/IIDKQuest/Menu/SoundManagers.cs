using UnityEngine;

namespace IIDKQuest
{
    public class SoundManager : MonoBehaviour
    {
        private static AudioSource source;

        public static void Init()
        {
            if (source == null)
            {
                GameObject soundObj = new GameObject("ButtonSoundPlayer");
                source = soundObj.AddComponent<AudioSource>();
                GameObject.DontDestroyOnLoad(soundObj);
            }
        }

        public static void PlayClick()
        {
            Init();
            AudioClip clip = Resources.Load<AudioClip>("Sounds/click");
            if (clip != null)
            {
                source.PlayOneShot(clip);
            }
            else
            {
                Debug.LogWarning("❌ Missing sound: Resources/Sounds/click.wav");
            }
        }
    }
}
