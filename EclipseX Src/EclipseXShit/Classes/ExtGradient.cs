using System;
using UnityEngine;

namespace IIDKQuest.Classes
{
    /*
     This menu has no skidded mods
     if you remove this it is skidding
     Dm LJ/owner if these any bug
     And this is a beta
     */
    public class ExtGradient
    {
        public GradientColorKey[] colors = new GradientColorKey[]
        {
            new GradientColorKey(Color.black, 0f), // your colors
            new GradientColorKey(Color.magenta, 0.5f), // your colors
            new GradientColorKey(Color.black, 1f) // your colors
        };

        public bool isRainbow = false;
        public bool copyRigColors = false;
    }
}
