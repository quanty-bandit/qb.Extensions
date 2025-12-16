using Extensions.Camera_FocusMinDistance;
using UnityEngine;
namespace Extensions.Camera_FocusOn
{
    public static class Camera_FocusOn
    {
        /// <summary>
        /// Set the camera position and near plane to focus to a circular zone
        /// </summary>
        /// <param name="self">The camera target</param>
        /// <param name="center">The center position of focus zone</param>
        /// <param name="radius">The radius of the focus zone</param>
        /// <param name="useHorizontalFov">
        /// Flag to change the default vertical camera fov to horizontal.
        /// Set the value to false, to indicate that the circle must fit within the height of the view,
        /// or to true to indicate that the circle must fit within the width of the view.
        /// </param>
        public static void FocusOn(this Camera self, Vector3 center, float radius, bool useHorizontalFov= false)
        {
            float minDistance = self.FocusMinDistance(radius,useHorizontalFov);
            self.transform.position = center - Vector3.forward * minDistance;
            self.nearClipPlane = minDistance - radius;
        }
    }
}
