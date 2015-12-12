using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class _068_TextJustification
    {
        public IList<string> FullJustify(string[] words, int maxWidth)
        {
            var result = new List<string>();

            int start = 0, len = 0, space = 0, tempSpace, i, j;
            var builder = new StringBuilder();
            for (i = 0; i < words.Length; i++)
            {
                if (len + words[i].Length > maxWidth)
                {
                    space = maxWidth - len + (i - start);
                    builder.Clear();
                    for (j = start; j < i; j++)
                    {
                        builder.Append(words[j]);

                        tempSpace = j != i - 1
                            ? space / (i - start - 1) + ((j - start < (space % (i - start - 1))) ? 1 : 0)
                            : maxWidth - builder.Length;
                        builder.Append(new string(' ', tempSpace));
                    }
                    result.Add(builder.ToString());

                    len = 0;
                    start = i;
                }

                len += words[i].Length + 1;
            }

            builder.Clear();
            for (j = start; j < words.Length; j++)
            {
                builder.Append(words[j]);
                tempSpace = j != words.Length - 1
                    ? 1
                    : maxWidth - builder.Length;
                builder.Append(new string(' ', tempSpace));
            }
            result.Add(builder.ToString());

            return result;
        }
    }
}
