namespace LeetCode
{
    public class _005_LongestPalindromicSubstring
    {
        int Min(int a, int b)
        {
            return a < b ? a : b;
        }

        public string LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s) || s.Length == 1) { return s; }

            int n2 = s.Length * 2 + 1;
            var s2 = new char[n2];
            for (int i = 0; i < s.Length; i++)
            {
                s2[i * 2] = '#';
                s2[i * 2 + 1] = s[i];
            }
            s2[n2 - 1] = '#';

            var p = new int[n2];
            var range_max = 0;
            var center = 0;
            var longestPalindromeCenter = 0;

            for (int i = 1; i < n2 - 1; i++)
            {
                if (range_max > i)
                {
                    p[i] = p[center * 2 - i] < range_max - i ? p[center * 2 - i] : range_max - i;
                }

                while (i - 1 - p[i] >= 0 && i + 1 + p[i] < n2 && s2[i - 1 - p[i]] == s2[i + 1 + p[i]])
                {
                    p[i]++;
                }

                if (i + p[i] > range_max)
                {
                    range_max = i + p[i];
                    center = i;
                }

                if (p[i] > p[longestPalindromeCenter])
                {
                    longestPalindromeCenter = i;
                }
            }

            var range = p[longestPalindromeCenter];
            return s.Substring((longestPalindromeCenter - range) / 2, range);
        }
    }
}
