
using UnityEngine;
namespace Extensions.Color_Invert
{
    public static class Color_Invert
    {
        /// <summary>
        /// Inverts the color.
        /// Source code from: https://github.com/adammyhre/Unity-Utils/blob/master/UnityUtils/Scripts/Extensions/ColorExtensions.cs        /// </summary>
        /// </summary>
        /// <param name="color">The color to invert.</param>
        /// <returns>The inverted color.</returns>
        public static Color Invert(this Color color)
            => new(1 - color.r, 1 - color.g, 1 - color.b, color.a);
    }    
}
