using System.Collections.Generic;

namespace LeetCode
{
    public class _013_RomanToInteger
    {
        static IDictionary<int, int> mapping;

        static _013_RomanToInteger()
        {
            mapping = new Dictionary<int, int>();
            mapping.Add('M', 1000);
            mapping.Add('D', 500);
            mapping.Add('C', 100);
            mapping.Add('L', 50);
            mapping.Add('X', 10);
            mapping.Add('V', 5);
            mapping.Add('I', 1);
        }

        public int RomanToInt(string s)
        {
            var result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i > 0 && mapping[s[i]] > mapping[s[i - 1]])
                {
                    result += mapping[s[i]] - mapping[s[i - 1]] * 2;
                }
                else
                {
                    result += mapping[s[i]];
                }
            }

            return result;
        }
    }
}
