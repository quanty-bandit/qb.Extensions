using System.Collections.Generic;
using UnityEngine;

namespace Extensions.Transform_GetDescendants
{
    public static class Transform_GetDescendants
    {
        public static Transform[] GetDescendants(this Transform _src)
        {
            if (_src.childCount == 0)
                return null;
            List<Transform> descendants = new List<Transform>();
            _src.GetDescendants(descendants);
            if (descendants.Count == 0)
                return null;
            return descendants.ToArray();
        }
        public static void GetDescendants(this Transform _src, List<Transform> _descendants)
        {
            int childCount = _src.childCount;
            for(int i = 0; i < childCount; i++)
            {
                Transform child = _src.GetChild(i);
                _descendants.Add(child);
                child.GetDescendants(_descendants);
            }
        }
    }
}
