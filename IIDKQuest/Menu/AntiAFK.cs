using System;
using GorillaNetworking;
using UnityEngine;

namespace IIDKQuest.Mods
{
    // Token: 0x02000008 RID: 8
    internal class AntiAFK
    {
        // Token: 0x06000017 RID: 23 RVA: 0x000058D0 File Offset: 0x00003AD0


        
        
            public static void EnableAFK()
            {
                GameObject gameObject = GameObject.Find("Photon Manager");
                if (gameObject != null)
                {
                    PhotonNetworkController component = gameObject.GetComponent<PhotonNetworkController>();
                    if (component != null)
                    {
                        component.disableAFKKick = false;
                    }
                }
            }

            public static void DisableAFK()
            {
                GameObject gameObject = GameObject.Find("Photon Manager");
                if (gameObject != null)
                {
                    PhotonNetworkController component = gameObject.GetComponent<PhotonNetworkController>();
                    if (component != null)
                    {
                        component.disableAFKKick = true;
                    }
                }
            }
        }
    }


  
      
