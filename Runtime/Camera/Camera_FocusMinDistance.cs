using UnityEngine;
namespace Extensions.Camera_FocusMinDistance
{
    public static class Camera_FocusMinDistance
    {
        /// <summary>
        /// Get the minimum distance from the camera to view a circular area with the best fit.
        /// </summary>
        /// <param name="self">The camera target</param>
        /// <param name="radius">The radius of the circular zone</param>
        /// <param name="useHorizontalFov">
        /// Flag to change the default vertical camera fov to horizontal.
        /// Set the value to false, to indicate that the circle must fit within the height of the view,
        /// or to true to indicate that the circle must fit within the width of the view.
        /// true seams the 
        /// </param>
        /// <returns>The minimum distance result</returns>
        public static float FocusMinDistance(this Camera self, float radius, bool useHorizontalFov = false)
        {
            var angle = self.fieldOfView * Mathf.Deg2Rad;
            if (useHorizontalFov)
            {
                angle = 2 * Mathf.Atan(Mathf.Tan(angle / 2) * self.aspect);
            }
            return radius / Mathf.Sin(angle / 2f);
        }
    }
}
