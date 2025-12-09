using System;
using System.Reflection;
using Photon.Voice.Unity;
using TemplateMenuByZinx.Menu.mods;
using UnityEngine;

namespace TemplateMenuByZinx.Menu.notflib.mods
{
    // Token: 0x0200006F RID: 111  
    internal class mic_mods
    {
        // Token: 0x060001FB RID: 507 RVA: 0x00016D3C File Offset: 0x00014F3C  
        public static void highqualitymic()
        {
            Recorder component = GameObject.Find("NetworkVoice").GetComponent<Recorder>();
            PropertyInfo property = typeof(Recorder).GetProperty("SamplingRate");
            bool flag = property != null && property.CanWrite;
            bool flag2 = flag;
            if (flag2)
            {
                property.SetValue(component, 48000);
            }
            PropertyInfo property2 = typeof(Recorder).GetProperty("Bitrate");
            bool flag3 = property2 != null && property2.CanWrite;
            bool flag4 = flag3;
            if (flag4)
            {
                property2.SetValue(component, 500000);
            }
            MethodInfo method = typeof(Recorder).GetMethod("RestartRecording");
            bool flag5 = method != null;
            bool flag6 = flag5;
            if (flag6)
            {
                method.Invoke(component, new object[]
                {
                       true
                });
            }
        }

        // Token: 0x060001FC RID: 508 RVA: 0x00016E24 File Offset: 0x00015024  
        public static void loudmic()
        {
            Recorder component = GameObject.Find("NetworkVoice").GetComponent<Recorder>();
            PropertyInfo property = typeof(Recorder).GetProperty("SamplingRate");
            bool flag = property != null && property.CanWrite;
            bool flag2 = flag;
            if (flag2)
            {
                property.SetValue(component, 48000);
            }
            PropertyInfo property2 = typeof(Recorder).GetProperty("Bitrate");
            bool flag3 = property2 != null && property2.CanWrite;
            bool flag4 = flag3;
            if (flag4)
            {
                property2.SetValue(component, 500000);
            }
            // Fix: Cast MenuLoader.amp to the appropriate type that contains AmplificationFactor  
            dynamic amp = MenuLoader.amp;
            amp.amplificationFactor = 150f;
            amp.AmplificationFactor = 150f;
            MethodInfo method = typeof(Recorder).GetMethod("RestartRecording");
            bool flag5 = method != null;
            bool flag6 = flag5;
            if (flag6)
            {
                method.Invoke(component, new object[]
                {
                       true
                });
            }
        }

        // Token: 0x060001FD RID: 509 RVA: 0x00016F2C File Offset: 0x0001512C  
        public static void lowqualitymic()
        {
            Recorder component = GameObject.Find("NetworkVoice").GetComponent<Recorder>();
            PropertyInfo property = typeof(Recorder).GetProperty("SamplingRate");
            bool flag = property != null && property.CanWrite;
            bool flag2 = flag;
            if (flag2)
            {
                property.SetValue(component, 48000);
            }
            PropertyInfo property2 = typeof(Recorder).GetProperty("Bitrate");
            bool flag3 = property2 != null && property2.CanWrite;
            bool flag4 = flag3;
            if (flag4)
            {
                property2.SetValue(component, 6000);
            }
            MethodInfo method = typeof(Recorder).GetMethod("RestartRecording");
            bool flag5 = method != null;
            bool flag6 = flag5;
            if (flag6)
            {
                method.Invoke(component, new object[]
                {
                       true
                });
            }
        }

        // Token: 0x060001FE RID: 510 RVA: 0x00017014 File Offset: 0x00015214  
        public static void fixmic()
        {
            Recorder component = GameObject.Find("NetworkVoice").GetComponent<Recorder>();
            PropertyInfo property = typeof(Recorder).GetProperty("AudioClip");
            bool flag = property != null && property.CanWrite;
            bool flag2 = flag;
            if (flag2)
            {
                property.SetValue(component, null);
            }
            PropertyInfo property2 = typeof(Recorder).GetProperty("SourceType");
            bool flag3 = property2 != null && property2.CanWrite;
            bool flag4 = flag3;
            if (flag4)
            {
                property2.SetValue(component, 0);
            }
            // Fix: Cast MenuLoader.amp to the appropriate type that contains AmplificationFactor  
            dynamic amp = MenuLoader.amp;
            amp.amplificationFactor = 0f;
            amp.AmplificationFactor = 1f;
            MethodInfo method = typeof(Recorder).GetMethod("RestartRecording");
            bool flag5 = method != null;
            bool flag6 = flag5;
            if (flag6)
            {
                method.Invoke(component, new object[]
                {
                       true
                });
            }
        }

        // Token: 0x060001FF RID: 511 RVA: 0x00017110 File Offset: 0x00015310  
        public static void disablemic()
        {
            Recorder component = GameObject.Find("NetworkVoice").GetComponent<Recorder>();
            PropertyInfo property = typeof(Recorder).GetProperty("AudioClip");
            bool flag = property != null && property.CanWrite;
            bool flag2 = flag;
            if (flag2)
            {
                property.SetValue(component, null);
            }
            PropertyInfo property2 = typeof(Recorder).GetProperty("SourceType");
            bool flag3 = property2 != null && property2.CanWrite;
            bool flag4 = flag3;
            if (flag4)
            {
                property2.SetValue(component, 0);
            }
            // Fix: Cast MenuLoader.amp to the appropriate type that contains AmplificationFactor  
            dynamic amp = MenuLoader.amp;
            amp.amplificationFactor = -1E+09f;
            amp.AmplificationFactor = -1E+09f;
            MethodInfo method = typeof(Recorder).GetMethod("RestartRecording");
            bool flag5 = method != null;
            bool flag6 = flag5;
            if (flag6)
            {
                method.Invoke(component, new object[]
                {
                       true
                });
            }
        }
    }
}
