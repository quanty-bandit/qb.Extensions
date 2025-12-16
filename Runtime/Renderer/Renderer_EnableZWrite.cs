using UnityEngine;
namespace Extensions.Renderer_EnableZWrite{
    public static class Renderer_EnableZWrite
    {
        /// <summary>
        /// Enables ZWrite for materials in this Renderer that have a '_Color' property. This will allow the materials 
        /// to write to the Z buffer, which could be used to affect how subsequent rendering is handled, 
        /// for instance, ensuring correct layering of transparent objects.
        /// Source code from: https://github.com/adammyhre/Unity-Utils/blob/master/UnityUtils/Scripts/Extensions/RendererExtensions.cs
        /// </summary>    
        public static void EnableZWrite(this Renderer renderer)
        {
            foreach (Material material in renderer.materials)
            {
                if (material.HasProperty("_Color"))
                {
                    material.SetInt("_ZWrite", 1);
                    material.renderQueue = (int)UnityEngine.Rendering.RenderQueue.Transparent;
                }
            }
        }

    }
}
