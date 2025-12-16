using UnityEngine;
namespace Extensions.Rigidbody_Stop
{
    public static class Rigidbody_Stop
    {
        /// <summary>
        /// Stops the Rigidbody by setting its linear and angular velocities to zero.
        /// Source code from: https://github.com/adammyhre/Unity-Utils/blob/master/UnityUtils/Scripts/Extensions/RigidbodyExtensions.cs
        /// </summary>
        /// <param name="rigidbody">The Rigidbody to stop.</param>
        /// <returns>The modified Rigidbody for method chaining.</returns>
        public static Rigidbody Stop(this Rigidbody rigidbody)
        {
#if UNITY_6000_0_OR_NEWER
            rigidbody.linearVelocity = Vector3.zero;
#else
            rigidbody.velocity = Vector3.zero;
#endif
            rigidbody.angularVelocity = Vector3.zero;
            return rigidbody;
        }
    }
}
