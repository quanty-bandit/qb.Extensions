using UnityEngine;
namespace Extensions.Quaternion_Diff
{
    public static class Quaternion_Diff
    {
        public static Quaternion Diff(this Quaternion to, Quaternion from)
        {
            return Quaternion.Inverse(from)*to;
        }
    }
}
