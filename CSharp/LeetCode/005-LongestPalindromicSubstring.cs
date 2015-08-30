namespace LeetCode
{
    public class _005_LongestPalindromicSubstring
    {
        public string LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s) || s.Length == 1) { return s; }

            var longestPalindrome = "";
            var longestPalindromeLength = 0;
            for (int i = 0; i < s.Length - longestPalindromeLength / 2; i++)
            {
                var palindrome = GetPalindromeString(s, i, i);
                if (palindrome.Length > longestPalindromeLength)
                {
                    longestPalindrome = palindrome;
                    longestPalindromeLength = longestPalindrome.Length;
                }
                palindrome = GetPalindromeString(s, i, i + 1);
                if (palindrome.Length > longestPalindromeLength)
                {
                    longestPalindrome = palindrome;
                    longestPalindromeLength = longestPalindrome.Length;
                }
            }

            return longestPalindrome;
        }

        string GetPalindromeString(string s, int left, int right)
        {
            var hasPalindrome = false;
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                hasPalindrome = true;
                left--;
                right++;
            }
            return hasPalindrome ? s.Substring(left + 1, right - left - 1) : "";
        }
    }
}
