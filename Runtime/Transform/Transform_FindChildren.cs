
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
namespace Extensions.Transform_FindChildren
{
    public static class Transform_FindChildren
    {
        /// <summary>
        /// Find children nodes wich names match with name regular expression 
        /// </summary>
        /// <param name="self">The root target</param>
        /// <param name="nameRegex">The regular expression to match</param>
        /// <param name="reccursive">true to look into the full descendants tree</param>
        /// <returns>Null if no child found or an array of children</returns>
        public static Transform[] FindChildren(this Transform self,Regex nameRegex,bool reccursive = true)
        {
            List<Transform> result = new List<Transform>();
            if (reccursive)
            {
                ReccursiveFindChildren(self,nameRegex,result);
            }
            else
            {
                FindChildren(self,nameRegex,result);  
            }
            if(result.Count > 0)
                return result.ToArray();
            else 
                return null;
        }

        /// <summary>
        /// Find children nodes wich names are same as name
        /// </summary>
        /// <param name="self">The root target</param>
        /// <param name="name">The name to seek</param>
        /// <param name="reccursive">true to look into the full decendents tree</param>
        /// <returns>Null if no child found or an array of children</returns>
        public static Transform[] FindChildren(this Transform self, string name, bool reccursive = true)
        {
            Regex regex = new Regex(name);
            return FindChildren(self,regex,reccursive);
        }


        static void ReccursiveFindChildren(Transform root, Regex namePattern, List<Transform> result)
        {
            foreach (Transform child in root)
            {
                if (namePattern.IsMatch(child.name))
                {
                    result.Add(child);
                }
                ReccursiveFindChildren(child, namePattern, result);
            }
        }
        static void FindChildren(Transform root, Regex namePattern, List<Transform> result)
        {
            foreach (Transform child in root)
            {
                if (namePattern.IsMatch(child.name))
                {
                    result.Add(child);
                }
            }
        }
    }
}
