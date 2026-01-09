using Extensions.GameObject_GetComponentsFromDescendants;
using System.Collections.Generic;
using UnityEngine;
namespace Extensions.GameObject_GetComponentsFromRootAndDescendants
{
    public static class GameObject_GetComponentsFromRootAndDescendants
    {
        /// <summary>
        ///  Returns an array of components from a game object and its descendants or null if no component was founded. 
        /// </summary>
        /// <typeparam name="T">The type of component to get</typeparam>
        /// <param name="self">The source instance</param>
        /// <param name="reccursive">If set to true all descendant hierarchy is parsed, otherwise only the children are parsed</param>
        /// <returns>The founded components array or null</returns>
        public static T[] GetComponentsFromRootAndDescendants<T>(this GameObject self, bool reccursive = true)
        {
            List<T> result = new List<T>();
            T first = self.GetComponent<T>();
            if (first != null)
                result.Add(first);
            var seconds = self.GetComponentsFromDescendants<T>(reccursive);
            if (seconds != null)
                result.AddRange(seconds);
            if(result.Count > 0)
                return result.ToArray();
            return null;
        }
    }
}
