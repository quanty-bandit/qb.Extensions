
using System.Collections.Generic;
using UnityEngine;
namespace Extensions.Transform_DestroyChildren
{
    public static class Transform_DestroyChildren
    {
        /// <summary>
        /// Destroy all children
        /// </summary>
        /// <param name="root">The source root</param>
        /// <param name="delay">The delay to wait before the destruction</param>
        public static void DestroyChildren(this Transform root, float delay=0)
        {
            List<GameObject> list = new List<GameObject>();
            foreach (GameObject child in root)
                list.Add(child);
            root.DetachChildren();
            foreach (var child in list)
                GameObject.Destroy(child, delay);
        }
    }
}