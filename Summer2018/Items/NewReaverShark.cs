using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Summer2018.Items
{
    class NewReaverShark : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (item == null) return;
            //Reaver Shark nerf
            if (item.type == ItemID.ReaverShark)
            {
                item.pick = 59;
                item.reuseDelay = 15;
            }
            //Drills buff
            if (item.type == ItemID.CobaltDrill || item.type == ItemID.MythrilDrill || item.type == ItemID.AdamantiteDrill ||
                item.type == ItemID.PalladiumDrill || item.type == ItemID.OrichalcumDrill || item.type == ItemID.TitaniumDrill ||
                item.type == ItemID.Drax ||
                item.type == ItemID.SolarFlareDrill || item.type == ItemID.VortexDrill || item.type == ItemID.NebulaDrill || item.type == ItemID.StardustDrill)
            {
                item.reuseDelay = item.reuseDelay * 3 / 4;
            }
            //Pickaxes buff
            if (item.type == ItemID.CobaltPickaxe || item.type == ItemID.MythrilPickaxe || item.type == ItemID.AdamantitePickaxe ||
                item.type == ItemID.PalladiumPickaxe || item.type == ItemID.OrichalcumPickaxe || item.type == ItemID.TitaniumPickaxe ||
                item.type == ItemID.PickaxeAxe ||
                item.type == ItemID.SolarFlarePickaxe || item.type == ItemID.VortexPickaxe || item.type == ItemID.NebulaPickaxe || item.type == ItemID.StardustPickaxe)
            {
                item.damage = item.damage * 4 / 3 + 10;
            }
            //Hammush buff
            if (item.type == ItemID.Hammush)
            {
                item.reuseDelay -= 5;
            }
            //Molten Armor nerf
            if (item.type == ItemID.MoltenHelmet)
            {
                item.defense -= 1;
            }
            if (item.type == ItemID.MoltenBreastplate)
            {
                item.defense -= 1;
            }
            if (item.type == ItemID.MoltenGreaves)
            {
                item.defense -= 1;
            }
            //Pearlwood Armor buff
            if (item.type == ItemID.PearlwoodHelmet)
            {
                item.defense += 6;
            }
            if (item.type == ItemID.PearlwoodBreastplate)
            {
                item.defense += 6;
            }
            if(item.type == ItemID.PearlwoodGreaves)
            {
                item.defense += 6;
            }
            //Beetle Armor buff
            if (item.type == ItemID.BeetleScaleMail)
            {
                item.defense += 6;
            }
            //Gold Chest value
            if (item.type == ItemID.GoldChest)
            {
                item.value += 9000;
            }
            //Bone Glove buff
            if (item.type == ItemID.BoneGlove)
            {
                item.damage += 11;
            }
            //King Slime devalue
            if (item.type == ItemID.RoyalGel || item.type == ItemID.Solidifier || item.type == ItemID.SlimySaddle)
            {
                item.value = 2000;
            }
            //Hermes Boots devalue
            if(item.type == ItemID.HermesBoots)
            {
                item.value = 300;
            }
        }
    }
}
