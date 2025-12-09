using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GorillaLocomotion;
using Photon.Pun;
using UnityEngine;

namespace IIDKQuest.Mods
{
    internal class Givewatchall
    {
        public static void givewatchallmod()
        {
            PhotonNetwork.Instantiate("gorillaprefabs/gorillahuntmanager", GorillaTagger.Instance.rightHandTransform.transform.position, GorillaTagger.Instance.rightHandTransform.transform.rotation, 0, null);
        }
    }
}