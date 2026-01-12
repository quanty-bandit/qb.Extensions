using System.Collections.Generic;
using UnityEngine;

namespace Extensions.Transform_GetDescendants
{
    public static class Transform_GetDescendants
    {
        /// <summary>
        /// Returns the array of all descendants
        /// </summary>
        /// <param name="self">The root source</param>
        /// <returns>The flat array of all descendants</returns>
        public static Transform[] GetDescendants(this Transform self)
        {
            if (self.childCount == 0)
                return null;
            List<Transform> descendants = new List<Transform>();
            self.GetDescendants(descendants);
            return descendants.ToArray();
        }
        /// <summary>
        /// Appends the decendants list with all descendants  
        /// </summary>
        /// <param name="self">The root source</param>
        /// <param name="descendants">The descendants list to append</param>
        public static void GetDescendants(this Transform self, List<Transform> descendants)
        {
            foreach (Transform child in self)
            {
                descendants.Add(child);
            }
            foreach (Transform child in self)
            {
                child.GetDescendants(descendants);
            }
        }
    }
}
