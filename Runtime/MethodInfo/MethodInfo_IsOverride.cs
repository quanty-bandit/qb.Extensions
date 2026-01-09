using System.Reflection;
namespace Extensions.MethodInfo_IsOverride
{
    public static class MethodInfo_IsOverride
    {
        /// <summary>
        /// Checks if a method is an override
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public static bool IsOverride(this MethodInfo m)
        {
            return m!=null?m.GetBaseDefinition().DeclaringType != m.DeclaringType:false;
        }
    }
}
