using System;
using ExitGames.Client.Photon;
using Photon.Pun;

namespace MenuTemplate
{
    // Token: 0x0200002A RID: 42
    internal class CASUAL
    {
        // Token: 0x0600007E RID: 126 RVA: 0x00005FC4 File Offset: 0x000041C4
        public static void causals()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("gameMode", "forestDEFAULTCASUAL");
            PhotonNetwork.CurrentRoom.SetCustomProperties(hashtable, null, null);
        }
    }
}
