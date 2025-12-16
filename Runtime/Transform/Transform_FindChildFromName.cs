using UnityEngine;
namespace Extensions.Transform_FindChildFromName
{
    public static class Transform_FindChildFromName
    {
        public static Transform FindChildFromName(this Transform self, string name)
        {
            if (string.IsNullOrEmpty(name)) return null;
            return ReccursiveFindChildren(self, name);
        }
        static Transform ReccursiveFindChildren(Transform root, string name)
        {
            foreach (Transform child in root)
            {
                if (child.name ==name)
                {
                    return child;
                }
                var result = ReccursiveFindChildren(child, name);
                if(result!=null) return result;
            }
            return null;
        }
    }
}
