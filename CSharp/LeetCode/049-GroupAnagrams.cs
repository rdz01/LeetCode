using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _049_GroupAnagrams
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var result = new List<IList<string>>();
            var mapping = new Dictionary<string, int>();

            var key = string.Empty;
            char[] ch;
            foreach (var str in strs)
            {
                ch = str.ToCharArray();
                Array.Sort(ch);
                key = new string(ch);
                if (!mapping.ContainsKey(key))
                {
                    result.Add(new List<string>());
                    mapping[key] = result.Count - 1;
                }
                result[mapping[key]].Add(str);
            }

            for (int i = 0; i < result.Count; i++)
            {
                result[i] = result[i].OrderBy(s => s).ToList();
            }

            return result;
        }
    }
}
