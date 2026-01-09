using UnityEngine;
namespace Extensions.String_ReplaceEachCharByPattern
{
    public static class String_ReplaceEachCharByPattern
    {
        /// <summary>
        /// Fills a part of a string by a pattern
        /// </summary>
        /// <param name="source">The source string</param>
        /// <param name="index">The start index</param>
        /// <param name="length">The charater count to replace</param>
        /// <param name="replacePattern">The replace pattern</param>
        /// <returns>A new string with pattern</returns>
        public static string ReplaceEachCharByPattern(this string source, int index, int length, string replacePattern)
        {
            int l = Mathf.Min(length, source.Length - index);
            string r = "";
            for (int i = 0; i < l; i++)
            {
                r += replacePattern;
            }
            return source.Remove(index, l)
                    .Insert(index, r);
        }
    }
}