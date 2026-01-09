using System.Collections.Generic;
using UnityEngine;
namespace Extensions.GameObject_GetComponentsFromDescendants
{
    public static class GameObject_GetComponentsFromDescendants
    {
        /// <summary>
        /// Returns an array of components from all descendants of a game object or null if no component was founded. 
        /// </summary>
        /// <typeparam name="T">The type of component to get</typeparam>
        /// <param name="self">The parent source instance</param>
        /// <param name="reccursive">If set to true all descendant hierarchy is parsed, otherwise only the children are parsed</param>
        /// <returns>The founded components array or null</returns>
        public static T[] GetComponentsFromDescendants<T>(this GameObject self,bool reccursive = true)
        {
            List<T> result = new List<T>();
            if (reccursive)
            {
                ReccursiveGetComponentsInChildren(self, result);
            }
            else
            {
                self.GetComponentsInChildren<T>(true, result);
            }
            if (result.Count > 0)
                return result.ToArray();
            
            return null;
        }
        static void ReccursiveGetComponentsInChildren<T>(GameObject root, List<T> result)
        {
            foreach (Transform child in root.transform)
            {
                var f = child.GetComponents<T>();
                if (f != null && f.Length > 0) result.AddRange(f);
                ReccursiveGetComponentsInChildren(child.gameObject,result);
            }
        }
    }
}
