
using UnityEngine;
namespace Extensions.RectTransform_ScreenPosition
{
    public static class RectTransform_ScreenPosition
    {
        /// <summary>
        /// Gets the position from screen coordonates 
        /// </summary>
        /// <param name="target"></param>
        /// <param name="camera"></param>
        /// <returns></returns>
        public static Vector2 ScreenPosition(this RectTransform target,Camera camera)
        {
            Vector2 screenCenter = new Vector2(Screen.currentResolution.width / 2,
                                    Screen.currentResolution.height / 2);

            return  (Vector2)camera.WorldToScreenPoint(target.position) - screenCenter;
        }
    }
}
