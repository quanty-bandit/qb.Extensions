using UnityEngine;
namespace Extensions.RectTransform_ScreenPointToScreenUV
{
    public static class RectTransform_ScreenPointToScreenUV
    {
        /// <summary>
        /// Converts a screen point in screen uv
        /// </summary>
        /// <param name="rectTransform">RectTrasnform source</param>
        /// <param name="position">The input screen position</param>
        /// <param name="camera">
        /// The camera to isUsed to make the conversion the parameter.
        /// This parameter can be null in case of canvas screen space mode
        /// </param>
        /// <returns>The uv result</returns>
        public static Vector2 ScreenPointToScreenUV(this RectTransform rectTransform,Vector2 position, Camera camera)
        {
            RectTransformUtility.ScreenPointToLocalPointInRectangle(rectTransform, position, camera, out var localPointOnRect);
            var rectSize = rectTransform.rect.size;
            return (localPointOnRect + rectTransform.pivot * rectSize) / rectSize;
        }

        /// <summary>
        /// Converts a screen point in screen uv for canvas mode in screen space
        /// </summary>
        /// <param name="rectTransform">RectTrasnform source</param>
        /// <param name="position">The input screen position</param>
        /// <returns>The uv result</returns>
        public static Vector2 ScreenPointToScreenUV(this RectTransform rectTransform, Vector2 position)=> ScreenPointToScreenUV(rectTransform, position, null);

    }
}
