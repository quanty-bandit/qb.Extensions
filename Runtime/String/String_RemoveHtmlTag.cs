using System.Text;
using System.Text.RegularExpressions;

namespace Extensions.String_RemoveHtmlTag
{
    public static class String_RemoveHtmlTag
    {
        public static string RemoveHtmlTag(this string _src, params string[] _tags)
        {
            if (_tags != null && _tags.Length > 0)
            {
                string sTags = "";
                for (int i = 0; i < _tags.Length; i++)
                {
                    sTags += i == 0 ? $"{_tags[i]}" : $"|{_tags[i]}";
                }
                string exp = @$"<([/{sTags}\s])*>";
                return Regex.Replace(_src, @exp, string.Empty);

            }
            return _src;
        }
        public static string RemoveHtmlTagAndContent(this string _src, params string[] _tags)
        {
            if (_tags != null && _tags.Length > 0)
            {
                /*
                
                string sTags = "";
                for (int i = 0; i < _tags.Length; i++)
                {
                    sTags += i == 0 ? $"{_tags[i]}" : $"|{_tags[i]}";
                }
                
                string exp = $"<(({sTags}).*?)>*?<(" + Regex.Escape(@"\/") + $"({sTags}).*?)>";

                return Regex.Replace(_src, exp, string.Empty);
                */
                // regex code subsitute because escape of \ seem to doesn't work
                var tmp = _src;
                
                int endIndex = 0;
                foreach (var _tag in _tags)
                {
                    var sb = new StringBuilder();
                    while (endIndex < tmp.Length)
                    {
                        var startIndex = _src.IndexOf($"<{_tag}>",endIndex);
                        if (startIndex != -1)
                        {
                            if (startIndex != 0)
                            {
                                sb.Append(tmp.Substring(endIndex, startIndex));
                            }
                            endIndex = _src.IndexOf($"</{_tag}>");
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
            return _src;
        }
    }
}
