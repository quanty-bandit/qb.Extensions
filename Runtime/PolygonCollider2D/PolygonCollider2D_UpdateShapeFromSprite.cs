using System.Collections.Generic;
using UnityEngine;
namespace Extensions.PolygonCollider2D_UpdateShapeFromSprite
{
    public static class PolygonCollider2D_UpdateShapeFromSprite
    {

        /// <summary>
        /// Updates physics shape from sprite renderer
        /// </summary>
        /// <param name="self">The source to update</param>
        /// <param name="spriteRenderer">The sprite renderer input</param>
        public static void UpdateShapeFromSprite(this PolygonCollider2D self, SpriteRenderer spriteRenderer)
        {
            if(spriteRenderer != null)
                UpdateShapeFromSprite(self,spriteRenderer.sprite);
        }


        /// <summary>
        /// Updates physics shape from sprite 
        /// </summary>
        /// <param name="self">The source to update</param>
        /// <param name="spriteRenderer">The sprite renderer input</param>
        public static void UpdateShapeFromSprite(this PolygonCollider2D self, Sprite sprite)
        {
            if (sprite == null) return;

            int count = sprite.GetPhysicsShapeCount();
            self.pathCount = count;

            // new paths variable
            List<Vector2> path = new List<Vector2>();

            // loop path count
            for (int i = 0; i < count; i++)
            {
                // clear
                path.Clear();
                // get shape
                sprite.GetPhysicsShape(i, path);
                // set path
                self.SetPath(i, path.ToArray());

            }
        }


        /// <summary>
        /// Updates physics shape from attached sprite renderer if exists
        /// </summary>
        /// <param name="self">The source to update</param>
        public static void UpdateShapeFromSprite(this PolygonCollider2D self)=> UpdateShapeFromSprite(self, self.GetComponent<SpriteRenderer>());

    }
}
