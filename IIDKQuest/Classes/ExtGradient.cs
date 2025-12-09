using System;
using UnityEngine;

namespace IIDKQuest.Classes
{
    public class ExtGradient
    {
        public GradientColorKey[] colors = new GradientColorKey[]
        {
            new GradientColorKey(Color.red, 0f),
            new GradientColorKey(Color.black, 0.5f),
            new GradientColorKey(Color.red, 1f)
        };

        public bool isRainbow = false;
        public bool copyRigColors = false;
    }
}
