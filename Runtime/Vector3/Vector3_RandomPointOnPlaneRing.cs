using UnityEngine;
namespace Extensions.Vector3_RandomPointOnPlaneRing
{
    public static class Vector3_RandomPointOnPlaneRing
    {
        /// <summary>
        /// Gets a random point in an annulus (a ring-shaped area) based on minimum and 
        /// maximum radius values around a central Vector3 point (origin).
        /// </summary>
        /// <param name="origin">The center Vector3 point of the annulus.</param>
        /// <param name="minRadius">Minimum radius of the annulus.</param>
        /// <param name="maxRadius">Maximum radius of the annulus.</param>
        /// <param name="planeNormal">The plane normal</param>
        /// <returns>A random Vector3 point within the specified annulus.</returns>
        public static Vector3 RandomPointOnPlaneRing(this Vector3 origin, float minRadius, float maxRadius, Vector3 planeNormal)
        => Vector3.ProjectOnPlane(origin + GetARandomPoint(minRadius, maxRadius,Space.XYZ), planeNormal);


        /// <summary>
        /// Gets a random point in an annulus (a ring-shaped area) based on minimum and 
        /// maximum radius values around a central Vector3 point (origin).
        /// </summary>
        /// <param name="origin">The center Vector3 point of the annulus.</param>
        /// <param name="minRadius">Minimum radius of the annulus.</param>
        /// <param name="maxRadius">Maximum radius of the annulus.</param>
        /// <returns>A random Vector3 point within the specified annulus.</returns>
        public static Vector3 RandomPointOnXYPlaneRing(this Vector3 origin, float minRadius, float maxRadius)
        => origin+GetARandomPoint(minRadius, maxRadius, Space.XY);



        /// <summary>
        /// Gets a random point in an annulus (a ring-shaped area) based on minimum and 
        /// maximum radius values around a central Vector3 point (origin).
        /// </summary>
        /// <param name="origin">The center Vector3 point of the annulus.</param>
        /// <param name="minRadius">Minimum radius of the annulus.</param>
        /// <param name="maxRadius">Maximum radius of the annulus.</param>
        /// <returns>A random Vector3 point within the specified annulus.</returns>
        public static Vector3 RandomPointOnXZPlaneRing(this Vector3 origin, float minRadius, float maxRadius)
        => origin + GetARandomPoint(minRadius, maxRadius, Space.XZ);

        #region Private
        enum Space { XYZ, XY, XZ }
        static Vector3 GetARandomPoint(float minRadius, float maxRadius, Space space)
        {
            float angle = Random.value * Mathf.PI * 2f;
            Vector2 direction = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));

            // Squaring and then square-rooting radius to ensure uniform distribution within the annulus
            float minRadiusSquared = minRadius * minRadius;
            float maxRadiusSquared = maxRadius * maxRadius;
            float distance = Mathf.Sqrt(Random.value * (maxRadiusSquared - minRadiusSquared) + minRadiusSquared);
            Vector3 position;
            switch (space)
            {
                case Space.XY:
                    position = new Vector3(direction.x, direction.y, 0);
                    break;
                case Space.XZ:
                    position = new Vector3(direction.x, 0, direction.y);
                    break;
                default:
                    position = new Vector3(direction.x, direction.y, direction.x);
                    break;

            }
            return position * distance;
        }
        #endregion

    }
}
