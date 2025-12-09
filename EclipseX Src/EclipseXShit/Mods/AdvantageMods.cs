using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using easyInputs;
using IIDKQuest.Mods;
using UnityEngine;

namespace EclipseX.Mods
{
    internal class AdvantageMods
    {
        public static void TagAura() // iidks tag aura
        {
            if (easyInputs.EasyInputs.GetGripButtonDown(EasyHand.LeftHand))
            {
                foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
                {
                    if (vrrig == GorillaTagger.Instance.offlineVRRig || vrrig.mainSkin.material.name.Contains("fected"))
                        continue;

                    Vector3 they = vrrig.headMesh.transform.position;
                    Vector3 notthem = GorillaTagger.Instance.offlineVRRig.head.rigTarget.position;
                    float distance = Vector3.Distance(they, notthem);

                    if (!GorillaLocomotion.Player.Instance.disableMovement && distance < SettingsMods.tagAuraDistance)
                    {
                        if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
                        {
                            GorillaLocomotion.Player.Instance.leftHandTransform.position = they;
                        }
                        else
                        {
                            GorillaLocomotion.Player.Instance.leftHandTransform.position = they;
                        }
                    }
                }
            }
        }
    }
}
