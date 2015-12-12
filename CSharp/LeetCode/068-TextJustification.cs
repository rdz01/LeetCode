using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class _068_TextJustification
    {
        public IList<string> FullJustify(string[] words, int maxWidth)
        {
            var result = new List<string>();

            int start = 0, len = 0, space = 0;
            var builder = new StringBuilder();
            for (int i = 0; i < words.Length; i++)
            {
                if (len + words[i].Length > maxWidth)
                {
                    space = maxWidth - len + (i - start);
                    builder.Clear();
                    for (int j = start; j < i; j++)
                    {
                        builder.Append(words[j]);

                        if (j != i - 1)
                        {
                            var tempSpace = space / (i - start - 1) + ((j - start < (space % (i - start - 1))) ? 1 : 0);
                            builder.Append(new string(' ', Math.Min(maxWidth - builder.Length, tempSpace)));
                        }
                        else
                        {
                            builder.Append(new string(' ', maxWidth - builder.Length));
                        }
                    }
                    result.Add(builder.ToString());

                    len = 0;
                    start = i;
                }

                len += words[i].Length + 1;
            }

            builder.Clear();
            for (int j = start; j < words.Length; j++)
            {
                builder.Append(words[j]);
                if (j != words.Length - 1)
                {
                    builder.Append(' ');
                }
                else
                {
                    builder.Append(new string(' ', maxWidth - builder.Length));
                }
            }
            result.Add(builder.ToString());

            return result;
        }
    }
}
