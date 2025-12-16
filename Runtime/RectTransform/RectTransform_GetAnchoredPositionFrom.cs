
using UnityEngine;
namespace Extensions.RectTransform_GetAnchoredPositionFrom
{
    public static class RectTransform_GetAnchoredPositionFrom
    {
        public static Vector2 GetAnchoredPositionFrom(this RectTransform _target, RectTransform _from)
        {
            Vector2 localPoint;
            Vector2 fromPivotDerivedOffset = new Vector2(_target.rect.width * _target.pivot.x + _target.rect.xMin, _target.rect.height * _target.pivot.y + _target.rect.yMin);
            Vector2 screenP = RectTransformUtility.WorldToScreenPoint(null, _target.position);
            screenP += fromPivotDerivedOffset;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(_from, screenP, null, out localPoint);
            Vector2 pivotDerivedOffset = new Vector2(_from.rect.width * _from.pivot.x + _from.rect.xMin, _from.rect.height * _from.pivot.y + _from.rect.yMin);
            return _from.anchoredPosition + localPoint - pivotDerivedOffset;
        }
    }
}
