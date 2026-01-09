using System;
using System.Collections.Generic;
namespace Extensions.IEnumerable_GetAtRandom
{
    public static class IEnumerable_GetAtRandom
    {
        /// <summary>
        /// Returns a random element from the sequence.
        /// Source code from: https://github.com/adammyhre/Unity-Utils/blob/master/UnityUtils/Scripts/Extensions/EnumerableExtensions.cs
        /// </summary>
        /// <typeparam name="T">The type of elements in the sequence.</typeparam>
        /// <param name="sequence">The sequence to select the random element from.</param>
        /// <returns>A random element from the sequence.</returns>
        public static T GetAtRandom<T>(this IEnumerable<T> sequence)
        {
            if (sequence == null)
                throw new ArgumentNullException(nameof(sequence));

            if (sequence is IList<T> list)
            {
                if (list.Count == 0)
                    throw new InvalidOperationException("Cannot get a random element from an empty collection.");
                return list[UnityEngine.Random.Range(0, list.Count)];
            }

            // Use reservoir sampling when the input is not an IList<I> ie: a stream or lazy sequence
            using var enumerator = sequence.GetEnumerator();
            if (!enumerator.MoveNext())
                throw new InvalidOperationException("Cannot get a random element from an empty collection.");

            T result = enumerator.Current;
            int count = 1;
            while (enumerator.MoveNext())
            {
                if (UnityEngine.Random.Range(0, ++count) == 0)
                {
                    result = enumerator.Current;
                }
            }
            return result;
        }

    }
}
