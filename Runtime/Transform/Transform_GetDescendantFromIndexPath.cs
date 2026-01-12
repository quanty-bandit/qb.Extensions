using UnityEngine;
namespace Extensions.Transform_GetDescendantFromIndexPath
{
    public static class Transform_GetDescendantFromIndexPath
    {
        /// <summary>
        /// Returns the descendant from self hierarchy using descendant indexes.
        /// </summary>
        /// <param name="self">The self transform as start root target of the hierarchy</param>
        /// <param name="descendantIndexes"></param>
        /// <returns>The decendant element 
        /// or null if the indexes path not match with the hierarchy structure</returns>
        public static Transform GetDescendantFromIndexPath(this Transform self,params int[] descendantIndexes)
        {
            if (descendantIndexes == null || descendantIndexes.Length == 0) return null;

            Transform node = self;
            foreach (var index in descendantIndexes)
            {
                if (index < node.childCount)
                    node = node.GetChild(index);
                else
                    return null;
            }
            return node;
        }
    }
}
