using UnityEngine;
namespace Extensions.GameObject_GetFirstDescendantWithTag
{
    public static class GameObject_GetFirstDescendantWithTag
    {
        /// <summary>
        /// Returns the first desendant from a game object with a sopecific tag or nul if nothing found.
        /// The research process analyzes each hierarchical level before moving on to the next level in the order of the children.
        /// </summary>
        /// <param name="self">The source instance</param>
        /// <param name="tag">The tag to found</param>
        /// <returns>The first descendant founded or null</returns>
        public static GameObject GetFirstDescendantWithTag(this GameObject self,string tag)
        {
            return __GetFirstDescendantWithTag(self.transform,tag);
        }
        public static GameObject __GetFirstDescendantWithTag(Transform target, string tag)
        {

            foreach (Transform child in target)
            {
                if (child.gameObject.tag == tag)
                    return child.gameObject;
            }
            foreach (Transform child in target)
            {
                var result = __GetFirstDescendantWithTag(child, tag);
                if(result!=null) return result;
            }
            return null;
            
        }
        
    }
}
