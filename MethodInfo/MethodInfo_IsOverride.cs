using System.Reflection;
namespace Extensions.MethodInfo_IsOverride
{
    public static class MethodInfo_IsOverride
    {
        public static bool IsOverride(this MethodInfo m)
        {
            return m!=null?m.GetBaseDefinition().DeclaringType != m.DeclaringType:false;
        }
    }
}
