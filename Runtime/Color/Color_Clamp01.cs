using UnityEngine;
namespace Extensions.Color_Clamp01
{
    public static class Color_Clamp01
    {
        /// <summary>
        /// Returns a new color with each component clamped between 0 and 1.
        /// </summary>
        /// <param name="color">The color to clamp.</param>
        /// <returns>A color with r, g, b, and a components clamped to the [0, 1] range.</returns>
        public static Color Clamp01(this Color color)
        {
            return new Color
            {
                r = Mathf.Clamp01(color.r),
                g = Mathf.Clamp01(color.g),
                b = Mathf.Clamp01(color.b),
                a = Mathf.Clamp01(color.a)
            };
        }
    }
}
