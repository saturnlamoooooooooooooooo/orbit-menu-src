using System;
using Photon.Pun;

namespace IIDKQuest.Mods
{
    // Token: 0x02000017 RID: 23
    internal class disconnect
    {
        // Token: 0x06000030 RID: 48 RVA: 0x000034E7 File Offset: 0x000016E7
        public static void Disconnect()
        {
            PhotonNetwork.Disconnect();
        }
    }
}
