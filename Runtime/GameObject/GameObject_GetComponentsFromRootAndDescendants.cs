using Extensions.GameObject_GetComponentsFromDescendants;
using System.Collections.Generic;
using UnityEngine;
namespace Extensions.GameObject_GetComponentsFromRootAndDescendants
{
    public static class GameObject_GetComponentsFromRootAndDescendants
    {
        public static T[] GetComponentsFromRootAndDescendants<T>(this GameObject self)
        {
            List<T> result = new List<T>();
            T first = self.GetComponent<T>();
            if (first != null)
                result.Add(first);
            var seconds = self.GetComponentsFromDescendants<T>();
            if (seconds != null)
                result.AddRange(seconds);
            if(result.Count > 0)
                return result.ToArray();
            return null;
        }
    }
}
