package bigegg.leetcode;

public class _005_LongestPalindromicSubstring {
    public String longestPalindrome(String s) {
        if (s == null || s.length() <= 1) {
            return s;
        }

        String longestPalindrome = "";
        int longestPalindromeLength = 0;
        for (int i = 0; i < s.length() - longestPalindromeLength / 2; i++) {
            String palindrome = getPalindromeString(s, i, i);
            if (palindrome.length() > longestPalindromeLength) {
                longestPalindrome = palindrome;
                longestPalindromeLength = palindrome.length();
            }
            palindrome = getPalindromeString(s, i, i + 1);
            if (palindrome.length() > longestPalindromeLength) {
                longestPalindrome = palindrome;
                longestPalindromeLength = palindrome.length();
            }
        }

        return longestPalindrome;
    }

    private String getPalindromeString(String s, int left, int right) {
        boolean hasPalindromeString = false;
        while (left >= 0 && right < s.length() && s.charAt(left) == s.charAt(right)) {
            left--;
            right++;
            hasPalindromeString = true;
        }

        return hasPalindromeString ? s.substring(left + 1, right) : "";
    }
}
