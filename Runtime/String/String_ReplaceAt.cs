using UnityEngine;
namespace Extensions.String_ReplaceAt
{
    public static class String_ReplaceAt 
    {
        /// <summary>
        /// Returns a new string with the substring replacement at index 
        /// </summary>
        /// <param name="source">The source string</param>
        /// <param name="index">The index to start insert</param>
        /// <param name="length">The lenght of the source string to remove</param>
        /// <param name="replace">The replace string</param>
        /// <returns></returns>
       public static string ReplaceAt(this string source, int index, int length, string replace)
       {
            return source.Remove(index, Mathf.Min(length, source.Length - index))
                    .Insert(index, replace);
       }
        

    }
}
