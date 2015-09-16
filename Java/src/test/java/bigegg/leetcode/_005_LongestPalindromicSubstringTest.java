package bigegg.leetcode;

import org.junit.Assert;
import org.junit.Test;

import static org.junit.Assert.assertEquals;
import static org.junit.Assert.assertThat;

public class _005_LongestPalindromicSubstringTest {
    @Test
    public void GeneralTest_odd()
    {
        String input = "abcdefgfedcba";

        _005_LongestPalindromicSubstring solution = new _005_LongestPalindromicSubstring();
        String result = solution.longestPalindrome(input);

        assertEquals("abcdefgfedcba", result);
    }

    @Test
    public void GeneralTest_even()
    {
        String input = "abcdefggfedcba";

        _005_LongestPalindromicSubstring solution = new _005_LongestPalindromicSubstring();
        String result = solution.longestPalindrome(input);

        assertEquals("abcdefggfedcba", result);
    }

    @Test
    public void GeneralTest_AllTheSame()
    {
        String input = "aaaaaaaaaa";

        _005_LongestPalindromicSubstring solution = new _005_LongestPalindromicSubstring();
        String result = solution.longestPalindrome(input);

        assertEquals("aaaaaaaaaa", result);
    }

    @Test
    public void EmptyStringTest()
    {
        String input = "";

        _005_LongestPalindromicSubstring solution = new _005_LongestPalindromicSubstring();
        String result = solution.longestPalindrome(input);

        assertEquals("", result);
    }

    @Test
    public void OneCharacterStringTest()
    {
        String input = "a";

        _005_LongestPalindromicSubstring solution = new _005_LongestPalindromicSubstring();
        String result = solution.longestPalindrome(input);

        assertEquals("a", result);
    }

    @Test
    public void MultiplePalindrome_LongestAtStart()
    {
        String input = "aabccdccbaaeeggee";

        _005_LongestPalindromicSubstring solution = new _005_LongestPalindromicSubstring();
        String result = solution.longestPalindrome(input);

        assertEquals("aabccdccbaa", result);
    }

    @Test
    public void MultiplePalindrome_LongestAtEnd()
    {
        String input = "eegffgeeaabcdcbaa";

        _005_LongestPalindromicSubstring solution = new _005_LongestPalindromicSubstring();
        String result = solution.longestPalindrome(input);

        assertEquals("aabcdcbaa", result);
    }
}
