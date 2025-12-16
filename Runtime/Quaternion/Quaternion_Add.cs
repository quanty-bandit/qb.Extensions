
using UnityEngine;
namespace Extensions.Quaternion_Add
{
    public static class Quaternion_Add 
    {
        public static Quaternion Add(this Quaternion start, Quaternion diff)
        {
            return diff * start;
        }
    }
}
