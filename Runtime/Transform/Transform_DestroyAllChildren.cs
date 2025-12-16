
using System.Collections.Generic;
using UnityEngine;
namespace Extensions.Transform_DestroyAllChildren
{
    public static class Transform_DestroyAllChildren
    {
        public static void DestroyAllChildren(this Transform _target, float _delay=0)
        {
            int childCound = _target.childCount;
            List<Transform> toRemove = new List<Transform>();
            for(int i = 0; i < childCound; i++)
            {
                try
                {
                    var t = _target.GetChild(i);
                    toRemove.Add(t);
                }
                catch(System.Exception _e)
                {
                    Debug.LogWarning("Transform.DestroyAllChildren: " + _e.Message);
                }
            }
            _target.DetachChildren();
            foreach(var t in toRemove)
            {
                if (t != null)
                {
                    t.gameObject.SetActive(false);
                    GameObject.Destroy(t.gameObject, _delay);
                }
            }
        }
    }
}