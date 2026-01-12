using System.Collections.Generic;
using UnityEngine;
namespace Extensions.Transform_Path
{
    public static class Transform_Path
    {
        /// <summary>
        /// Returns the transform composed names path from self node to parent root.
        /// In case of the self node is a root node the self node name is returned
        /// </summary>
        /// <param name="self"></param>
        /// <param name="pathNodeSeparator">The string to use as node separator</param>
        /// <returns>The composed string path</returns>
        public static string Path(this Transform self,string pathNodeSeparator="/")
        {
            if (self.parent == null) return self.name;
            List<string> list = new List<string>();
            var node = self;
            while (node.parent != null)
            {
                list.Add(node.name);
                node = node.parent;
            }
            list.Add(node.name);
            string path = "";
            for(int i=list.Count-1; i>0; i--)
            {
                path += $"{list[i]}{pathNodeSeparator}";
            }
            path += list[0];
            return path;
        }
    }
}
