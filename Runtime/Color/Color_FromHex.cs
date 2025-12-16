using System;
using UnityEngine;
namespace Extensions.Color_FromHex
{
    public static class Color_FromHex
    {
        /// <summary>
        /// Converts a hexadecimal string to a Color.
        /// Source code from: https://github.com/adammyhre/Unity-Utils/blob/master/UnityUtils/Scripts/Extensions/ColorExtensions.cs        /// </summary>
        /// </summary>
        /// <param name="hex">The hexadecimal string to convert.</param>
        /// <returns>The Color represented by the hexadecimal string.</returns>
        public static Color FromHex(this string hex)
        {
            if (ColorUtility.TryParseHtmlString(hex, out Color color))
                return color;

            throw new ArgumentException("Invalid hex string", nameof(hex));
        }
    }
}
