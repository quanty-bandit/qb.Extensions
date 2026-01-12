using UnityEngine;
namespace Extensions.Transform_FindDescendantFromPath
{
    public static class Transform_FindDescendantFromPath
    {
        /// <summary>
        /// Finds a descendant node reccursively from a string pathNodesNames like a file pathNodesNames
        /// </summary>
        /// <param name="transform">The root target</param>
        /// <param name="path">
        /// The descending pathNodesNames path formatted as a pathNodesNames file should look like:
        /// child_name/grand_child_name/grand_grand_child_name/...
        /// </param>
        /// <param name="nodeStringSeparator">The separator string used between each node name</param>
        /// <returns>The found descendant or null</returns>
        public static Transform FindDescendantFromPath(this Transform transform, string path,string nodeStringSeparator="/")
        {
            if (string.IsNullOrEmpty(path))
                return null;
            return FindDescendantFromPath(transform, 0, path.Split(nodeStringSeparator));
        }
        /// <summary>
        /// Finds a descendant node reccursively from a string pathNodesNames like a file pathNodesNames
        /// </summary>
        /// <param name="transform">The root target</param>
        /// <param name="startIndex">
        /// The curent node startIndex of the node names
        /// </param>
        /// <param name="pathNodesNames">The ordered path node names</param>
        /// <returns>The found descendant or null</returns>
        public static Transform FindDescendantFromPath(this Transform transform,int startIndex, params string[] pathNodesNames)
        {
            if (pathNodesNames != null && pathNodesNames.Length > 0)
            {
                var nodeTargetName = pathNodesNames[startIndex];
                foreach (Transform child in transform)
                {
                    if (child.name == nodeTargetName)
                    {
                        if (pathNodesNames.Length == startIndex + 1)
                        {
                            return child;
                        }
                        else
                        {
                            return FindDescendantFromPath(child, startIndex + 1, pathNodesNames);
                        }
                    }
                }
            }
            return null;
        }
    }
}
