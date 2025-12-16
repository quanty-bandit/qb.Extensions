using System.Linq;

namespace Extensions.String_AddSpaceBeforeCapital 
{
    public static class String_AddSpaceBeforeCapital
    {
        public static string AddSpaceBeforeCapital(this string self)
        {
            return new string(self.SelectMany((c, i) => i > 0 && char.IsUpper(c) ? new[] { ' ', c } : new[] { c }).ToArray());
        }
    }

}