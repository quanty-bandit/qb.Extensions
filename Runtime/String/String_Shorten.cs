using Extensions.String_IsBlank;

namespace Extensions.String_Shorten
{
    public static class String_Shorten
    {
        /// <summary>
        /// Shortens a string to the specified maximum length. If the string's length
        /// is less than the maxLength, the original string is returned.
        /// </summary>
        public static string Shorten(this string val, int maxLength)
        {
            if (val.IsBlank()) return val;
            return val.Length <= maxLength ? val : val.Substring(0, maxLength);
        }
    }
}
