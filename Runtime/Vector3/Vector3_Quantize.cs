using UnityEngine;
namespace Extensions.Vector3_Quantize{
    public static class Vector3_Quantize
    {
        /// <summary>
        /// Rounds the components of a Vector3 down to the nearest multiple of the given quantization step.
        /// This is useful for reducing precision or snapping positions to a grid,
        /// for example to limit NavMesh rebuilds or discretize movement updates.
        /// Source cde from: https://github.com/adammyhre/Unity-Utils/blob/master/UnityUtils/Scripts/Extensions/Vector3Extensions.cs
        /// <param name="position">The original Vector3 position to be quantized.</param>
        /// <param name="quantization">The quantization step for each component (x, y, z).</param>
        /// <returns>A new Vector3 with each component rounded down to the nearest multiple of the corresponding quantization step.</returns>
        /// </summary>
        public static Vector3 Quantize(this Vector3 position, Vector3 quantization)
        {
            return Vector3.Scale(
                quantization,
                new Vector3(
                    quantization.x != 0 ? Mathf.Floor(position.x / quantization.x):0,
                    quantization.y != 0 ? Mathf.Floor(position.y / quantization.y):0,
                    quantization.z != 0 ? Mathf.Floor(position.z / quantization.z):0
                ));
        }
        public static Vector3 Quantize(this Vector3 position, float qx, float qy, float qz) => Quantize(position, new Vector3(qx, qy, qz));

    }
}
