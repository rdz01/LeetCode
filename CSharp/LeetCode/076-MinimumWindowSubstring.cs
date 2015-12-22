namespace LeetCode
{
    public class _076_MinimumWindowSubstring
    {
        public string MinWindow(string s, string t)
        {
            if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t) || t.Length > s.Length) { return string.Empty; }

            var expected_count = new int[256];
            var actual_count = new int[256];
            int i;

            for (i = 0; i < t.Length; i++) { expected_count[t[i]]++; }

            int minStart = 0, minWidth = int.MaxValue, currentWindowStart = 0, foundCharactersCount = 0;
            for (i = 0; i < s.Length; i++)
            {
                if (expected_count[s[i]] > 0)
                {
                    actual_count[s[i]]++;
                    if (actual_count[s[i]] <= expected_count[s[i]]) { foundCharactersCount++; }
                }

                if (foundCharactersCount == t.Length)
                {
                    while (actual_count[s[currentWindowStart]] > expected_count[s[currentWindowStart]] ||
                           expected_count[s[currentWindowStart]] == 0)
                    {
                        actual_count[s[currentWindowStart]]--;
                        currentWindowStart++;
                    }
                    if (minWidth > i - currentWindowStart + 1)
                    {
                        minWidth = i - currentWindowStart + 1;
                        minStart = currentWindowStart;
                    }
                }
            }

            return minWidth == int.MaxValue
                ? string.Empty
                : s.Substring(minStart, minWidth);
        }
    }
}
