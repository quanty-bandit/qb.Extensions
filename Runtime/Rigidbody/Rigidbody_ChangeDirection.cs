using UnityEngine;
namespace Extensions.Rigidbody_ChangeDirection
{
    public static class Rigidbody_ChangeDirection
    {
        /// <summary>
        /// Changes the direction of the Rigidbody's velocity while maintaining its speed.
        /// Source code from: https://github.com/adammyhre/Unity-Utils/blob/master/UnityUtils/Scripts/Extensions/RigidbodyExtensions.cs
        /// </summary>
        /// <param name="rigidbody">The Rigidbody to change direction.</param>
        /// <param name="direction">The new direction for the Rigidbody.</param>
        /// <returns>The modified Rigidbody for method chaining.</returns>
        public static Rigidbody ChangeDirection(this Rigidbody rigidbody, Vector3 direction)
        {
            if (direction.sqrMagnitude == 0f) return rigidbody;
            direction.Normalize();

#if UNITY_6000_0_OR_NEWER
            rigidbody.linearVelocity = direction * rigidbody.linearVelocity.magnitude;
#else
            rigidbody.velocity = direction * rigidbody.velocity.magnitude;
#endif
            return rigidbody;
        }

    }
}