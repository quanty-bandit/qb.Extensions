using Extensions.Color_Clamp01;
using UnityEngine;
namespace Extensions.Color_Add
{
    public static class Color_Add
    {
        /// <summary>
        /// Adds the RGBA components of two colors and clamps the result between 0 and 1.
        /// Source code from: https://github.com/adammyhre/Unity-Utils/blob/master/UnityUtils/Scripts/Extensions/ColorExtensions.cs
        /// </summary>
        /// <param name="thisColor">The first color.</param>
        /// <param name="otherColor">The second color.</param>
        /// <returns>A new color that is the sum of the two colors, clamped between 0 and 1.</returns>
        public static Color Add(this Color thisColor, Color otherColor)
            => (thisColor + otherColor).Clamp01();
    }
}
