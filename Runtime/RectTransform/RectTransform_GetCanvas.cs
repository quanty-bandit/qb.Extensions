using UnityEngine;
namespace Extensions.RectTransform_GetCanvas
{
    public static class RectTransform_GetCanvas
    {
        /// <summary>
        /// Gets the parent canvas
        /// </summary>
        /// <param name="rectTransform"></param>
        /// <returns>The parent canvas</returns>
        public static Canvas GetCanvas(this RectTransform rectTransform)
        {
            return __GetCanvas(rectTransform);
        }
        static Canvas __GetCanvas(Transform rectTransform)
        {
            var parent = rectTransform.parent;
            if (parent == null)
                return null;

            var canvas = parent.GetComponent<Canvas>();
            if(canvas!=null)
                return canvas;

            return __GetCanvas(parent);
        }
    }
}
