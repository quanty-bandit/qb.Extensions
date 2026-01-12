using System.Collections.Generic;

namespace Extensions.String_Scramble
{
    public static class String_Scramble
    {
        /// <summary>
        /// Scrambles a string from a seed
        /// </summary>
        /// <param name="source">The source string to scramble</param>
        /// <param name="seed">The string used as seed, each character's ascii code is used as a scramble index</param>
        /// <param name="offset">The circular offset seed index</param>
        /// <returns>The scramble string</returns>
        /// /// <seealso cref="Unscramble"/>
        public static string Scramble(this string source, string seed, int offset=0)
        {
            if (string.IsNullOrEmpty(seed)) return source;

            var sl = seed.Length;
            int[] indexes = new int[sl];
            for (int i = 0; i < sl; i++)
            {
                indexes[i] = (int)seed[i];
            }

            var il = source.Length;
            char[] chars = new char[il];
            for (int i = 0; i < il; i++)
            {
                chars[i] = source[i];
            }

            int si = offset%sl;
            for (int i = 0; i < il; i++)
            {
                int k = indexes[si++] % il;
                if (si >= sl) si = 0;
                char temp = chars[k];
                chars[k] = chars[i];
                chars[i] = temp;

            }
            return new string(chars);
        }

        /// <summary>
        /// Unscrambles a scrambled string
        /// </summary>
        /// <param name="source">The source string to unscramble</param>
        /// <param name="seed">The string used as seed in the previous scramble process</param>
        /// <param name="offset">The circular offset seed index</param>
        /// <returns>The unscramble string</returns>
        /// <seealso cref="Scramble"/>
        public static string Unscramble(this string source, string seed, int offset=0)
        {
            if (string.IsNullOrEmpty(seed)) return source;

            var sl = seed.Length;
            int[] indexes = new int[sl];
            for (int i = 0; i < sl; i++)
            {
                indexes[i] = (int)seed[i];
            }

            int il = source.Length;
            char[] scramChars = new char[il];
            for (int i = 0; i < il; i++)
            {
                scramChars[i] = source[i];
            }

            List<int> swaps = new List<int>();
            int si = offset % sl;
            for (int i = 0; i < il; i++)
            {
                int k = indexes[si++] % il;
                if (si >= sl) si = 0;
                swaps.Add(k);
            }
            si = il - 1;
            for (int i = si; i >= 0; i--)
            {
                char temp = scramChars[swaps[i]];
                scramChars[swaps[i]] = scramChars[i];
                scramChars[i] = temp;
            }
            return new string(scramChars);
        }
    }
}
