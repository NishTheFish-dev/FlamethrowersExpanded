using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FlamethrowersExpanded.Content.Items
{
    public class Gel2 : ModItem
    {
        public override void SetDefaults()
        {
            Item.damage = 5;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 16;
            Item.height = 16;
            Item.maxStack = 9999;
            Item.consumable = true;
            Item.knockBack = 2f;
            Item.value = Item.buyPrice(copper: 1);
            Item.rare = ItemRarityID.White;
            Item.ammo = AmmoID.Gel;
        }

        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
    }
}