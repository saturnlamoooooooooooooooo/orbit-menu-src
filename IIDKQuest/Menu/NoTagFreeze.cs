using System;
using GorillaLocomotion;

namespace IIDKQuest.Mods
{
    // Token: 0x0200003D RID: 61
    internal class notagfreeze
    {
        // Token: 0x06000081 RID: 129 RVA: 0x00005070 File Offset: 0x00003270
        public static void DisabletagFreeze()
        {
            Player.Instance.disableMovement = false;
        }
    }
}
