using System.Linq;
using UnityEngine;
namespace Extensions.GameObject_GetBoundsWithChildren
{
    public static class GameObject_GetBoundsWithChildren
    {
        public static Bounds GetBoundsWithChildren(this GameObject gameObject)
        {
            Renderer parentRenderer = gameObject.GetComponent<Renderer>();

            Renderer[] childrenRenderers = gameObject.GetComponentsInChildren<Renderer>();

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
