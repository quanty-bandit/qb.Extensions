using Extensions.GameObject_GetComponentsFromDescendants;
using UnityEngine;
namespace Extensions.GameObject_ReccursiveGetFirstComponent
{
    public static class GameObject_ReccursiveGetFirstComponent
    {
        /// <summary>
        /// Returns the first component from type from a game object and its descendants
        /// </summary>
        /// <typeparam name="T">The component type to get</typeparam>
        /// <param name="self">The game object source</param>
        /// <returns>The first component found or null</returns>
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
