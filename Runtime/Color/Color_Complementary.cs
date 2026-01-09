using UnityEngine;

namespace Extensions.Color_GetComplementary
{
    public static class Color_Complementary
    {
        /// <summary>
        /// Gets a new color filled with the complementaries values from the source color.
        /// </summary>
        /// <param name="_src">The extension instance source</param>
        /// <returns>A new color filled with the complementaries values from the source color</returns>
        public static Color Complementary(this Color _src)
        {
            if (_src.r == 0 && _src.g == 0 && _src.b == 0)
            {
                return new Color(1,1,1,_src.a);
            }
            else
            {
                if (_src.r == 1 && _src.g == 1 && _src.b == 1)
                {
                    return new Color(0, 0, 0, _src.a);
                }
            }

            Color.RGBToHSV(_src, out float h, out float s, out float v);
            h += 0.5f;
            if (h > 1) h -= 1;
            Color rgba = Color.HSVToRGB(h, s, v);
            rgba.a = _src.a;
            return rgba;
        }
    }
}
