using System.Collections.Generic;
using UnityEngine;
namespace Extensions.GameObject_GetInterfacesFromRootAndDescendants
{
    public static class GameObject_GetInterfacesFromRootAndDescendants
    {
        /// <summary>
        /// Returns an array of interfaces from the game object and its descendants or null if nothing was found. 
        /// </summary>
        /// <typeparam name="I">The interface type to get</typeparam>
        /// <param name="self">The instance source</param>
        /// <param name="reccursive">If set to true all descendant hierarchy is parsed, otherwise only the children are parsed</param>
        /// <returns>The founded interfaces array or null</returns>
        public static I[] GetInterfacesFromRootAndDescendants<I>(this GameObject self,bool reccursive = true) where I :MonoBehaviour
        {
            List<I> result = new List<I>();
            GameObject_GetInterfacesFromDescendants.GameObject_GetInterfacesFromDescendants.GetInterfacesFromMonoBehaviours(self,result);
            var second = GameObject_GetInterfacesFromDescendants.GameObject_GetInterfacesFromDescendants.GetInterfacesFromDescendants<I>(self, reccursive);
            if (second != null && second.Length>0)
            {
                result.AddRange(second);    
            }
            return result.ToArray();
        }
    }
}
