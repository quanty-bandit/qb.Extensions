
namespace Extensions.String_FormatForValidFileName
{
    public static class String_FormatForValidFileName
    {
        /// <summary>
        /// Formats the string by removing first and last spaces,
        /// replaces spaces by the specified spaceReplaceString and removes invalid characters 
        /// </summary>
        /// <param name="str">the source string</param>
        /// <returns>The new formatted string</returns>
        public static string FormatForValidFileName(this string str,string spaceReplaceString="-")
        {
            var result = str.Trim().Replace(" ", spaceReplaceString);

            var invalidChar = System.IO.Path.GetInvalidFileNameChars();
            foreach (char c in invalidChar)
            {
                if (result.IndexOf($"{c}") != -1)
                    result = result.Replace($"{c}", "");
            }
            return result;
        }
    }
}
