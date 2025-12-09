using System;
using ExitGames.Client.Photon;
using Photon.Pun;

namespace MenuTemplate
{
    // Token: 0x02000044 RID: 68
    internal class infection
    {
        // Token: 0x06000138 RID: 312 RVA: 0x00009FD8 File Offset: 0x000081D8
        public static void infections()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("gameMode", "forestDEFAULTMODDED_MODDED_INFECTIONINFECTION");
            PhotonNetwork.CurrentRoom.SetCustomProperties(hashtable, null, null);
        }
    }
}
