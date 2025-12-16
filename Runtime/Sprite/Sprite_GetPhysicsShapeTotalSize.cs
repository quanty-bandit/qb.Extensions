using System.Collections.Generic;
using UnityEngine;
namespace Extensions.Sprite_GetPhysicsShapeTotalSize
{
    static public class Sprite_GetPhysicsShapeTotalSize
    {
        public static void GetPhysicsShapeTotalSizeAndCenter(this Sprite _target, out Vector2 size, out Vector2 center)
        {
            size = Vector2.zero;
            center = Vector2.zero;
            int count = _target.GetPhysicsShapeCount();
            if (count > 0)
            {
                Vector2 min = new Vector2(float.MaxValue, float.MaxValue);
                Vector2 max = new Vector2(float.MinValue, float.MinValue);

                List<Vector2> points = new List<Vector2>();
                for (int i = 0; i < count; i++)
                {
                    _target.GetPhysicsShape(i, points);
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
                center = min + size / 2;
            }
            
        }
        public static Vector2 GetPhysicsShapeTotalSize(this Sprite _target)
        {
            Vector2 size = Vector2.zero;
            int count = _target.GetPhysicsShapeCount();
            if (count > 0)
            {
                Vector2 min = new Vector2(float.MaxValue, float.MaxValue);
                Vector2 max = new Vector2(float.MinValue, float.MinValue);

                List<Vector2> points = new List<Vector2>();
                for (int i = 0; i < count; i++)
                {
                    _target.GetPhysicsShape(i, points);
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
            return size;
        }
    }
}