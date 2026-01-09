
using UnityEngine;
namespace Extensions.RectTransform_GetAnchoredPositionFrom
{
    public static class RectTransform_GetAnchoredPositionFrom
    {
        /// <summary>
        /// Gets the anchored position from an other origin 
        /// </summary>
        /// <param name="source">The rectansform source</param>
        /// <param name="origin">The rectransform origin</param>
        /// <returns>The anchored position from origin</returns>
        public static Vector2 GetAnchoredPositionFrom(this RectTransform source, RectTransform origin)
        {
            Vector2 localPoint;
            Vector2 fromPivotDerivedOffset = new Vector2(source.rect.width * source.pivot.x + source.rect.xMin, source.rect.height * source.pivot.y + source.rect.yMin);
            Vector2 screenP = RectTransformUtility.WorldToScreenPoint(null, source.position);
            screenP += fromPivotDerivedOffset;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(origin, screenP, null, out localPoint);
            Vector2 pivotDerivedOffset = new Vector2(origin.rect.width * origin.pivot.x + origin.rect.xMin, origin.rect.height * origin.pivot.y + origin.rect.yMin);
            return origin.anchoredPosition + localPoint - pivotDerivedOffset;
        }
    }
}
