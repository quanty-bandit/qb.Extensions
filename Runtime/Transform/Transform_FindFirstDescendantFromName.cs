using UnityEngine;
namespace Extensions.Transform_FindFirstDescendantFromName
{
    public static class Transform_FindFirstDescendantFromName
    {
        /// <summary>
        /// Returns the first found descendant which name matchs with the seeked name.
        /// The search can be performed throw all the descendants hierarchy if the parameter parseAllDescendants is set to true.
        /// The research process analyzes each hierarchical level before moving on to the next level in the order of the children.
        /// </summary>
        /// <param name="self">The transform root source</param>
        /// <param name="name">The child name to find</param>
        /// <param name="parseAllDescendants">
        /// Set this option to “true” to perform the search recursively on all descendants.
        /// </param>
        /// <returns></returns>
        public static Transform FindFirstDescendantFromName(this Transform self, string name,bool parseAllDescendants=true)
        {
            if (string.IsNullOrEmpty(name)) return null;
            return ReccursiveFindDescendant(self, name);
        }
        static Transform ReccursiveFindDescendant(Transform root, string name, bool parseAllDescendants = true)
        {
            foreach (Transform child in root)
            {
                if (child.name == name)
                {
                    return child;
                }
            }
            if(parseAllDescendants)
            {
                foreach (Transform child in root)
                {
                    var result = ReccursiveFindDescendant(child, name,true);
                    if (result != null) return result;
                }
            }
            return null;
        }
    }
}
