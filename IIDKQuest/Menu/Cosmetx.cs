using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IIDKQuest.Mods
{
    internal class Cosmetx
    {
        public static void AllCosmetics()
        {
            foreach (CosmeticsController.CosmeticItem cosmetic in CosmeticsController.instance.allCosmetics)
            {
                if (CosmeticsController.instance != null)
                {
                    CosmeticsController.instance.UnlockItem(cosmetic.itemName);
                    CosmeticsController.instance.unlockedCosmetics.Add(cosmetic);
                    CosmeticsController instance = CosmeticsController.instance;
                    CosmeticsController cosmeticsController = instance;
                    string concatStringCosmeticsAllowed = instance.concatStringCosmeticsAllowed;
                    CosmeticsController.CosmeticItem cosmeticItemOthers = cosmetic;
                    cosmeticsController.concatStringCosmeticsAllowed = concatStringCosmeticsAllowed + ((cosmeticItemOthers != null) ? cosmeticItemOthers.ToString() : null);
                }
            }
        }
    }
}