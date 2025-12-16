using UnityEngine;
namespace Extensions.Color_Blend
{
    public static class Color_Blend
    {
        /// <summary>
        /// Blends two colors with a specified ratio.
        /// Source code from: https://github.com/adammyhre/Unity-Utils/blob/master/UnityUtils/Scripts/Extensions/ColorExtensions.cs        /// </summary>
        /// </summary>
        /// <param name="color1">The first color.</param>
        /// <param name="color2">The second color.</param>
        /// <param name="ratio">The blend ratio (0 to 1).</param>
        /// <returns>The blended color.</returns>
        public static Color Blend(this Color color1, Color color2, float ratio)
        {
            ratio = Mathf.Clamp01(ratio);
            var iRatio = 1 - ratio;
            return new Color(
                color1.r * iRatio + color2.r * ratio,
                color1.g * iRatio + color2.g * ratio,
                color1.b * iRatio + color2.b * ratio,
                color1.a * iRatio + color2.a * ratio
            );
        }
    }
}
