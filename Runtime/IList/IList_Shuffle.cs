using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
namespace Extensions.IList_Shuffle
{
    public static class IList_Shuffle
    {
        /// <summary>
        /// Shuffle all the elements in the list
        /// </summary>
        /// <typeparam name="T">The elements type</typeparam>
        /// <param name="list">The source list</param>
        /// <exception cref="ArgumentNullException">If list is null</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Shuffle<T>(this IList<T> list)
        {
            if (list == null) throw new ArgumentNullException(nameof(list));
            int n = list.Count;
            while (n > 1)
            {
                int k = ThreadSafeRandom.Instance.Next(n--);
                (list[n], list[k]) = (list[k], list[n]);
            }
        }

        internal class ThreadSafeRandom
        {
            public static Random Instance => __local.Value;

            private static readonly Random __global = new Random();
            private static readonly ThreadLocal<Random> __local = new ThreadLocal<Random>(() =>
            {
                int seed;
                lock (__global)
                {
                    seed = __global.Next();
                }
                return new Random(seed);
            });
        }
    }
}
