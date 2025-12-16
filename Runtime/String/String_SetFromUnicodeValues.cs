using System.Collections.Generic;
namespace Extensions.String_SetFromUnicodeValues
{
    public static class String_SetFromUnicodeValues
    {
        public static string SetFromUnicodeValues(this string _str, List<int> _unicodeValues)
        {
            string str = "";
            foreach (var value in _unicodeValues)
            {
                str += System.Char.ConvertFromUtf32(value);
            }
            return str;
        }
        public static void SetFromUnicodeValues(this string _str, params int[] _unicodeValues)
        {
            _str = "";
            foreach (var value in _unicodeValues)
            {
                _str += System.Char.ConvertFromUtf32(value);
            }
        }
    }
}
