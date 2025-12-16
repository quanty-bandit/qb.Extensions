using UnityEngine;
namespace Extensions.Vector3_ComponentDivide
{
    public static class Vector3_ComponentDivide
    {
        /// <summary>
        /// Divides two Vector3 objects component-wise.
        /// Source code from: https://github.com/adammyhre/Unity-Utils/blob/master/UnityUtils/Scripts/Extensions/Vector3Extensions.cs
        /// </summary>
        /// <remarks>
        /// For each component in v0 (x, y, z), it is divided by the corresponding component in v1 if the component in v1 is not zero. 
        /// Otherwise, the component in v0 remains unchanged.
        /// </remarks>
        /// <example>
        /// Use 'ComponentDivide' to scale a game object proportionally:
        /// <code>
        /// myObject.transform.localScale = originalScale.ComponentDivide(targetDimensions);
        /// </code>
        /// This scales the object size to fit within the target dimensions while maintaining its original proportions.
        ///</example>
        /// <param name="v0">The Vector3 object that this method extends.</param>
        /// <param name="v1">The Vector3 object by which v0 is divided.</param>
        /// <returns>A new Vector3 object resulting from the component-wise division.</returns>
        public static Vector3 ComponentDivide(this Vector3 v0, Vector3 v1)
        {
            return new Vector3(
                v1.x != 0 ? v0.x / v1.x : v0.x,
                v1.y != 0 ? v0.y / v1.y : v0.y,
                v1.z != 0 ? v0.z / v1.z : v0.z);
        }
    }
}
