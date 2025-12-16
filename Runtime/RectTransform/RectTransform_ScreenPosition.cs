
using UnityEngine;
namespace Extensions.RectTransform_ScreenPosition
{
    public static class RectTransform_ScreenPosition
    {
        public static Vector2 ScreenPosition(this RectTransform _target,Camera _camera)
        {
            Vector2 screenCenter = new Vector2(Screen.currentResolution.width / 2,
                                    Screen.currentResolution.height / 2);

            return  (Vector2)_camera.WorldToScreenPoint(_target.position) - screenCenter;
        }
    }
}
