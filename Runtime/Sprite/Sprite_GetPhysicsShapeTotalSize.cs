using System.Collections.Generic;
using UnityEngine;
namespace Extensions.Sprite_GetPhysicsShapeTotalSize
{
    static public class Sprite_GetPhysicsShapeTotalSize
    {
        /// <summary>
        /// Gets the physics shape total size and the center 
        /// </summary>
        /// <param name="source">The sprite source</param>
        /// <param name="size">the output size</param>
        /// <param name="center">The output center</param>
        public static void GetPhysicsShapeTotalSizeAndCenter(this Sprite source, out Vector2 size, out Vector2 center)
        {
            center = Vector2.zero;
            (Vector2 s, Vector2 min) = __GetPhysicsShapeTotalSize(source);
            size = s;
            int count = source.GetPhysicsShapeCount();
            if (count > 0)
            {
                center = min + size / 2;
            }
        }

        /// <summary>
        /// Gets the physics shape total
        /// </summary>
        /// <param name="source">The sprite source</param>
        /// <returns>The shape size</returns>
        public static Vector2 GetPhysicsShapeTotalSize(this Sprite source)
        {
            (Vector2 size,Vector2 min) = __GetPhysicsShapeTotalSize(source);
            return size;
        }

        static (Vector2, Vector2) __GetPhysicsShapeTotalSize(Sprite source)
        {
            Vector2 size = Vector2.zero;
            Vector2 min = new Vector2(float.MaxValue, float.MaxValue);
            int count = source.GetPhysicsShapeCount();
            if (count > 0)
            {
                Vector2 max = new Vector2(float.MinValue, float.MinValue);

                List<Vector2> points = new List<Vector2>();
                for (int i = 0; i < count; i++)
                {
                    source.GetPhysicsShape(i, points);
                    foreach (var p in points)
                    {
                        if (p.x < min.x)
                            min.x = p.x;
                        else
                            if (p.x > max.x)
                            max.x = p.x;
                        if (p.y < min.y)
                            min.y = p.y;
                        else
                            if (p.y > max.y)
                            max.y = p.y;
                    }
                    points.Clear();
                }
                size = max - min;
            }
            return (size, min);
        }
    }
}