using System.Collections.Generic;
using UnityEngine;
namespace Extensions.GameObject_GetInterfacesFromDescendants 
{ 
    public static class GameObject_GetInterfacesFromDescendants
    {
        /// <summary>
        /// Returns an array of interfaces from game object descendants or null if nothing was found. 
        /// </summary>
        /// <typeparam name="I">The interface type to get</typeparam>
        /// <param name="self">The source game object</param>
        /// <param name="reccursive">If set to true all descendant hierarchy is parsed, otherwise only the children are parsed</param>
        /// <returns>The founded interfaces array or null</returns>
        public static I[] GetInterfacesFromDescendants<I>(this GameObject self, bool reccursive = true) where I : MonoBehaviour
        {
            List<I> result = new List<I>();

            if (reccursive)
            {
                GetInterfacesFromDescendants(self, result);
            }
            else
            {
                self.GetInterfacesFromChildren(result);
            }
            if (result.Count > 0)
                return result.ToArray();

            return null;
        }
        /// <summary>
        /// Fills the interface provided list with interfaces found in the children
        /// </summary>
        /// <typeparam name="I">The interface type to get</typeparam>
        /// <param name="self">The source game object</param>
        /// <param name="interfaces">The list to fill with the result</param>
        public static void GetInterfacesFromChildren<I>(this GameObject self,List<I> interfaces) where I : MonoBehaviour
        {
            foreach (Transform child in self.transform)
            {
                GetInterfacesFromMonoBehaviours<I>(child.gameObject, interfaces);
            }
        }
        /// <summary>
        /// Fills the interface provided list with interfaces found in the game object Monobehaviours
        /// </summary>
        /// <typeparam name="I">The interface type to get</typeparam>
        /// <param name="source">The source game object</param>
        /// <param name="result">The list to fill</param>
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

        /// <summary>
        /// Fills the interface provided list with interfaces found in all descendants reccursively
        /// </summary>
        /// <typeparam name="I">The interface type to get</typeparam>
        /// <param name="root">The root game object</param>
        /// <param name="result">The list to fill</param>
        public static void GetInterfacesFromDescendants<I>(GameObject root, List<I> result) where I : MonoBehaviour
        {
            foreach (Transform child in root.transform)
            {
                GetInterfacesFromMonoBehaviours(child.gameObject,result);
                GetInterfacesFromDescendants(child.gameObject, result);
            }
        }

    }
}
