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

            var ch = string.Empty;
            foreach (var str in strs)
            {
                ch = new string(str.OrderBy(c => c).ToArray());
                if (!mapping.ContainsKey(ch))
                {
                    result.Add(new List<string>());
                    mapping[ch] = result.Count - 1;
                }
                result[mapping[ch]].Add(str);
            }

            for (int i = 0; i < result.Count; i++)
            {
                result[i] = result[i].OrderBy(s => s).ToList();
            }

            return result;
        }
    }
}
