using UnityEngine;
using UnityEngine.UI;
namespace Extensions.Image_SetSprite
{
    public static class Image_SetSprite
    {
        /// <summary>
        /// Sets the image sprite and align pivot if required
        /// </summary>
        /// <param name="self">The image source</param>
        /// <param name="sprite">The sprite to use</param>
        /// <param name="alignPivots">Sets to true to align the sprite pivot</param>
        public static void SetSprite(this Image self,Sprite sprite,bool alignPivots=true)
        {
            self.sprite = sprite;
            if (alignPivots && sprite!=null)
            {
                var pivot = sprite.pivot;
                var rect = sprite.rect;
                if (pivot != null)
                {
                    pivot.x /= rect.width;
                    pivot.y /= rect.height;
                    self.rectTransform.pivot = pivot;
                }
            }
        }
    }
}
