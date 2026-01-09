using System.Text;
using System.Text.RegularExpressions;

namespace Extensions.String_RemoveHtmlTag
{
    public static class String_RemoveHtmlTag
    {
        /// <summary>
        /// Removes specified html tags
        /// </summary>
        /// <param name="source">The source string</param>
        /// <param name="tags">The tag to remove without <> </param>
        /// <returns>The new string without the tags</returns>
        public static string RemoveHtmlTag(this string source, params string[] tags)
        {
            if (tags != null && tags.Length > 0)
            {
                string sTags = "";
                for (int i = 0; i < tags.Length; i++)
                {
                    sTags += i == 0 ? $"{tags[i]}" : $"|{tags[i]}";
                }
                string exp = @$"<([/{sTags}\s])*>";
                return Regex.Replace(source, @exp, string.Empty);

            }
            return source;
        }
        /// <summary>
        /// Removes from string specified tags and text inside.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="tags"></param>
        /// <returns></returns>
        public static string RemoveHtmlTagAndContent(this string source, params string[] tags)
        {
            if (tags != null && tags.Length > 0)
            {
                /*
                
                string sTags = "";
                for (int i = 0; i < tags.Length; i++)
                {
                    sTags += i == 0 ? $"{tags[i]}" : $"|{tags[i]}";
                }
                
                string exp = $"<(({sTags}).*?)>*?<(" + Regex.Escape(@"\/") + $"({sTags}).*?)>";

                return Regex.Replace(source, exp, string.Empty);
                */
                // regex code subsitute because escape of \ seem to doesn't work

                var tmp = source;
                
                int endIndex = 0;
                foreach (var _tag in tags)
                {
                    var sb = new StringBuilder();
                    while (endIndex < tmp.Length)
                    {
                        var startIndex = source.IndexOf($"<{_tag}>",endIndex);
                        if (startIndex != -1)
                        {
                            if (startIndex != 0)
                            {
                                sb.Append(tmp.Substring(endIndex, startIndex));
                            }
                            endIndex = source.IndexOf($"</{_tag}>");
                            if (endIndex > -1)
                            {
                                endIndex += _tag.Length + 3;
                            }
                        }
                        else
                        {
                            sb.Append(tmp.Substring(endIndex));
                            endIndex = tmp.Length;
                        }
                    }
                    tmp= sb.ToString();
                }
                return tmp;
            }
            return source;
        }
    }
}
