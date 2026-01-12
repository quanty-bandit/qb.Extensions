using UnityEngine;
namespace Extensions.Vector2_Quantize
{

    public static class Vector2_Quantize
    {
        /// <summary>
        /// Rounds the components of a Vector3 down to the nearest multiple of the given quantization step.
        /// Source cde from: https://github.com/adammyhre/Unity-Utils/blob/master/UnityUtils/Scripts/Extensions/Vector2Extensions.cs
        /// <param name="position">The original Vector2 position to be quantized.</param>
        /// <param name="quantization">The quantization step for each component (x, y).</param>
        /// <returns>A new Vector2 with each component rounded down to the nearest multiple of the corresponding quantization step.</returns>
        /// </summary>
        public static Vector2 Quantize(this Vector2 position, Vector2 quantization)
        {
            return Vector2.Scale(
                quantization,
                new Vector2(
                    quantization.x != 0 ? Mathf.Floor(position.x / quantization.x) : 0,
                    quantization.y != 0 ? Mathf.Floor(position.y / quantization.y) : 0
                ));
        }
        public static Vector2 Quantize(this Vector2 position, float qx,float qy)=>Quantize(position, new Vector2(qx,qy));
    }
}
