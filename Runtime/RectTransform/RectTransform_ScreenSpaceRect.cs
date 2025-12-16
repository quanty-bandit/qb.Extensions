
using UnityEngine;
namespace Extensions.RectTransform_ScreenSpaceRect
{
    public static class RectTransform_ScreenSpaceRect
    {
        public static Rect ScreenSpaceRect(this RectTransform _target)
        {
            Vector2 size = Vector2.Scale(_target.rect.size, _target.lossyScale);
            float x = _target.position.x + _target.anchoredPosition.x;
            float y = Screen.height - _target.position.y - _target.anchoredPosition.y;

            return new Rect(x, y, size.x, size.y);            
        }
    }

}