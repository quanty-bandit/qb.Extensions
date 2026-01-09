using System;
using UnityEngine;

namespace Extensions.Color_Contrast
{
    public static class Color_Contrast
    {
        /// <summary>
        /// Gets a new contrasted color from source
        /// </summary>
        /// <param name="_src"></param>
        /// <param name="_preserveOpacity"></param>
        /// <returns>A new contrasted color from the source</returns>
        public static Color Contrast(this Color _src, bool _preserveOpacity=true)
        {
            Color inputColor = _src;
            //If RGB values are close to each other by a diff less than 10%, then if RGB values are lighter side, decrease the blue by 50% (eventually it will increase in conversion below), if RBB values are on darker side, decrease yellow by about 50% (it will increase in conversion)
            float avgColorValue = (_src.r + _src.g + _src.b) / 3;
            float diff_r = Mathf.Abs(_src.r - avgColorValue);
            float diff_g = Mathf.Abs(_src.g - avgColorValue);
            float  diff_b = Mathf.Abs(_src.b - avgColorValue);
            if (diff_r < 0.0784f && diff_g < 0.0784f && diff_b < 0.0784f) //The color is a shade of gray
            {
                if (avgColorValue < 0.48f) //color is dark
                {
                    inputColor = new Color(0.86f, 0.9f, 0.196f, _src.a);
                }
                else
                {
                    inputColor = new Color( 1, 1, 0.196f, _src.a);
                }
            }
           
            if (!_preserveOpacity)
            {
                inputColor.a =  Math.Max(inputColor.a, 0.498f); //We don't want contrast color to be more than 50% transparent ever.
            }
            
            Color.RGBToHSV(inputColor, out float h, out float s, out float v);
            h += 0.5f;
            if (h > 1) h -= 1;
            
            Color rgba = Color.HSVToRGB(h, s, v);
            rgba.a = inputColor.a;
            return rgba;
        }

    }
}
