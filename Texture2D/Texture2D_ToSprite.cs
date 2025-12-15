using UnityEngine;
namespace Extensions.Texture2D_ToSprite
{
    public static class Texture2D_ToSprite
    {
        public static Sprite ToSprite(this Texture2D texture, Vector2 pivot, float pixelPerUnit = 100f)
        {
            return Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), pivot, pixelPerUnit);
        }

        public static Sprite ToSprite(this Texture2D texture, SpriteAlignment pivotPosition= SpriteAlignment.Center,float pixelPerUnit = 100f)
        {
            Vector2 pivot = new Vector2(0.5f,0.5f);
            switch (pivotPosition)
            {
                case SpriteAlignment.TopCenter:
                    pivot.y = 0;
                    break;
                case SpriteAlignment.BottomCenter:
                    pivot.y = 1;
                    break;
                case SpriteAlignment.BottomLeft:
                    pivot.y = 1;
                    pivot.x = 0;
                    break;
                case SpriteAlignment.BottomRight:
                    pivot.y = 1;
                    pivot.x = 1;
                    break;
                case SpriteAlignment.TopLeft:
                    pivot.x = 0;
                    pivot.y = 0;
                    break;
                case SpriteAlignment.TopRight:
                    pivot.x = 1;
                    pivot.y = 0;
                    break;
                case SpriteAlignment.LeftCenter:
                    pivot.x = 0;
                    pivot.y = 0.5f;
                    break;
                case SpriteAlignment.RightCenter:
                    pivot.x = 1;
                    pivot.y = 0.5f;
                    break;

            }
            return Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), pivot, pixelPerUnit);
        }
    }
}
