
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
namespace Extensions.Transform_FindDescendants
{
    public static class Transform_FindDescendants
    {
        /// <summary>
        /// Searches for descendant nodes whose names match the regular expression parameter.
        /// </summary>
        /// <param name="self">The root target</param>
        /// <param name="nameRegex">The regular expression to match on name</param>
        /// <param name="parseAllDescendants">true to look into the full descendants tree</param>
        /// <returns>An array of descendants found</returns>
        public static Transform[] FindDescendants(this Transform self,Regex nameRegex,bool parseAllDescendants = true)
        {
            List<Transform> result = new List<Transform>();
            if (parseAllDescendants)
            {
                ReccursiveFindDescendants(self,nameRegex,result);
            }
            else
            {
                FindChildren(self,nameRegex,result);  
            }
            return result.ToArray();
        }

        /// <summary>
        /// Searches for descendant nodes whose names are same as the seeked name.
        /// </summary>
        /// <param name="self">The root target</param>
        /// <param name="name">The name to seek</param>
        /// <param name="parseAllDescendants">True to look into the full decendants tree</param>
        /// <returns>Null if no child found or an array of children</returns>
        public static Transform[] FindDescendants(this Transform self, string name, bool parseAllDescendants = true)
        {
            Regex regex = new Regex(name);
            return FindDescendants(self,regex,parseAllDescendants);
        }

        /// <summary>
        /// Adds to result list the found descendants whose names match the regular expression parameter. 
        /// </summary>
        /// <param name="self">The root target</param>
        /// <param name="nameRegex">The regular expression to match on name</param>
        /// <param name="result">The list to append</param>
        public static void ReccursiveFindDescendants(this Transform self, Regex nameRegex, List<Transform> result)
        {
            foreach (Transform child in self)
            {
                if (nameRegex.IsMatch(child.name))
                {
                    result.Add(child);
                }
            }
            foreach (Transform child in self)
            {
                ReccursiveFindDescendants(child, nameRegex, result);
            }
        }
        /// <summary>
        /// Adds to result list the found children whose names match the regular expression parameter. 
        /// </summary>
        /// <param name="self">The rot target</param>
        /// <param name="nameRegex">The regular expression to match on name</param>
        /// <param name="result"></param>
        public static void FindChildren(this Transform self, Regex nameRegex, List<Transform> result)
        {
            foreach (Transform child in self)
            {
                if (nameRegex.IsMatch(child.name))
                {
                    result.Add(child);
                }
            }
        }
    }
}
