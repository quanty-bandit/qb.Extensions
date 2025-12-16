using Extensions.String_IsNullOrEmpty;
using Extensions.String_IsNullOrWhiteSpace;

namespace Extensions.String_IsBlank
{
    public static class String_IsBlank
    {
        /// <summary>Checks if a string contains null, empty or white space.</summary>
        public static bool IsBlank(this string val) => val.IsNullOrWhiteSpace() || val.IsNullOrEmpty();

    }
}
