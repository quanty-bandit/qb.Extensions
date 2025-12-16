using UnityEngine;
namespace Extensions.Transform_RotateAround
{
    public static class Transform_RotateAround
    {
        public static void RotateAround(this Transform target, Vector3 pivot,Quaternion rotation)
        {
            target.position = rotation * (target.position - pivot) + pivot;
            target.rotation = rotation * target.rotation;
        }
        public static void RotateAround(this Transform target, Vector3 pivot, Vector3 eulerAngles)
        {
            RotateAround(target,pivot, Quaternion.Euler(eulerAngles));
        }
    }
}
