using System.Collections.Generic;
using UnityEngine;
namespace Extensions.GameObject_GetComponentsFromDescendants
{
    public static class GameObject_GetComponentsFromDescendants
    {
        
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
