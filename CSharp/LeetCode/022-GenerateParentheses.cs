using System.Collections.Generic;

namespace LeetCode
{
    public class _022_GenerateParentheses
    {
        public IList<string> GenerateParenthesis(int n)
        {
            var results = new List<string>();
            if (n <= 0) { return results; }

            GenerateParenthesis(n, n, results, "");
            return results;
        }

        void GenerateParenthesis(int l, int r, IList<string> results, string s)
        {
            if (l == 0 && r == 0)
            {
                results.Add(s);
                return;
            }

            if (l > 0)
            {
                GenerateParenthesis(l - 1, r, results, s + "(");
            }

            if (r > 0 && r > l)
            {
                GenerateParenthesis(l, r - 1, results, s + ")");
            }
        }
    }
}
