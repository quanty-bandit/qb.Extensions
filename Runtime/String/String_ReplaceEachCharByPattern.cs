using UnityEngine;
namespace Extensions.String_ReplaceEachCharByPattern
{
    public static class String_ReplaceEachCharByPattern
    {
        public static string ReplaceEachCharByPattern(this string str, int index, int length, string replacePattern)
        {
            int l = Mathf.Min(length, str.Length - index);
            string r = "";
            for (int i = 0; i < l; i++)
            {
                r += replacePattern;
            }
            return str.Remove(index, l)
                    .Insert(index, r);
        }
    }
}