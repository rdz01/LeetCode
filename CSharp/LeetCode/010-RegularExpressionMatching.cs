namespace LeetCode
{
    public class _010_RegularExpressionMatching
    {
        public bool IsMatch(string s, string p)
        {
            return IsMatch(s, 0, p, 0);
        }

        bool IsMatch(string s, int sStartIndex, string p, int pStartIndex)
        {
            if (pStartIndex == p.Length) { return sStartIndex == s.Length; }

            if (pStartIndex + 1 >= p.Length || p[pStartIndex + 1] != '*')
            {
                if (sStartIndex < s.Length && (p[pStartIndex] == '.' || p[pStartIndex] == s[sStartIndex]))
                {
                    return IsMatch(s, sStartIndex + 1, p, pStartIndex + 1);
                }
                else
                {
                    return false;
                }
            }
            else
            {
                while (sStartIndex < s.Length && (p[pStartIndex] == '.' || p[pStartIndex] == s[sStartIndex]))
                {
                    if (IsMatch(s, sStartIndex, p, pStartIndex + 2))
                    {
                        return true;
                    }
                    sStartIndex++;
                }
                return IsMatch(s, sStartIndex, p, pStartIndex + 2);
            }
        }
    }
}
