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
using Endtime.Content.Items;

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
			if(spawnInfo.Player.ZoneDungeon || spawnInfo.Player.ZoneJungle || spawnInfo.Player.ZoneSnow ||
        spawnInfo.Player.ZoneUndergroundDesert || spawnInfo.Player.ZoneGlowshroom || spawnInfo.Player.ZoneCrimson ||
        spawnInfo.Player.ZoneCorrupt || spawnInfo.Player.ZoneHallow)
        	return spawnInfo.Player.ZoneRockLayerHeight ? 0f : 0f;

      if(!Main.hardMode)
          return spawnInfo.Player.ZoneRockLayerHeight && NPC.downedBoss2 ? 0.04f : 0f;

          else
          return spawnInfo.Player.ZoneRockLayerHeight && NPC.downedBoss2 ? 0.12f : 0f;
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

						Vector2 DustPos = NPC.position;
            int DustWidth = NPC.width;
            int DustHeight = NPC.height;
            int DustType = 6;
            float DustSpeedX = 0f;
            float DustSpeedY = 0f;
            int DustAlpha = 0;
            float DustSize = 1f;
            if (Main.rand.Next(5) == 0)
            {
              Dust.NewDust(DustPos, DustWidth, DustHeight, DustType, DustSpeedX, DustSpeedY, DustAlpha, default(Color), DustSize);
            }
        }
    
    public override void ModifyNPCLoot(NPCLoot npcLoot)
    {
			var slimeDropRules = Main.ItemDropsDB.GetRulesForNPCID(NPCID.BlueSlime, false);
			foreach (var slimeDropRule in slimeDropRules)
      {
				npcLoot.Add(slimeDropRule);
			}
			npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<InfernalOre>(),5,1,3));
			npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<InfernalFragment>(),3,1,1));
		}

		public override void OnHitPlayer(Player target, int damage, bool crit)
		{
			int buffType = BuffID.OnFire;
			int timeToAdd = 5 * 60;
			target.AddBuff(buffType, timeToAdd);
		}

		public override Color? GetAlpha(Color lightColor)
    {
        return Color.White;
    }
	}
}