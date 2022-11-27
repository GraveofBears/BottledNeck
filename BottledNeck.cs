using BepInEx;
using ItemManager;
using UnityEngine;
using CreatureManager;
using ServerSync;
using HarmonyLib;
using PieceManager;



namespace BottledNeck
{
	[BepInPlugin(ModGUID, ModName, ModVersion)]
	public class BottleNeck : BaseUnityPlugin
	{
		private const string ModName = "BottledNeck";
		private const string ModVersion = "0.2.13";
		private const string ModGUID = "org.bepinex.plugins.bottledneck";

		public void Awake()

		{	
			Creature BabyTarNeck = new("bottledneck", "BabyTarNeck")            //add creature
			{
				Biome = Heightmap.Biome.None,
				CanSpawn = true,
				SpawnChance = 100,
				GroupSize = new Range(1, 2),
				Maximum = 1
				
			};
			BabyTarNeck.Drops["NeckTail"].Amount = new Range(1, 2);
			BabyTarNeck.Drops["NeckTail"].DropChance = 50f;

			Creature BabySpiritNeck = new("bottledneck", "BabySpiritNeck")            //add creature
			{
				Biome = Heightmap.Biome.None,
				CanSpawn = true,
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
				FoodItems = "NeckToy, QueensJam, Eyescream",
				SpawnChance = 10,
				GroupSize = new Range(2, 3),
				CheckSpawnInterval = 300,
				SpecificSpawnTime = SpawnTime.Always,
				Maximum = 3
			};
			WildFrostNeck.Localize().English("WildFrostNeck");
			WildFrostNeck.Drops["NeckTail"].Amount = new Range(1, 2);
			WildFrostNeck.Drops["NeckTail"].DropChance = 100f;
			WildFrostNeck.Drops["Crystal"].Amount = new Range(1, 2);
			WildFrostNeck.Drops["Crystal"].DropChance = 100f;
			WildFrostNeck.Drops["TrophyFrostNeck"].Amount = new Range(1, 2);
			WildFrostNeck.Drops["TrophyFrostNeck"].DropChance = 20f;

			Creature WildFlameNeck = new("bottledneck", "WildFlameNeck")            //add creature
			{
				Biome = Heightmap.Biome.Swamp,
				CanSpawn = true,
				CanBeTamed = true,
				FoodItems = "NeckToy, QueensJam, Eyescream",
				SpawnChance = 10,
				GroupSize = new Range(2, 3),
				CheckSpawnInterval = 300,
				SpecificSpawnTime = SpawnTime.Always,
				Maximum = 3
			};
			WildFlameNeck.Localize().English("WildFlameNeck");
			WildFlameNeck.Drops["NeckTail"].Amount = new Range(1, 2);
			WildFlameNeck.Drops["NeckTail"].DropChance = 100f;
			WildFlameNeck.Drops["SurtlingCore"].Amount = new Range(1, 2);
			WildFlameNeck.Drops["SurtlingCore"].DropChance = 100f;
			WildFlameNeck.Drops["TrophyFlameNeck"].Amount = new Range(1, 2);
			WildFlameNeck.Drops["TrophyFlameNeck"].DropChance = 20f;

			Creature WildSpiritNeck = new("bottledneck", "WildSpiritNeck")            //add creature
			{
				Biome = Heightmap.Biome.BlackForest,
				CanSpawn = true,
				CanBeTamed = true,
				FoodItems = "NeckToy, QueensJam, Eyescream",
				SpawnChance = 50,
				GroupSize = new Range(2, 3),
				CheckSpawnInterval = 300,
				RequiredWeather = Weather.Rain,
				SpecificSpawnTime = SpawnTime.Always,
				Maximum = 3
			};
			WildSpiritNeck.Localize().English("WildSpiritNeck");
			WildSpiritNeck.Drops["NeckTail"].Amount = new Range(1, 2);
			WildSpiritNeck.Drops["NeckTail"].DropChance = 100f;
			WildSpiritNeck.Drops["TrophySpiritNeck"].Amount = new Range(1, 2);
			WildSpiritNeck.Drops["TrophySpiritNeck"].DropChance = 20f;

			Creature WildTarNeck = new("bottledneck", "WildTarNeck")            //add creature
			{
				Biome = Heightmap.Biome.Plains,
				CanSpawn = true,
				CanBeTamed = true,
				FoodItems = "NeckToy, QueensJam, Eyescream",
				SpawnChance = 50,
				GroupSize = new Range(2, 3),
				CheckSpawnInterval = 300,
				RequiredWeather = Weather.ClearSkies,
				SpecificSpawnTime = SpawnTime.Always,
				Maximum = 3
			};
			WildTarNeck.Localize().English("WildTarNeck");
			WildTarNeck.Drops["NeckTail"].Amount = new Range(1, 2);
			WildTarNeck.Drops["NeckTail"].DropChance = 100f;
			WildTarNeck.Drops["TrophyTarNeck"].Amount = new Range(1, 2);
			WildTarNeck.Drops["TrophyTarNeck"].DropChance = 20f;
			WildTarNeck.Drops["Tar"].Amount = new Range(1, 2);
			WildTarNeck.Drops["Tar"].DropChance = 50f;

			Creature WildColossalNeck = new("bottledneck", "WildColossalNeck")            //add creature
			{
				Biome = Heightmap.Biome.DeepNorth,
				CanSpawn = true,
				CanBeTamed = true,
				FoodItems = "TrophyTarNeck, TrophySpiritNeck, TrophyFlameNeck, TrophyFrostNeck",
				SpawnChance = 10,
				GroupSize = new Range(1, 2),
				CheckSpawnInterval = 300,
				RequiredWeather = Weather.DeepNorthSnowStorm,
				SpecificSpawnTime = SpawnTime.Night,
				Maximum = 1
			};
			WildColossalNeck.Localize().English("WildColossalNeck");
			WildColossalNeck.Drops["NeckTail"].Amount = new Range(1, 2);
			WildColossalNeck.Drops["NeckTail"].DropChance = 100f;
			WildColossalNeck.Drops["BottledNeckBomb"].Amount = new Range(1, 2);
			WildColossalNeck.Drops["BottledNeckBomb"].DropChance = 20f;
			WildColossalNeck.Drops["NeckToy"].Amount = new Range(1, 2);
			WildColossalNeck.Drops["NeckToy"].DropChance = 20f;

            Item WildFlameNeckEgg = new("bottledneck", "WildFlameNeckEgg");
            WildFlameNeckEgg.Name.English("Wild FlameNeck Egg");
            WildFlameNeckEgg.Description.English("A Flame Neck Egg.");
            WildFlameNeckEgg.Crafting.Add(ItemManager.CraftingTable.ArtisanTable, 10);
            WildFlameNeckEgg.RequiredItems.Add("SwordCheat", 1);
            WildFlameNeckEgg.CraftAmount = 1;

            Item WildFrostNeckEgg = new("bottledneck", "WildFrostNeckEgg");
            WildFrostNeckEgg.Name.English("Wild FrostNeck Egg");
            WildFrostNeckEgg.Description.English("A Frost Neck Egg.");
            WildFrostNeckEgg.Crafting.Add(ItemManager.CraftingTable.ArtisanTable, 10);
            WildFrostNeckEgg.RequiredItems.Add("SwordCheat", 1);
            WildFrostNeckEgg.CraftAmount = 1;

            Item WildSpiritNeckEgg = new("bottledneck", "WildSpiritNeckEgg");
            WildSpiritNeckEgg.Name.English("Wild SpiritNeck Egg");
            WildSpiritNeckEgg.Description.English("A Spirit Neck Egg.");
            WildSpiritNeckEgg.Crafting.Add(ItemManager.CraftingTable.ArtisanTable, 10);
            WildSpiritNeckEgg.RequiredItems.Add("SwordCheat", 1);
            WildSpiritNeckEgg.CraftAmount = 1;

            Item WildTarNeckEgg = new("bottledneck", "WildTarNeckEgg");
            WildTarNeckEgg.Name.English("Wild TarNeck Egg");
            WildTarNeckEgg.Description.English("A Tar Neck Egg.");
            WildTarNeckEgg.Crafting.Add(ItemManager.CraftingTable.ArtisanTable, 10);
            WildTarNeckEgg.RequiredItems.Add("SwordCheat", 1);
            WildTarNeckEgg.CraftAmount = 1;

            Item TrophyFlameNeck = new("bottledneck", "TrophyFlameNeck");
            TrophyFlameNeck.Name.English("TrophyFlameNeck");
            TrophyFlameNeck.Description.English("A Flame Neck Trophy.");
            TrophyFlameNeck.Crafting.Add(ItemManager.CraftingTable.ArtisanTable, 10);
            TrophyFlameNeck.RequiredItems.Add("SwordCheat", 1);
            TrophyFlameNeck.CraftAmount = 1;

            Item TrophyFrostNeck = new("bottledneck", "TrophyFrostNeck");
			TrophyFrostNeck.Name.English("TrophyFrostNeck");
			TrophyFrostNeck.Description.English("A Frost Neck Trophy.");
			TrophyFrostNeck.Crafting.Add(ItemManager.CraftingTable.ArtisanTable, 10);
			TrophyFrostNeck.RequiredItems.Add("SwordCheat", 1);
			TrophyFrostNeck.CraftAmount = 1;

			Item TrophySpiritNeck = new("bottledneck", "TrophySpiritNeck");
			TrophySpiritNeck.Name.English("TrophySpiritNeck");
			TrophySpiritNeck.Description.English("A Spirit Neck Trophy.");
			TrophySpiritNeck.Crafting.Add(ItemManager.CraftingTable.ArtisanTable, 10);
			TrophySpiritNeck.RequiredItems.Add("SwordCheat", 1);
			TrophySpiritNeck.CraftAmount = 1;

			Item TrophyTarNeck = new("bottledneck", "TrophyTarNeck");
			TrophyTarNeck.Name.English("TrophyTarNeck");
			TrophyTarNeck.Description.English("A Tar Neck Trophy.");
			TrophyTarNeck.Crafting.Add(ItemManager.CraftingTable.ArtisanTable, 10);
			TrophyTarNeck.RequiredItems.Add("SwordCheat", 1);
			TrophyTarNeck.CraftAmount = 1;

			Item NecksTeddy = new("bottledneck", "NecksTeddy");
			NecksTeddy.Crafting.Add(ItemManager.CraftingTable.ArtisanTable, 10);
			NecksTeddy.RequiredItems.Add("SwordCheat", 1);
			NecksTeddy.CraftAmount = 1;

			Item SummonedNeckHat = new("bottledneck", "SummonedNeckHat");           //add item
			SummonedNeckHat.Crafting.Add(ItemManager.CraftingTable.ArtisanTable, 10);
			SummonedNeckHat.RequiredItems.Add("SwordCheat", 1);
			SummonedNeckHat.CraftAmount = 1;

			Item FlameNeckHat = new("bottledneck", "FlameNeckHat");           //add item
			FlameNeckHat.Crafting.Add(ItemManager.CraftingTable.ArtisanTable, 10);
			FlameNeckHat.RequiredItems.Add("SwordCheat", 1);
			FlameNeckHat.CraftAmount = 1;

			Item FlameNeckArmor = new("bottledneck", "FlameNeckArmor");           //add item
			FlameNeckArmor.Crafting.Add(ItemManager.CraftingTable.ArtisanTable, 10);
			FlameNeckArmor.RequiredItems.Add("SwordCheat", 1);
			FlameNeckArmor.CraftAmount = 1;

			Item SummonedNeckHelmet = new("bottledneck", "SummonedNeckHelmet");           //add item
			SummonedNeckHelmet.Crafting.Add(ItemManager.CraftingTable.ArtisanTable, 10);
			SummonedNeckHelmet.RequiredItems.Add("SwordCheat", 1);
			SummonedNeckHelmet.CraftAmount = 1;

			Item SummonedNeckTopHat = new("bottledneck", "SummonedNeckTopHat");           //add item
			SummonedNeckTopHat.Crafting.Add(ItemManager.CraftingTable.ArtisanTable, 10);
			SummonedNeckTopHat.RequiredItems.Add("SwordCheat", 1);
			SummonedNeckTopHat.CraftAmount = 1;

			Item SummonedNeckGuard = new("bottledneck", "SummonedNeckGuard");           //add item
			SummonedNeckGuard.Crafting.Add(ItemManager.CraftingTable.ArtisanTable, 10);
			SummonedNeckGuard.RequiredItems.Add("SwordCheat", 1);
			SummonedNeckGuard.CraftAmount = 1;

			Item NeckClub = new("bottledneck", "NeckClub");           //add item
			NeckClub.Crafting.Add(ItemManager.CraftingTable.ArtisanTable, 10);
			NeckClub.RequiredItems.Add("SwordCheat", 1);
			NeckClub.CraftAmount = 1;

			Item NeckFryPan = new("bottledneck", "NeckFryPan");  //add item
			NeckFryPan.Crafting.Add(ItemManager.CraftingTable.ArtisanTable, 10);
			NeckFryPan.RequiredItems.Add("SwordCheat", 1);
			NeckFryPan.CraftAmount = 1;

			Item NeckOnAStick = new("bottledneck", "NeckOnAStick");           //add item
			NeckOnAStick.Crafting.Add(ItemManager.CraftingTable.ArtisanTable, 10);
			NeckOnAStick.RequiredItems.Add("SwordCheat", 1);
			NeckOnAStick.CraftAmount = 1;

			Item SummonedNeckCrown = new("bottledneck", "SummonedNeckCrown");           //add item
			SummonedNeckCrown.Crafting.Add(ItemManager.CraftingTable.ArtisanTable, 10);
			SummonedNeckCrown.RequiredItems.Add("SwordCheat", 1);
			SummonedNeckCrown.CraftAmount = 1;

			Item SummonedNeckWarlock = new("bottledneck", "SummonedNeckWarlock");           //add item
			SummonedNeckWarlock.Crafting.Add(ItemManager.CraftingTable.ArtisanTable, 10);
			SummonedNeckWarlock.RequiredItems.Add("SwordCheat", 1);
			SummonedNeckWarlock.CraftAmount = 1;

			Item SummonedNeckNoHat = new("bottledneck", "SummonedNeckNoHat");           //add item
			SummonedNeckNoHat.Crafting.Add(ItemManager.CraftingTable.ArtisanTable, 10);
			SummonedNeckNoHat.RequiredItems.Add("SwordCheat", 1);
			SummonedNeckNoHat.CraftAmount = 1;

			Item SummonedNeckHalo = new("bottledneck", "SummonedNeckHalo");           //add item
			SummonedNeckHalo.Crafting.Add(ItemManager.CraftingTable.ArtisanTable, 10);
			SummonedNeckHalo.RequiredItems.Add("SwordCheat", 1);
			SummonedNeckHalo.CraftAmount = 1;

			Item SummonedNeckArmyHelmet = new("bottledneck", "SummonedNeckArmyHelmet");           //add item
			SummonedNeckArmyHelmet.Crafting.Add(ItemManager.CraftingTable.ArtisanTable, 10);
			SummonedNeckArmyHelmet.RequiredItems.Add("SwordCheat", 1);
			SummonedNeckArmyHelmet.CraftAmount = 1;

			Item MagicNeckStick = new("bottledneck", "MagicNeckStick");           //add item
			MagicNeckStick.Crafting.Add(ItemManager.CraftingTable.ArtisanTable, 10);
			MagicNeckStick.RequiredItems.Add("SwordCheat", 1);
			MagicNeckStick.CraftAmount = 1;

			Item HeroBlade = new("bottledneck", "HeroBlade");           //add item
			HeroBlade.Crafting.Add(ItemManager.CraftingTable.ArtisanTable, 10);
			HeroBlade.RequiredItems.Add("SwordCheat", 1);
			HeroBlade.CraftAmount = 1;

			Item BottledNeckForeverBomb = new("bottledneck", "BottledNeckForeverBomb");           //add item
			BottledNeckForeverBomb.Crafting.Add(ItemManager.CraftingTable.ArtisanTable, 10);
			BottledNeckForeverBomb.RequiredItems.Add("SwordCheat", 1);
			BottledNeckForeverBomb.CraftAmount = 1;

			Item BottledNeckBomb = new("bottledneck", "BottledNeckBomb");  //assetbundle name, Asset Name
			BottledNeckBomb.Crafting.Add(ItemManager.CraftingTable.Workbench, 1);
			BottledNeckBomb.RequiredItems.Add("TrophyNeck", 3);
			BottledNeckBomb.RequiredItems.Add("SurtlingCore", 1);
			BottledNeckBomb.CraftAmount = 3;

			Item NeckToy = new("bottledneck", "NeckToy");  //assetbundle name, Asset Name
			NeckToy.Crafting.Add(ItemManager.CraftingTable.Workbench, 1);
			NeckToy.RequiredItems.Add("TrophyTarNeck", 1);
			NeckToy.RequiredItems.Add("TrophySpiritNeck", 1);
			NeckToy.RequiredItems.Add("TrophyFlameNeck", 1);
			NeckToy.RequiredItems.Add("TrophyFrostNeck", 1);
			NeckToy.CraftAmount = 1;

			Item NeckKingCrown = new("bottledneck", "NeckKingCrown");  //assetbundle name, Asset Name
			NeckKingCrown.Crafting.Add(ItemManager.CraftingTable.Workbench, 1);
			NeckKingCrown.RequiredItems.Add("TrophyTarNeck", 1);
			NeckKingCrown.RequiredItems.Add("TrophySpiritNeck", 1);
			NeckKingCrown.RequiredItems.Add("TrophyFlameNeck", 1);
			NeckKingCrown.RequiredItems.Add("TrophyFrostNeck", 1);
			NeckKingCrown.RequiredUpgradeItems.Add("TrophyTarNeck", 2);
			NeckKingCrown.RequiredUpgradeItems.Add("TrophySpiritNeck", 2);
			NeckKingCrown.RequiredUpgradeItems.Add("TrophyFlameNeck", 2);
			NeckKingCrown.RequiredUpgradeItems.Add("TrophyFrostNeck", 2);
			NeckKingCrown.CraftAmount = 1;

			Item NeckGuardHelmet = new("bottledneck", "NeckGuardHelmet");  //assetbundle name, Asset Name
			NeckGuardHelmet.Crafting.Add(ItemManager.CraftingTable.Workbench, 1);
			NeckGuardHelmet.RequiredItems.Add("TrophyTarNeck", 1);
			NeckGuardHelmet.RequiredItems.Add("TrophySpiritNeck", 1);
			NeckGuardHelmet.RequiredItems.Add("TrophyFlameNeck", 1);
			NeckGuardHelmet.RequiredItems.Add("TrophyFrostNeck", 1);
			NeckGuardHelmet.RequiredUpgradeItems.Add("TrophyTarNeck", 2);
			NeckGuardHelmet.RequiredUpgradeItems.Add("TrophySpiritNeck", 2);
			NeckGuardHelmet.RequiredUpgradeItems.Add("TrophyFlameNeck", 2);
			NeckGuardHelmet.RequiredUpgradeItems.Add("TrophyFrostNeck", 2);
			NeckGuardHelmet.CraftAmount = 1;

			Item NeckWarriorHelm = new("bottledneck", "NeckWarriorHelm");  //assetbundle name, Asset Name
			NeckWarriorHelm.Crafting.Add(ItemManager.CraftingTable.Workbench, 1);
			NeckWarriorHelm.RequiredItems.Add("TrophyTarNeck", 1);
			NeckWarriorHelm.RequiredItems.Add("TrophySpiritNeck", 1);
			NeckWarriorHelm.RequiredItems.Add("TrophyFlameNeck", 1);
			NeckWarriorHelm.RequiredItems.Add("TrophyFrostNeck", 1);
			NeckWarriorHelm.RequiredUpgradeItems.Add("TrophyTarNeck", 2);
			NeckWarriorHelm.RequiredUpgradeItems.Add("TrophySpiritNeck", 2);
			NeckWarriorHelm.RequiredUpgradeItems.Add("TrophyFlameNeck", 2);
			NeckWarriorHelm.RequiredUpgradeItems.Add("TrophyFrostNeck", 2);
			NeckWarriorHelm.CraftAmount = 1;

			Item NeckSword = new("bottledneck", "NeckSword");  //assetbundle name, Asset Name
			NeckSword.Crafting.Add(ItemManager.CraftingTable.Workbench, 1);
			NeckSword.RequiredItems.Add("TrophyTarNeck", 1);
			NeckSword.RequiredItems.Add("TrophySpiritNeck", 1);
			NeckSword.RequiredItems.Add("TrophyFlameNeck", 1);
			NeckSword.RequiredItems.Add("TrophyFrostNeck", 1);
			NeckSword.RequiredUpgradeItems.Add("TrophyTarNeck", 2);
			NeckSword.RequiredUpgradeItems.Add("TrophySpiritNeck", 2);
			NeckSword.RequiredUpgradeItems.Add("TrophyFlameNeck", 2);
			NeckSword.RequiredUpgradeItems.Add("TrophyFrostNeck", 2);
			NeckSword.CraftAmount = 1;

			Item NeckMageHelmet = new("bottledneck", "NeckMageHelmet");  //assetbundle name, Asset Name
			NeckMageHelmet.Crafting.Add(ItemManager.CraftingTable.Workbench, 1);
			NeckMageHelmet.RequiredItems.Add("TrophyTarNeck", 1);
			NeckMageHelmet.RequiredItems.Add("TrophySpiritNeck", 1);
			NeckMageHelmet.RequiredItems.Add("TrophyFlameNeck", 1);
			NeckMageHelmet.RequiredItems.Add("TrophyFrostNeck", 1);
			NeckMageHelmet.RequiredUpgradeItems.Add("TrophyTarNeck", 2);
			NeckMageHelmet.RequiredUpgradeItems.Add("TrophySpiritNeck", 2);
			NeckMageHelmet.RequiredUpgradeItems.Add("TrophyFlameNeck", 2);
			NeckMageHelmet.RequiredUpgradeItems.Add("TrophyFrostNeck", 2);
			NeckMageHelmet.CraftAmount = 1;

			Item NeckTrooperHelmet = new("bottledneck", "NeckTrooperHelmet");  //assetbundle name, Asset Name
			NeckTrooperHelmet.Crafting.Add(ItemManager.CraftingTable.Workbench, 1);
			NeckTrooperHelmet.RequiredItems.Add("TrophyTarNeck", 1);
			NeckTrooperHelmet.RequiredItems.Add("TrophySpiritNeck", 1);
			NeckTrooperHelmet.RequiredItems.Add("TrophyFlameNeck", 1);
			NeckTrooperHelmet.RequiredItems.Add("TrophyFrostNeck", 1);
			NeckTrooperHelmet.RequiredUpgradeItems.Add("TrophyTarNeck", 2);
			NeckTrooperHelmet.RequiredUpgradeItems.Add("TrophySpiritNeck", 2);
			NeckTrooperHelmet.RequiredUpgradeItems.Add("TrophyFlameNeck", 2);
			NeckTrooperHelmet.RequiredUpgradeItems.Add("TrophyFrostNeck", 2);
			NeckTrooperHelmet.CraftAmount = 1;

			Item NeckTopHat = new("bottledneck", "NeckTopHat");  //assetbundle name, Asset Name
			NeckTopHat.Crafting.Add(ItemManager.CraftingTable.Workbench, 1);
			NeckTopHat.RequiredItems.Add("TrophyTarNeck", 1);
			NeckTopHat.RequiredItems.Add("TrophySpiritNeck", 1);
			NeckTopHat.RequiredItems.Add("TrophyFlameNeck", 1);
			NeckTopHat.RequiredItems.Add("TrophyFrostNeck", 1);
			NeckTopHat.RequiredUpgradeItems.Add("TrophyTarNeck", 2);
			NeckTopHat.RequiredUpgradeItems.Add("TrophySpiritNeck", 2);
			NeckTopHat.RequiredUpgradeItems.Add("TrophyFlameNeck", 2);
			NeckTopHat.RequiredUpgradeItems.Add("TrophyFrostNeck", 2);
			NeckTopHat.CraftAmount = 1;

			Item NeckWarlockHat = new("bottledneck", "NeckWarlockHat");  //assetbundle name, Asset Name
			NeckWarlockHat.Crafting.Add(ItemManager.CraftingTable.Workbench, 1);
			NeckWarlockHat.RequiredItems.Add("TrophyTarNeck", 1);
			NeckWarlockHat.RequiredItems.Add("TrophySpiritNeck", 1);
			NeckWarlockHat.RequiredItems.Add("TrophyFlameNeck", 1);
			NeckWarlockHat.RequiredItems.Add("TrophyFrostNeck", 1);
			NeckWarlockHat.RequiredUpgradeItems.Add("TrophyTarNeck", 2);
			NeckWarlockHat.RequiredUpgradeItems.Add("TrophySpiritNeck", 2);
			NeckWarlockHat.RequiredUpgradeItems.Add("TrophyFlameNeck", 2);
			NeckWarlockHat.RequiredUpgradeItems.Add("TrophyFrostNeck", 2);
			NeckWarlockHat.CraftAmount = 1;

			Item NeckCudgel = new("bottledneck", "NeckCudgel");  //assetbundle name, Asset Name
			NeckCudgel.Crafting.Add(ItemManager.CraftingTable.Workbench, 1);
			NeckCudgel.RequiredItems.Add("TrophyTarNeck", 1);
			NeckCudgel.RequiredItems.Add("TrophySpiritNeck", 1);
			NeckCudgel.RequiredItems.Add("TrophyFlameNeck", 1);
			NeckCudgel.RequiredItems.Add("TrophyFrostNeck", 1);
			NeckCudgel.RequiredUpgradeItems.Add("TrophyTarNeck", 2);
			NeckCudgel.RequiredUpgradeItems.Add("TrophySpiritNeck", 2);
			NeckCudgel.RequiredUpgradeItems.Add("TrophyFlameNeck", 2);
			NeckCudgel.RequiredUpgradeItems.Add("TrophyFrostNeck", 2);
			NeckCudgel.CraftAmount = 1;

			Item TastyNeckTail = new("bottledneck", "TastyNeckTail");  //assetbundle name, Asset Name
			TastyNeckTail.Crafting.Add(ItemManager.CraftingTable.Cauldron, 1);
			TastyNeckTail.RequiredItems.Add("NeckTail", 2);
			TastyNeckTail.CraftAmount = 1;

			BuildPiece WildTarSpawner = new(PiecePrefabManager.RegisterAssetBundle("bottledneck"), "WildTarSpawner", true, "OdinsHollowWand");
			WildTarSpawner.Name.English("WildTarSpawner");
			WildTarSpawner.Description.English("A TarNeck Spawner Shroom");
			WildTarSpawner.RequiredItems.Add("SwordCheat", 1, false);
			WildTarSpawner.Category.Add(BuildPieceCategory.Misc);

			BuildPiece WildFlameSpawner = new(PiecePrefabManager.RegisterAssetBundle("bottledneck"), "WildFlameSpawner", true, "OdinsHollowWand");
			WildFlameSpawner.Name.English("WildFlameSpawner");
			WildFlameSpawner.Description.English("A FlameNeck Spawner Shroom");
			WildFlameSpawner.RequiredItems.Add("SwordCheat", 1, false);
			WildFlameSpawner.Category.Add(BuildPieceCategory.Misc);

			BuildPiece WildFrostSpawner = new(PiecePrefabManager.RegisterAssetBundle("bottledneck"), "WildFrostSpawner", true, "OdinsHollowWand");
			WildFrostSpawner.Name.English("WildFrostSpawner");
			WildFrostSpawner.Description.English("A FrostNeck Spawner Shroom");
			WildFrostSpawner.RequiredItems.Add("SwordCheat", 1, false);
			WildFrostSpawner.Category.Add(BuildPieceCategory.Misc);

			BuildPiece WildSpiritSpawner = new(PiecePrefabManager.RegisterAssetBundle("bottledneck"), "WildSpiritSpawner", true, "OdinsHollowWand");
			WildSpiritSpawner.Name.English("WildSpiritSpawner");
			WildSpiritSpawner.Description.English("A SpiritNeck Spawner Shroom");
			WildSpiritSpawner.RequiredItems.Add("SwordCheat", 1, false);
			WildSpiritSpawner.Category.Add(BuildPieceCategory.Misc);

			BuildPiece DancingNeckFriend = new("bottledneck", "DancingNeckFriend");
			DancingNeckFriend.Name.English("Dancing Neck Friend");
			DancingNeckFriend.Description.English("Dance Dance Dance!");
			DancingNeckFriend.RequiredItems.Add("TrophyFlameNeck", 1, true);
			DancingNeckFriend.RequiredItems.Add("TrophyFrostNeck", 1, true);
			DancingNeckFriend.RequiredItems.Add("TrophySpiritNeck", 1, true);
			DancingNeckFriend.RequiredItems.Add("TrophyTarNeck", 1, true);
			DancingNeckFriend.Category.Add(BuildPieceCategory.Furniture);


			GameObject BottleNeckForeverProjectile = ItemManager.PrefabManager.RegisterPrefab("bottledneck", "BottleNeckForeverProjectile"); //register projectile

			GameObject PetNeckForever = ItemManager.PrefabManager.RegisterPrefab("bottledneck", "PetNeckForever"); //register projectile

			GameObject BottleNeckProjectile = ItemManager.PrefabManager.RegisterPrefab("bottledneck", "BottleNeckProjectile"); //register projectile

			GameObject PetNeck = ItemManager.PrefabManager.RegisterPrefab("bottledneck", "PetNeck"); //register projectile

			new Harmony(ModName).PatchAll();			

		}
        /*
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
		}*/
    }
}		
	
