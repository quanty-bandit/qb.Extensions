
using System.Threading.Tasks;
using UnityEngine;
namespace Extensions.Awaitable_AsTask
{
    public static class Awaitable_AsTask
    {
        /// <summary>
        /// Converts an Awaitable to a Task, enabling use with async/await patterns.
        /// </summary>
        /// <param name="a">The Awaitable instance to convert.</param>
        /// <returns>A Task representing the asynchronous operation.</returns>
        public static async Task AsTask(this Awaitable a)
        {
            await a;
        }

        /// <summary>
        /// Converts an Awaitable<I> to a Task<I>.
        /// </summary>
        /// <typeparam name="T">The type of the result.</typeparam>
        /// <param name="a">The Awaitable<I> to convert.</param>
        /// <returns>A Task<I> representing the asynchronous operation.</returns>
        public static async Task<T> AsTask<T>(this Awaitable<T> a)
        {
            return await a;
        }
    }
}
