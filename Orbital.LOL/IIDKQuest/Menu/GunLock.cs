using System;

namespace TemplateMenuByZinx.Menu.mods
{
    // Token: 0x0200007C RID: 124
    internal class gun_lock
    {
        // Token: 0x06000223 RID: 547 RVA: 0x0001AB20 File Offset: 0x00018D20
        public static void gunlock()
        {
            // Fix: Ensure the correct namespace and property name are used.
            bool flag = MenuLoader.gunlock == "ON"; // Updated to match the correct namespace and property.
            bool flag2 = flag;
            bool flag3 = flag2;
            if (flag3)
            {
                MenuLoader.gunlock = "OFF"; // Updated to match the correct namespace and property.
            }
            else
            {
                bool flag4 = MenuLoader.gunlock == "OFF"; // Updated to match the correct namespace and property.
                bool flag5 = flag4;
                bool flag6 = flag5;
                if (flag6)
                {
                    MenuLoader.gunlock = "ON"; // Updated to match the correct namespace and property.
                }
            }

        }
    }
}
