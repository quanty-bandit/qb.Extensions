namespace Extensions.String_IsNullOrWhiteSpace
{
    public static class String_IsNullOrWhiteSpace
    {
        public static bool IsNullOrWhiteSpace(this string value) => (value!=null)?string.IsNullOrWhiteSpace(value):true;
    }
}
