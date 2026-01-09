namespace Extensions.String_IsNullOrEmpty
{
    public static class String_IsNullOrEmpty
    {

        public static bool IsNullOrEmpty(this string value) => (value!=null)?string.IsNullOrEmpty(value):true;

    }
}
