using System.Collections.Generic;
using UnityEngine;
namespace Extensions.GameObject_GetInterfacesFromDescendants 
{ 
    public static class GameObject_GetInterfacesFromDescendants
    {
        public static I[] GetInterfacesFromDescendants<I>(this GameObject self, bool reccursive = true) where I : MonoBehaviour
        {
            List<I> result = new List<I>();

            if (reccursive)
            {
                ReccursiveGetInterfacesInChildren(self, result);
            }
            else
            {
                self.GetInterfacesFromDescendants(result);
            }
            if (result.Count > 0)
                return result.ToArray();

            return null;
        }
        public static void GetInterfacesFromDescendants<I>(this GameObject self,List<I> interfaces) where I : MonoBehaviour
        {
            foreach (GameObject gameObject in self.transform)
            {
                GetInterfacesFromMonoBehaviours<I>(gameObject, interfaces);
            }
        }
        public static void GetInterfacesFromMonoBehaviours<I>(GameObject source,List<I> result) where I : MonoBehaviour
        {
            var behaviours = source.GetComponents<MonoBehaviour>();
            foreach (var beh in behaviours)
            {
                try
                {
                    if(beh is I)
                        result.Add(beh as I);
                }
                catch { }
            }
        }
        static void ReccursiveGetInterfacesInChildren<T>(GameObject root, List<T> result)
        {
            foreach (Transform child in root.transform)
            {
                var f = child.GetComponents<T>();
                if (f != null && f.Length > 0) result.AddRange(f);
                ReccursiveGetInterfacesInChildren(child.gameObject, result);
            }
        }

    }
}
