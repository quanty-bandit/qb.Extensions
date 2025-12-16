using Extensions.String_FormatForValidFileName;
namespace Extensions.String_FormatForValidEnumName
{
    public static class String_FormatForValidEnumName
    {
        public static string FormatForValidEnumName(this string str)
        {
            string result = str.FormatForValidFileName("_");
            return result.Replace("-", "_");
        }
    }
}
