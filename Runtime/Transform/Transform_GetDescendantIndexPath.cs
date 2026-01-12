using System.Collections.Generic;
using UnityEngine;
namespace Extensions.Transform_GetDescendantIndexPath
{
    public static class Transform_GetDescendantIndexPath
    {
        /// <summary>
        /// Gets the descendant index array path from the root target to the descendant 
        /// target.
        /// The indexes result can be isUsed by the extension method GetDescendantFromIndexPath
        /// to retreive a descendant target from a tranforms hierarchy  
        /// </summary>
        /// <param name="self">The self transform as top root target of the hierarchy</param>
        /// <param name="descendantTarget">The descendant source</param>
        /// <returns>
        /// The descendants indexes array 
        /// or null if the decendant target doesn't belong to the root descendant hierarchy
        /// </returns>
        public static int[] GetDescendantIndexPath(this Transform self,Transform descendantTarget) 
        {
            List<int> indexes = new List<int>();
            var node = descendantTarget;
            while (node != self)
            {
                if (node.parent == null)
                {
                    indexes.Clear();
                    break;
                }
                else
                {
                    indexes.Add(node.GetSiblingIndex());
                    node = node.parent;
                }
            }
            if (indexes.Count == 0)
                return null;
            indexes.Reverse();
            return indexes.ToArray();
        }
    }
}
