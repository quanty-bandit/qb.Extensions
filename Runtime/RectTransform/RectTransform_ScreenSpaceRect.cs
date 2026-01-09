
using UnityEngine;
namespace Extensions.RectTransform_ScreenSpaceRect
{
    public static class RectTransform_ScreenSpaceRect
    {
        /// <summary>
        /// Gets rect from screen coordonates
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public static Rect ScreenSpaceRect(this RectTransform target)
        {
            Vector2 size = Vector2.Scale(target.rect.size, target.lossyScale);
            float x = target.position.x + target.anchoredPosition.x;
            float y = Screen.height - target.position.y - target.anchoredPosition.y;

            return new Rect(x, y, size.x, size.y);            
        }
    }

}