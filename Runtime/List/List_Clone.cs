using System.Collections.Generic;

namespace Extensions.List_Clone
{
    public static class List_Clone
    {
        /// <summary>
        /// Creates a new list that is a copy of the original list.
        /// </summary>
        /// <param name="list">The original list to be copied.</param>
        /// <returns>A new list that is a copy of the original list.</returns>
        public static List<T> Clone<T>(this IList<T> list) => new List<T>(list);

    }
}
