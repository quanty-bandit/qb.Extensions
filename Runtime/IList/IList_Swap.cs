using System.Collections.Generic;
namespace Extensions.IList_Swap
{
    public static class IList_Swap
    {
        /// <summary>
        /// Swaps two elements in the list at the specified indices.
        /// </summary>
        /// <param name="list">The list.</param>
        /// <param name="indexA">The index of the first element.</param>
        /// <param name="indexB">The index of the second element.</param>
        public static void Swap<T>(this IList<T> list, int indexA, int indexB)
        {
            if(indexA!=indexB)
                (list[indexA], list[indexB]) = (list[indexB], list[indexA]);
        }
    }
}
