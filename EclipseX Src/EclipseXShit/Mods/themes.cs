using IIDKQuest;
using IIDKQuest.Classes;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace EclipseX.Mods
{
    internal class ThemeSettings
    {
       

        private static int currentTheme = 0;

        private static readonly Action[] themeList = new Action[]
        {
            NormalTheme,
            MarsXTheme,
            BlackTheme,
            WhiteTheme,
            RGBTheme,
            GreyTheme,
            RedTheme,
            MagentaTheme,
            YellowTheme,
            CyanTheme,
            BlueTheme,
            SymexTheme
        };

        public static void ChangeTheme()
        {
            themeList[currentTheme].Invoke();
            currentTheme++;
            if (currentTheme >= themeList.Length)
                currentTheme = 0;
        }

        public static void MarsXTheme()
        {
            Settings.backgroundColor = new ExtGradient
            {
                colors = new GradientColorKey[]
                {
                    new GradientColorKey(Color.black, 0f),
                    new GradientColorKey(new Color(0.5f, 0f, 0f), 0.5f),
                    new GradientColorKey(Color.black, 1f)
                },
                isRainbow = false
            };
        }

        public static void BlackTheme()
        {
            Settings.backgroundColor = new ExtGradient
            {
                colors = new GradientColorKey[]
                {
                    new GradientColorKey(Color.black, 0f),
                    new GradientColorKey(Color.black, 0.5f),
                    new GradientColorKey(Color.black, 1f)
                },
                isRainbow = false
            };
        }

        public static void WhiteTheme()
        {
            Settings.backgroundColor = new ExtGradient
            {
                colors = new GradientColorKey[]
                {
                    new GradientColorKey(Color.black, 0f),
                    new GradientColorKey(Color.white, 0.5f),
                    new GradientColorKey(Color.black, 1f)
                },
                isRainbow = false
            };
        }

        public static void RGBTheme()
        {
            Settings.backgroundColor = new ExtGradient
            {
                colors = new GradientColorKey[]
                {
                    new GradientColorKey(Color.black, 0f),
                    new GradientColorKey(Color.black, 0.5f),
                    new GradientColorKey(Color.black, 1f)
                },
                isRainbow = true
            };
        }

        public static void NormalTheme()
        {
            Settings.backgroundColor = new ExtGradient
            {
                colors = new GradientColorKey[]
                {
                     new GradientColorKey(Color.black, 0f),
                },
                isRainbow = false
            };
        }

        public static void GreyTheme()
        {
            Settings.backgroundColor = new ExtGradient
            {
                colors = new GradientColorKey[]
                {
                    new GradientColorKey(Color.grey, 0.5f),
                },
                isRainbow = false
            };
        }

        public static void RedTheme()
        {
            Settings.backgroundColor = new ExtGradient
            {
                colors = new GradientColorKey[]
                {
                    new GradientColorKey(Color.red, 0.5f),
                },
                isRainbow = false
            };
        }

        public static void MagentaTheme()
        {
            Settings.backgroundColor = new ExtGradient
            {
                colors = new GradientColorKey[]
                {
                    new GradientColorKey(Color.magenta, 0.5f),
                },
                isRainbow = false
            };
        }

        public static void YellowTheme()
        {
            Settings.backgroundColor = new ExtGradient
            {
                colors = new GradientColorKey[]
                {
                    new GradientColorKey(Color.yellow, 0.5f),
                },
                isRainbow = false
            };
        }

        public static void CyanTheme()
        {
            Settings.backgroundColor = new ExtGradient
            {
                colors = new GradientColorKey[]
                {
                    new GradientColorKey(Color.cyan, 0.5f),
                },
                isRainbow = false
            };
        }

        public static void BlueTheme()
        {
            Settings.backgroundColor = new ExtGradient
            {
                colors = new GradientColorKey[]
                {
                    new GradientColorKey(Color.blue, 0.5f),
                },
                isRainbow = false
            };
        }

        public static void SymexTheme()
        {
            Settings.backgroundColor = new ExtGradient
            {
                colors = new GradientColorKey[]
                {
                    new GradientColorKey(Color.magenta, 0f),
                    new GradientColorKey(Color.magenta, 0.5f),
                    new GradientColorKey(Color.magenta, 1f)
                },
                isRainbow = false
            };
        }
    }
}
