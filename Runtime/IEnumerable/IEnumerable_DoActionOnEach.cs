using System;
using System.Collections.Generic;
namespace Extensions.IEnumerable_ForEach
{
    public static class IEnumerable_DoActionOnEach
    {
        /// <summary>
        /// Performs an action on each element in the sequence.
        /// Source code from: https://github.com/adammyhre/Unity-Utils/blob/master/UnityUtils/Scripts/Extensions/EnumerableExtensions.cs
        /// </summary>
        /// <typeparam name="T">The type of elements in the sequence.</typeparam>
        /// <param name="sequence">The sequence to iterate over.</param>
        /// <param name="action">The action to perform on each element.</param>
        public static void DoActionOnEach<T>(this IEnumerable<T> sequence, Action<T> action)
        {
            foreach (var item in sequence)
                action(item);
        }
    }
}
