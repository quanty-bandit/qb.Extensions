using System;
using System.Text;

namespace Extensions.String_GetUnicodeValues
{
    public static class String_GetUnicodeValues
    {
        /// <summary>
        /// Returns the uft32 characters string values
        /// </summary>
        /// <param name="str">The source string</param>
        /// <returns>The array of utf32 character values</returns>
        public static int[] GetUnicodeValues(this string str)
        {
            byte[] rawUtf32AsBytes = Encoding.UTF32.GetBytes(str);
            int[] rawUtf32 = new int[rawUtf32AsBytes.Length / 4];
            Buffer.BlockCopy(rawUtf32AsBytes, 0, rawUtf32, 0, rawUtf32AsBytes.Length);
            return rawUtf32;
        }
    }
}
