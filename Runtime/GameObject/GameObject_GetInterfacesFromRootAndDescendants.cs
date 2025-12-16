using System.Collections.Generic;
using UnityEngine;
namespace Extensions.GameObject_GetInterfacesFromRootAndDescendants
{
    public static class GameObject_GetInterfacesFromRootAndDescendants
    {
        public static I[] GetInterfacesFromRootAndDescendants<I>(this GameObject self) where I :MonoBehaviour
        {
            List<I> result = new List<I>();
            GameObject_GetInterfacesFromDescendants.GameObject_GetInterfacesFromDescendants.GetInterfacesFromMonoBehaviours<I>(self,result);
            var second = GameObject_GetInterfacesFromDescendants.GameObject_GetInterfacesFromDescendants.GetInterfacesFromDescendants<I>(self,true);
            if (second != null && second.Length>0)
            {
                result.AddRange(second);    
            }
            return result.ToArray();
        }
    }
}
