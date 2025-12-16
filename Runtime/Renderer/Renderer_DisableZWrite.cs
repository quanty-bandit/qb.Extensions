using UnityEngine;
namespace Extensions.Renderer_DisableZWrite
{
    public static class Renderer_DisableZWrite
    {
        /// <summary>
        /// Disables ZWrite for materials in this Renderer that have a '_Color' property. This would stop 
        /// the materials from writing to the Z buffer, which may be desirable in some cases to prevent subsequent 
        /// rendering from being occluded, like in rendering of semi-transparent or layered objects.
        /// Source code from: https://github.com/adammyhre/Unity-Utils/blob/master/UnityUtils/Scripts/Extensions/RendererExtensions.cs
        /// </summary>
        public static void DisableZWrite(this Renderer renderer)
        {
            foreach (Material material in renderer.materials)
            {
                if (material.HasProperty("_Color"))
                {
                    material.SetInt("_ZWrite", 0);
                    material.renderQueue = (int)UnityEngine.Rendering.RenderQueue.Transparent + 100;
                }
            }
        }
    }
}
