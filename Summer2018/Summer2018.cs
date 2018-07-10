using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Summer2018
{
    public class Summer2018 : Mod
    {
        public override void AddRecipes()
        {
            //More Hermes Boots
            ModRecipe newHermesBoots = new ModRecipe(this);
            newHermesBoots.AddIngredient(ItemID.Feather, 5);
            newHermesBoots.AddIngredient(ItemID.Silk, 5);
            newHermesBoots.AddTile(TileID.Anvils);
            newHermesBoots.SetResult(ItemID.HermesBoots);
            newHermesBoots.AddRecipe();
            //Altezza Coniglio
            ModRecipe newFuzzyCarrot = new ModRecipe(this);
            newFuzzyCarrot.AddIngredient(ItemID.Daybloom, 30);
            newFuzzyCarrot.AddIngredient(ItemID.Blinkroot, 10);
            newFuzzyCarrot.AddIngredient(ItemID.Moonglow, 30);
            newFuzzyCarrot.AddTile(TileID.WorkBenches);
            newFuzzyCarrot.SetResult(ItemID.FuzzyCarrot);
            newFuzzyCarrot.AddRecipe();
            //Easy Inferno Potion
            ModRecipe easyInfernoPotion = new ModRecipe(this);
            easyInfernoPotion.AddIngredient(ItemID.Fireblossom, 10);
            easyInfernoPotion.AddIngredient(ItemID.Obsidian, 5);
            easyInfernoPotion.AddTile(TileID.Bottles);
            easyInfernoPotion.SetResult(ItemID.InfernoPotion);
            easyInfernoPotion.AddRecipe();

        }
    }
}
