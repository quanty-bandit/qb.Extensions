using UnityEngine;
namespace Extensions.Vector3_Add
{
    public static class Vector3_Add
    {
        /// <summary>
        /// Adds to any x y z values of a Vector3
        /// Source code from: https://github.com/adammyhre/Unity-Utils/blob/master/UnityUtils/Scripts/Extensions/Vector3Extensions.cs        /// </summary>
        public static Vector3 Add(this Vector3 vector, float x = 0, float y = 0, float z = 0)
        {
            return new Vector3(vector.x + x, vector.y + y, vector.z + z);
        }
    }
}
