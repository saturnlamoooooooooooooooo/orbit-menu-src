using System;
using Photon.Pun;
using UnityEngine;
using UnityEngine.UI;

namespace IIDKQuest.Mods
{
    // Token: 0x0200000C RID: 12
    internal class ModscoolbyLunar
    {
        // Token: 0x06000052 RID: 82 RVA: 0x00004825 File Offset: 0x00002A25
     

        // Token: 0x06000057 RID: 87 RVA: 0x0000487C File Offset: 0x00002A7C
        public static void hz()
        {
            Application.targetFrameRate = 20;
        }

        // Token: 0x06000058 RID: 88 RVA: 0x00004887 File Offset: 0x00002A87
        

        // Token: 0x0600005A FIXED: 90 RVA: 0x000048A4 File Offset: 0x00002AA4
        public static void JoinMenuRoom()
        {
            PhotonNetwork.JoinRoom("ORBIT");
        }

       
    }
}
