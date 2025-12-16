using UnityEngine;
using UnityEngine.UI;
namespace Extensions.Image_SetSprite
{
    public static class Image_SetSprite
    {
        public static void SetSprite(this Image _target,Sprite _sprite,bool _alignPivots=true)
        {
            _target.sprite = _sprite;
            if (_alignPivots && _sprite!=null)
            {
                var pivot = _sprite.pivot;
                var rect = _sprite.rect;
                if (pivot != null)
                {
                    pivot.x /= rect.width;
                    pivot.y /= rect.height;
                    _target.rectTransform.pivot = pivot;
                }
            }
        }
    }
}
