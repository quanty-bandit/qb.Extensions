using System.Collections.Generic;
using UnityEngine;
namespace Extensions.Transform_Path
{
    public static class Transform_Path
    {
        public static string Path(this Transform target)
        {
            if (target.parent == null) return target.name;
            List<string> list = new List<string>();
            var node = target;
            while (node.parent != null)
            {
                list.Add(node.name);
                node = node.parent;
            }
            list.Add(node.name);
            string path = "";
            for(int i=list.Count-1; i>0; i--)
            {
                path += $"{list[i]}/";
            }
            path += list[0];
            return path;
        }
    }
}
