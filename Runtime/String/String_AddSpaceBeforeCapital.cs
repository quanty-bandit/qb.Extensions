using System.Linq;

namespace Extensions.String_AddSpaceBeforeCapital 
{
    public static class String_AddSpaceBeforeCapital
    {
        /// <summary>
        /// Add a one space before each capital after the first charater of the string 
        /// </summary>
        /// <param name="self">The string source</param>
        /// <returns>A new string with added spaces</returns>
        public static string AddSpaceBeforeCapital(this string self)
        {
            return new string(self.SelectMany((c, i) => i > 0 && char.IsUpper(c) ? new[] { ' ', c } : new[] { c }).ToArray());
        }
    }

}