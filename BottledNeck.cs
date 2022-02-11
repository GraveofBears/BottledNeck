using BepInEx;
using ItemManager;
using UnityEngine;
using CreatureManager;
using ServerSync;
using HarmonyLib;


namespace BottledNeck
{
	[BepInPlugin(ModGUID, ModName, ModVersion)]
	public class BottleNeck : BaseUnityPlugin
	{
		private const string ModName = "BottledNeck";
		private const string ModVersion = "0.1.0";
		private const string ModGUID = "org.bepinex.plugins.bottledneck";

		public void Awake()

		{
			Creature BabySpiritNeck = new("bottledneck", "BabySpiritNeck")            //add creature
			{
				Biome = Heightmap.Biome.None,
				CanSpawn = true,
				CanBeTamed = false,
				SpawnChance = 100,
				GroupSize = new Range(1, 2),
				Maximum = 1
			};
			BabySpiritNeck.Drops["NeckTail"].Amount = new Range(1, 2);
			BabySpiritNeck.Drops["NeckTail"].DropChance = 50f;

			Creature BabyFrostNeck = new("bottledneck", "BabyFrostNeck")            //add creature
			{
				Biome = Heightmap.Biome.None,
				CanSpawn = true,
				CanBeTamed = false,
				SpawnChance = 100,
				GroupSize = new Range(1, 2),
				Maximum = 1
			};
			BabyFrostNeck.Drops["NeckTail"].Amount = new Range(1, 2);
			BabyFrostNeck.Drops["NeckTail"].DropChance = 50f;

			Creature BabyFlameNeck = new("bottledneck", "BabyFlameNeck")            //add creature
			{
				Biome = Heightmap.Biome.None,
				CanSpawn = true,
				CanBeTamed = false,
				SpawnChance = 100,
				GroupSize = new Range(1, 2),
				Maximum = 1
			};
			BabyFlameNeck.Drops["NeckTail"].Amount = new Range(1, 2);
			BabyFlameNeck.Drops["NeckTail"].DropChance = 50f;

			Creature WildFrostNeck = new("bottledneck", "WildFrostNeck")            //add creature
			{
				Biome = Heightmap.Biome.Mountain,
				CanSpawn = true,
				CanBeTamed = true,
				FoodItems = "NecksTeddy, QueensJam, Eyescream",
				SpawnChance = 10,
				GroupSize = new Range(2, 3),
				CheckSpawnInterval = 300,
				SpecificSpawnTime = SpawnTime.Always,
				Maximum = 3
			};
			WildFrostNeck.Drops["NeckTail"].Amount = new Range(1, 2);
			WildFrostNeck.Drops["NeckTail"].DropChance = 100f;
			WildFrostNeck.Drops["Crystal"].Amount = new Range(1, 2);
			WildFrostNeck.Drops["Crystal"].DropChance = 100f;
			WildFrostNeck.Drops["TrophyNeck"].Amount = new Range(1, 2);
			WildFrostNeck.Drops["TrophyNeck"].DropChance = 50f;

			Creature WildFlameNeck = new("bottledneck", "WildFlameNeck")            //add creature
			{
				Biome = Heightmap.Biome.Swamp,
				CanSpawn = true,
				CanBeTamed = true,
				FoodItems = "NecksTeddy, QueensJam, Eyescream",
				SpawnChance = 10,
				GroupSize = new Range(2, 3),
				CheckSpawnInterval = 300,
				SpecificSpawnTime = SpawnTime.Always,
				Maximum = 3
			};
			WildFlameNeck.Drops["NeckTail"].Amount = new Range(1, 2);
			WildFlameNeck.Drops["NeckTail"].DropChance = 100f;
			WildFlameNeck.Drops["SurtlingCore"].Amount = new Range(1, 2);
			WildFlameNeck.Drops["SurtlingCore"].DropChance = 100f;
			WildFlameNeck.Drops["TrophyNeck"].Amount = new Range(1, 2);
			WildFlameNeck.Drops["TrophyNeck"].DropChance = 50f;

			Creature WildSpiritNeck = new("bottledneck", "WildSpiritNeck")            //add creature
			{
				Biome = Heightmap.Biome.BlackForest,
				CanSpawn = true,
				CanBeTamed = true,
				FoodItems = "NecksTeddy, QueensJam, Eyescream",
				SpawnChance = 50,
				GroupSize = new Range(2, 3),
				CheckSpawnInterval = 300,
				RequiredWeather = Weather.Rain,
				SpecificSpawnTime = SpawnTime.Day,
				Maximum = 3
			};
			WildSpiritNeck.Drops["NeckTail"].Amount = new Range(1, 2);
			WildSpiritNeck.Drops["NeckTail"].DropChance = 100f;
			WildSpiritNeck.Drops["TrophyNeck"].Amount = new Range(1, 2);
			WildSpiritNeck.Drops["TrophyNeck"].DropChance = 50f;

			Item NecksTeddy = new("bottledneck", "NecksTeddy");           //add item
			NecksTeddy.Crafting.Add(CraftingTable.None, 1);
			NecksTeddy.RequiredItems.Add("SwordCheat", 1);
			NecksTeddy.CraftAmount = 1;

			Item SummonedNeckHat = new("bottledneck", "SummonedNeckHat");           //add item
			SummonedNeckHat.Crafting.Add(CraftingTable.None, 1);
			SummonedNeckHat.RequiredItems.Add("SwordCheat", 1);
			SummonedNeckHat.CraftAmount = 1;

			Item FlameNeckHat = new("bottledneck", "FlameNeckHat");           //add item
			FlameNeckHat.Crafting.Add(CraftingTable.None, 1);
			FlameNeckHat.RequiredItems.Add("SwordCheat", 1);
			FlameNeckHat.CraftAmount = 1;

			Item FlameNeckArmor = new("bottledneck", "FlameNeckArmor");           //add item
			FlameNeckArmor.Crafting.Add(CraftingTable.None, 1);
			FlameNeckArmor.RequiredItems.Add("SwordCheat", 1);
			FlameNeckArmor.CraftAmount = 1;

			Item SummonedNeckHelmet = new("bottledneck", "SummonedNeckHelmet");           //add item
			SummonedNeckHelmet.Crafting.Add(CraftingTable.None, 1);
			SummonedNeckHelmet.RequiredItems.Add("SwordCheat", 1);
			SummonedNeckHelmet.CraftAmount = 1;

			Item SummonedNeckGuard = new("bottledneck", "SummonedNeckGuard");           //add item
			SummonedNeckGuard.Crafting.Add(CraftingTable.None, 1);
			SummonedNeckGuard.RequiredItems.Add("SwordCheat", 1);
			SummonedNeckGuard.CraftAmount = 1;

			Item NeckClub = new("bottledneck", "NeckClub");           //add item
			NeckClub.Crafting.Add(CraftingTable.None, 1);
			NeckClub.RequiredItems.Add("SwordCheat", 1);
			NeckClub.CraftAmount = 1;

			Item NeckFryPan = new("bottledneck", "NeckFryPan");  //add item
			NeckFryPan.Crafting.Add(CraftingTable.None, 1);
			NeckFryPan.RequiredItems.Add("SwordCheat", 1);
			NeckFryPan.CraftAmount = 1;

			Item NeckOnAStick = new("bottledneck", "NeckOnAStick");           //add item
			NeckOnAStick.Crafting.Add(CraftingTable.None, 1);
			NeckOnAStick.RequiredItems.Add("SwordCheat", 1);
			NeckOnAStick.CraftAmount = 1;

			Item SummonedNeckCrown = new("bottledneck", "SummonedNeckCrown");           //add item
			SummonedNeckCrown.Crafting.Add(CraftingTable.None, 1);
			SummonedNeckCrown.RequiredItems.Add("SwordCheat", 1);
			SummonedNeckCrown.CraftAmount = 1;

			Item SummonedNeckHalo = new("bottledneck", "SummonedNeckHalo");           //add item
			SummonedNeckHalo.Crafting.Add(CraftingTable.None, 1);
			SummonedNeckHalo.RequiredItems.Add("SwordCheat", 1);
			SummonedNeckHalo.CraftAmount = 1;

			Item MagicNeckStick = new("bottledneck", "MagicNeckStick");           //add item
			MagicNeckStick.Crafting.Add(CraftingTable.None, 1);
			MagicNeckStick.RequiredItems.Add("SwordCheat", 1);
			MagicNeckStick.CraftAmount = 1;

			Item HeroBlade = new("bottledneck", "HeroBlade");           //add item
			HeroBlade.Crafting.Add(CraftingTable.None, 1);
			HeroBlade.RequiredItems.Add("SwordCheat", 1);
			HeroBlade.CraftAmount = 1;

			Item BottledNeckBomb = new("bottledneck", "BottledNeckBomb");  //assetbundle name, Asset Name
			BottledNeckBomb.Crafting.Add(CraftingTable.Workbench, 1);
			BottledNeckBomb.RequiredItems.Add("TrophyNeck", 1);
			BottledNeckBomb.RequiredItems.Add("SurtlingCore", 1);
			BottledNeckBomb.CraftAmount = 1;

			GameObject BottleNeckProjectile = ItemManager.PrefabManager.RegisterPrefab("bottledneck", "BottleNeckProjectile"); //register projectile

			new Harmony(ModName).PatchAll();
			

		}


		[HarmonyPatch(typeof(MonsterAI), nameof(MonsterAI.Start))]
		static class MonsterAI_Start_Patch
		{
			static void Postfix(MonsterAI __instance)
			{
				if (Player.m_localPlayer && __instance.gameObject.name.Contains("PetNeck") && __instance.m_nview.IsOwner())
				{
					__instance.ResetPatrolPoint();
					__instance.SetFollowTarget(Player.m_localPlayer.gameObject);
				}

			}
		}
	}		
	
}