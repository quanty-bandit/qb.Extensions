using System.Linq;
using UnityEngine;
namespace Extensions.GameObject_GetBoundsWithChildren
{
    public static class GameObject_GetBoundsWithChildren
    {
        /// <summary>
        /// Returns the global bounds of a rendered game object and its children   
        /// </summary>
        /// <param name="gameObject">The instance source</param>
        /// <param name="includeInactive">Set to true to include inactive children</param>
        /// <returns></returns>
        public static Bounds GetBoundsWithChildren(this GameObject gameObject,bool includeInactive=false)
        {
            Renderer parentRenderer = gameObject.GetComponent<Renderer>();

            Renderer[] childrenRenderers = gameObject.GetComponentsInChildren<Renderer>(includeInactive);

            Bounds bounds = parentRenderer != null
               ? parentRenderer.bounds
               : childrenRenderers.FirstOrDefault(x => x.enabled).bounds;

            if (childrenRenderers.Length > 0)
            {
                foreach (Renderer renderer in childrenRenderers)
                {
                    if (renderer.enabled)
                    {
                        bounds.Encapsulate(renderer.bounds);
                    }
                }
            }

            return bounds;
        }
    }
}
