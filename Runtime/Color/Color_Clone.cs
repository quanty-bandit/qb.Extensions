using UnityEngine;
namespace Extensions.Color_Clone
{
    public static class Color_Clone
    {
        public static Color Clone(this Color _src)
            => new Color(_src.r,_src.g,_src.b,_src.a);
        
    }
}
