using UnityEngine;
namespace Extensions.Transform_RotateAround
{
    public static class Transform_RotateAround
    {
        /// <summary>
        /// Rotates around a pivot point
        /// </summary>
        /// <param name="target">The transform target to rotate</param>
        /// <param name="pivot">The rotation pivot</param>
        /// <param name="rotation">The rotation</param>
        public static void RotateAround(this Transform target, Vector3 pivot,Quaternion rotation)
        {
            target.position = rotation * (target.position - pivot) + pivot;
            target.rotation = rotation * target.rotation;
        }
        /// <summary>
        /// Rotates around a pivot point
        /// </summary>
        /// <param name="target">The transform target to rotate</param>
        /// <param name="pivot">The rotation pivot</param>
        /// <param name="eulerAngles">The rotation</param>
        public static void RotateAround(this Transform target, Vector3 pivot, Vector3 eulerAngles)
        {
            RotateAround(target,pivot, Quaternion.Euler(eulerAngles));
        }
    }
}
