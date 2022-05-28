using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Utilities;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.ItemDropRules;
using Endtime.Content.Items.Placeables;

namespace Endtime.Content.NPCs
{
	public class InfernalSlime : ModNPC
	{

		public override void SetStaticDefaults()
    {
			Main.npcFrameCount[NPC.type] = 2;

			NPCID.Sets.DebuffImmunitySets.Add(Type, new NPCDebuffImmunityData
      {
				SpecificallyImmuneTo = new int[]
        {
					BuffID.OnFire,
          BuffID.Poisoned
				}
			});
		}

		public override void SetDefaults()
    {
			NPC.width = 32;
			NPC.height = 32;
			NPC.aiStyle = 1;
			NPC.damage = 17;
			NPC.defense = 10;
			NPC.lifeMax = 75;
			NPC.HitSound = SoundID.NPCHit1;
			NPC.DeathSound = SoundID.NPCDeath1;
			NPC.value = 150f;
      AnimationType = NPCID.BlueSlime;
		}

    public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry)
    {
			bestiaryEntry.Info.AddRange(new IBestiaryInfoElement[] {
				BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.Caverns,

				new FlavorTextBestiaryInfoElement("Even tho they are infused with Infernal powers, they collapse in lava.")
			});
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo) {
			if (spawnInfo.Player.ZoneDungeon || spawnInfo.Player.ZoneJungle || spawnInfo.Player.ZoneSnow ||
          spawnInfo.Player.ZoneUndergroundDesert || spawnInfo.Player.ZoneGlowshroom || spawnInfo.Player.ZoneCrimson ||
          spawnInfo.Player.ZoneCorrupt || spawnInfo.Player.ZoneHallow)
        return spawnInfo.Player.ZoneRockLayerHeight ? 0f : 0f;

      if (!Main.hardMode)
          return spawnInfo.Player.ZoneRockLayerHeight ? 0.1f : 0f;

          else
          return spawnInfo.Player.ZoneRockLayerHeight ? 0.4f : 0f;
		}

		public override void AI()
        {
            NPC.ai[0]++;
            Player P = Main.player[NPC.target];
            if (NPC.target < 0 || NPC.target == 255 || Main.player[NPC.target].dead || !Main.player[NPC.target].active)
            {
                NPC.TargetClosest(true);
            }
            NPC.netUpdate = true;
        }
    
    public override void ModifyNPCLoot(NPCLoot npcLoot)
    {
			var slimeDropRules = Main.ItemDropsDB.GetRulesForNPCID(NPCID.BlueSlime, false);
			foreach (var slimeDropRule in slimeDropRules)
      {
				npcLoot.Add(slimeDropRule);
			}
			npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<InfernalOre>(),5,1,3));
		}
	}
}