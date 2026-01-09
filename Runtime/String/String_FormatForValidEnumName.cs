using Extensions.String_FormatForValidFileName;
namespace Extensions.String_FormatForValidEnumName
{
    public static class String_FormatForValidEnumName
    {
        /// <summary>
        /// Returns a formatted string valid to be an enum name by removing first and last spaces and replace spaces and - by _
        /// </summary>
        /// <param name="str"></param>
        /// <returns>The formatted string</returns>
        public static string FormatForValidEnumName(this string str)=> str.FormatForValidFileName("_").Replace("-", "_");
    }
}
