using UnityEngine;
namespace Extensions.LayerMask_Contains
{
    public static class LayerMask_Contains
    {
        /// <summary>
        /// Checks if LayerMask contains a layer
        /// </summary>
        /// <param name="mask">The LayerMask to check.</param>
        /// <param name="layerNumber">The layer number to check if it is in the LayerMask.</param>
        /// <returns>True if the layer number is in the LayerMask, otherwise false.</returns>
        public static bool Contains(this LayerMask mask, int layerNumber)
        {
            return mask == (mask | (1 << layerNumber));
        }
    }
}