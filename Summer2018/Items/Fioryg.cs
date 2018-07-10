using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Summer2018.Items
{
    public class Fioryg : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fioryg terrariano");
            Tooltip.SetDefault("Potrebbe esserti utile in futuro...");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 30;
            item.maxStack = 7;
            item.rare = -11;
        }
    }
}
