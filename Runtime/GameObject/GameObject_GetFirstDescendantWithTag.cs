using UnityEngine;
namespace Extensions.GameObject_GetFirstDescendantWithTag
{
    public static class GameObject_GetFirstDescendantWithTag
    {
        
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
