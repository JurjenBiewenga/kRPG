﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace kRPG.Items
{
    public class ScintillatingBloodLacrima : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value = 100000;
            item.rare = 10;
            item.consumable = true;
            item.useStyle = 2;
            item.useTime = 17;
            item.useAnimation = 17;
            item.useTurn = true;
            item.UseSound = SoundID.Item3;
        }

        public override bool UseItem(Player player)
        {
            PlayerCharacter character = player.GetModPlayer<PlayerCharacter>();
            foreach (STAT stat in Enum.GetValues(typeof(STAT)))
                character.baseStats[stat] = 0;
            return true;
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Scintillating Blood Lacrima");
            Tooltip.SetDefault("Consume to reset stat points");
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            tooltips.Add(new TooltipLine(mod, "Description", "'A large tear shed by a gigantic blood-drinking unicorn'"));
        }
    }
}
