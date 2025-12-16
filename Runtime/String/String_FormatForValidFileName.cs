
namespace Extensions.String_FormatForValidFileName
{
    public static class String_FormatForValidFileName
    {
        /// <summary>
        /// Format the string by removing fisrt and last spaces,
        /// replace spaces by _ and remove invalid characters 
        /// </summary>
        /// <param name="str">the source string</param>
        /// <returns></returns>
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
