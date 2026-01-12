
using System.Collections.Generic;
using System.Text;

namespace qb.Utility
{
    public static partial class StringUtility
    {
        /// <summary>
        /// Converts unicodes utf32 characters to a string
        /// </summary>
        /// <param name="unicodeValues">Unicodes utf32 characters source</param>
        /// <returns>The builded string from unicodes</returns>
        public static string ConvertUtf32(params int[] unicodeValues)
        {
            StringBuilder str = new StringBuilder();
            foreach (var value in unicodeValues)
            {
                str.Append(System.Char.ConvertFromUtf32(value));
            }
            return str.ToString();
        }
        /// <summary>
        /// Converts unicodes utf32 characters to a string
        /// </summary>
        /// <param name="unicodeValues">Unicodes utf32 characters source</param>
        /// <returns>The builded string from unicodes</returns>
        public static string ConvertUtf32(IEnumerable<int> unicodeValues)
        {
            StringBuilder str = new StringBuilder();
            foreach (var value in unicodeValues)
            {
                str.Append(System.Char.ConvertFromUtf32(value));
            }
            return str.ToString();
        }
    }
}
