using UnityEngine;
namespace Extensions.Color_Clone
{
    /// <summary>
    /// Creates a copy of a Color instance.
    /// </summary>
    public static class Color_Clone
    {
        /// <summary>
        /// Creates a new Color instance with the same component values as the specified Color.
        /// </summary>
        /// <param name="_src">The source Color to clone.</param>
        /// <returns>A new Color with identical r, g, b, and a values.</returns>
        public static Color Clone(this Color _src)
            => new Color(_src.r,_src.g,_src.b,_src.a);
        
    }
}
