using Extensions.GameObject_GetComponentsFromDescendants;
using UnityEngine;
namespace Extensions.GameObject_ReccursiveGetFirstComponent
{
    public static class GameObject_ReccursiveGetFirstComponent
    {
        public static T ReccursiveGetFirstComponent<T>(this GameObject self)
        {
            var result = self.GetComponent<T>();
            if (result == null)
            {
                var results = self.GetComponentsFromDescendants<T>(true);
                if (results != null)
                    result = results[0];
            }
            return result;
        }
    }
}
