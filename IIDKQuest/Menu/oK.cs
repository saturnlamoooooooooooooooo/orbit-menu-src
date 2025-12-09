using System;
using UnityEngine;

namespace Popeye.Menu.mods
{
    // Token: 0x02000019 RID: 25
    internal class testttt
    {
        // Token: 0x06000053 RID: 83 RVA: 0x00004934 File Offset: 0x00002B34
        public static void rigcolor()
        {
            GameObject gameObject = GameObject.Find("Level/newsky");
            gameObject.GetComponent<MeshRenderer>().material.shader = Shader.Find("Standard");
            gameObject.GetComponent<MeshRenderer>().material.color = new Color(GorillaTagger.Instance.myVRRig.GetComponent<SkinnedMeshRenderer>().material.color.r, GorillaTagger.Instance.myVRRig.GetComponent<SkinnedMeshRenderer>().material.color.g, GorillaTagger.Instance.myVRRig.GetComponent<SkinnedMeshRenderer>().material.color.b);
        }
    }
}
