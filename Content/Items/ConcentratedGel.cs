using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FlamethrowersExpanded.Content.Items
{
    public class ConcentratedGel : ModItem
    {
        public override void SetDefaults()
        {
            Item.damage = 3;
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

        public override bool PreDrawInWorld(SpriteBatch spriteBatch, Color lightColor, Color alphaColor, ref float rotation, ref float scale, int whoAmI)
        {
            Main.GetItemDrawFrame(Item.type, out Texture2D itemTexture, out Rectangle itemFrame);
            Vector2 drawOrigin = itemFrame.Size() / 2f;
            Vector2 drawPosition = Item.Bottom - Main.screenPosition - new Vector2(0, drawOrigin.Y);
            Color drawColor = new Color(0, 30, 160) * 0.7f;
            spriteBatch.Draw(itemTexture, drawPosition, itemFrame, drawColor, rotation, drawOrigin, scale, SpriteEffects.None, 0f);
            return false;
        }

        public override bool PreDrawInInventory(SpriteBatch spriteBatch, Vector2 position, Rectangle frame, Color drawColor, Color itemColor, Vector2 origin, float scale)
        {
            Texture2D itemTexture = ModContent.Request<Texture2D>(Texture).Value;
            Color color = new Color(0, 30, 160) * 0.7f;
            spriteBatch.Draw(itemTexture, position, frame, color, 0f, origin, scale, SpriteEffects.None, 0f);
            return false;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Gel, 3);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }
    }
}