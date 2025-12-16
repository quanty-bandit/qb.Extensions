using UnityEngine;
namespace Extensions.Transform_FindChildFromPath
{
    public static class Transform_FindChildFromPath
    {
        /// <summary>
        /// Find a child node reccursively from a string path like a file path
        /// </summary>
        /// <param name="transform">The root target</param>
        /// <param name="path">
        /// The child path formatted as a file path like:
        /// child_name/grand_child_name/grand_grand_child_name/...
        /// </param>
        /// <returns>The found child or null</returns>
        public static Transform FindChildFromPath(this Transform transform, string path)
        {
            if (string.IsNullOrEmpty(path))
                return null;
            return FindChildFromPath(transform, 0, path.Split("/"));
        }
        public static Transform FindChildFromPath(this Transform transform,int index, params string[] path)
        {
            if (path != null && path.Length > 0)
            {
                var nodeTargetName = path[index];
                foreach (Transform child in transform)
                {
                    if (child.name == nodeTargetName)
                    {
                        if (path.Length == index + 1)
                        {
                            return child;
                        }
                        else
                        {
                            return FindChildFromPath(child, index + 1, path);
                        }
                    }
                }
            }
            return null;
        }
    }
}
