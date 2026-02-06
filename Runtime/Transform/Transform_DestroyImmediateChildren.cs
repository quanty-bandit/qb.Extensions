using System.Collections.Generic;
using UnityEngine;

public static class Transform_DestroyImmediateChildren
{
    /// <summary>
    /// Destroy all children
    /// </summary>
    /// <param name="root">The source root</param>
    public static void DestroyImmediateChildren(this Transform root)
    {
        List<GameObject> list = new List<GameObject>();
        foreach (Transform child in root)
            list.Add(child.gameObject);
        root.DetachChildren();
        foreach (var child in list)
            GameObject.DestroyImmediate(child);
    }
}
