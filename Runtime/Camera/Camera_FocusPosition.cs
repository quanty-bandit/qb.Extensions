using Extensions.Camera_FocusMinDistance;
using UnityEngine;
namespace Extensions.Camera_FocusOn
{
    public static class Camera_FocusPosition
    {
        /// <summary>
        /// Gets the position of the camera to view a circular area, placed on center position,
        /// with the best fit.   
        /// </summary>
        /// <param name="self">The camera target</param>
        /// <param name="center">The center position of the cicular zone</param> 
        /// <param name="radius">The radius of the circular zone</param>
        /// <param name="useHorizontalFov">
        /// Flag to change the default vertical camera fov to horizontal.
        /// Set the value to false, to indicate that the circle must fit within the height of the view,
        /// or to true to indicate that the circle must fit within the width of the view.
        /// true seams the 
        /// </param>
        /// <returns>The position result</returns>
        public static Vector3 FocusPosition(this Camera self, Vector3 center, float radius,bool useHorizontalFov=false) 
        {
            return center - Vector3.forward * self.FocusMinDistance(radius, useHorizontalFov);
        }
    }
}
