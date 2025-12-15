using UnityEngine;
namespace Extensions.GameObject_IsInPersistentBranch
{
    public static class GameObject_IsInPersistentBranch
    {
        /// <summary>
        /// Check if a game object is persistent or belongs
        /// to hierachy where the root is persistent which means it 
        /// won't be destroyed despide the scene loading process
        /// </summary>
        /// <param name="self"></param>
        /// <returns>The result of the check</returns>
        public static bool IsInPersistentBranch(this GameObject self)
        {
            var transform = self.transform;
            while (transform.parent != null)
            {
                transform = transform.parent;
            }
            return transform.gameObject.scene.name == "DontDestroyOnLoad";
        }
    }
}
