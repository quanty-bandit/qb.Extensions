using UnityEngine;
namespace Extensions.String_ReplaceAt
{
    public static class String_ReplaceAt 
    {
       public static string ReplaceAt(this string str, int index, int length, string replace)
       {
            return str.Remove(index, Mathf.Min(length, str.Length - index))
                    .Insert(index, replace);
       }
        

    }
}
