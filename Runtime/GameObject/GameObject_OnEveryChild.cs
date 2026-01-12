using UnityEngine;
namespace Extensions.GameObject_OnEveryChild
{
    public static class GameObject_OnEveryChild
    {
        /// <summary>
        /// Executes a specified action for each child of a given GameObject.
        /// </summary>
        /// <param name="parent">The root source</param>
        /// <param name="action">The action to be performed on each child.</param>
        /// <param name="occursOnAllDescendants">Sets to true to apply the action to the entire descendant hierarchy.</param>
        /// <remarks>
        /// This method iterates over all child and executes a given action on them.
        /// The action is a delegate that takes the child GameObject as parameter.
        /// </remarks>
        public static void OnEveryChild(this GameObject parent, System.Action<GameObject> action,bool occursOnAllDescendants=false)
        {
            foreach(GameObject child in parent.transform)
                action(child);
            if(occursOnAllDescendants)
            {
                foreach (GameObject child in parent.transform)
                    OnEveryChild(child,action,true);
            }
        }
    }
}
