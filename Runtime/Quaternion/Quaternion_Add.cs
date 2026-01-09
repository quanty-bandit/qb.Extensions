
using UnityEngine;
namespace Extensions.Quaternion_Add
{
    public static class Quaternion_Add 
    {
        /// <summary>
        /// Quaternion addition
        /// </summary>
        /// <param name="start">Source target</param>
        /// <param name="add">Additionnal quaternion</param>
        /// <returns></returns>
        public static Quaternion Add(this Quaternion start, Quaternion add)
        {
            return add * start;
        }
    }
}
