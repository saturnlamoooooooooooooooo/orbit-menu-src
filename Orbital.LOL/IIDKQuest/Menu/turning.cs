using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using easyInputs;

namespace IIDKQuest.Mods
{
    internal class turning
    {
        public static void Turning()
        {
            if (EasyInputs.GetThumbStick2DAxis(EasyHand.RightHand).x > 0.5f)
            {
                GorillaLocomotion.Player.Instance.Turn(10f);
            }
            if (EasyInputs.GetThumbStick2DAxis(EasyHand.RightHand).x < -0.5f)
            {
                GorillaLocomotion.Player.Instance.Turn(-10f);
            }
        }
    }
}
