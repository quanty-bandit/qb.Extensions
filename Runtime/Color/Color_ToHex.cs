using UnityEngine;
namespace Extensions.Color_ToHex
{
    public static class Color_ToHex
    {
        /// <summary>
        /// Converts a Color to a hexadecimal string.
        /// Source code from: https://github.com/adammyhre/Unity-Utils/blob/master/UnityUtils/Scripts/Extensions/ColorExtensions.cs        /// </summary>
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>A hexadecimal string representation of the color.</returns>
        public static string ToHex(this Color color)
            => $"#{ColorUtility.ToHtmlStringRGBA(color)}";
    }
}
