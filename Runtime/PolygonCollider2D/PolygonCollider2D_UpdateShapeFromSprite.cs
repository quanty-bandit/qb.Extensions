using System.Collections.Generic;
using UnityEngine;
namespace Extensions.PolygonCollider2D_UpdateShapeFromSprite
{
    public static class PolygonCollider2D_UpdateShapeFromSprite
    {

        public static void UpdateShapeFromSprite(this PolygonCollider2D _target, SpriteRenderer _spriteRenderer)
        {
            var sprite = _spriteRenderer.sprite;

            int count = sprite.GetPhysicsShapeCount();
            _target.pathCount = count;

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
                _target.SetPath(i, path.ToArray());

            }
        }

        public static void UpdateShapeFromSprite(this PolygonCollider2D _target)
        {
            var spriteRenderer = _target.GetComponent<SpriteRenderer>();
            if (spriteRenderer == null || spriteRenderer.sprite == null) return;
            var sprite = spriteRenderer.sprite;

            int count = sprite.GetPhysicsShapeCount();
            _target.pathCount = count;

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
                _target.SetPath(i, path.ToArray());

            }
        }

    }
}
