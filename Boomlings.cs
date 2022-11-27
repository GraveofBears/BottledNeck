using BepInEx;
using ItemManager;
using UnityEngine;

namespace Boomlings
{
    [BepInPlugin(ModGUID, ModName, ModVersion)]
    public class Boomlings : BaseUnityPlugin
    {
        private const string ModName = "Boomlings";
        private const string ModVersion = "0.0.9";
        private const string ModGUID = "org.bepinex.plugins.boomlings";

        public void Awake()

        {
    
            Item GreylingBomb = new Item("greylingbomb", "GreylingBomb", "BoomLing");  //assetbundle name, Asset Name, Folder Contiaining AssetBundle
            GreylingBomb.Crafting.Add(CraftingTable.Forge, 3);
            GreylingBomb.RequiredItems.Add("DragonTear", 3);
            GreylingBomb.RequiredItems.Add("Needle", 15);
            GreylingBomb.RequiredItems.Add("GoblinTotem", 2);
            GreylingBomb.RequiredUpgradeItems.Add("DragonTear", 3);
            GreylingBomb.RequiredUpgradeItems.Add("GoblinTotem", 2);
            GreylingBomb.CraftAmount = 1;

            GameObject Greyling_Projectile = ItemManager.PrefabManager.RegisterPrefab("greylingbomb", "Greyling_Projectile"); //projected prefab znet sync
            GameObject vfx_greyling_explode = ItemManager.PrefabManager.RegisterPrefab("greylingbomb", "vfx_greyling_explode"); //custom VFX attached to projected prefab

            Item TrollBomb = new Item("greylingbomb", "TrollBomb", "BoomLing");  //assetbundle name, Asset Name, Folder Contiaining AssetBundle
            TrollBomb.Crafting.Add(CraftingTable.Forge, 3);
            TrollBomb.RequiredItems.Add("DragonTear", 3);
            TrollBomb.RequiredItems.Add("Needle", 15);
            TrollBomb.RequiredItems.Add("GoblinTotem", 2);
            TrollBomb.RequiredUpgradeItems.Add("DragonTear", 3);
            TrollBomb.RequiredUpgradeItems.Add("GoblinTotem", 2);
            TrollBomb.CraftAmount = 1;

            GameObject Troll_Projectile = ItemManager.PrefabManager.RegisterPrefab("greylingbomb", "Troll_Projectile"); //projected prefab znet sync
            GameObject vfx_troll_explode = ItemManager.PrefabManager.RegisterPrefab("greylingbomb", "vfx_troll_explode"); //custom VFX attached to projected prefab
        }
    }
}
