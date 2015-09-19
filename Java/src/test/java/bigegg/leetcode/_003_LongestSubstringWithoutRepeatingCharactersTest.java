package bigegg.leetcode;

import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class _003_LongestSubstringWithoutRepeatingCharactersTest {
    @Test
    public void testLengthOfLongestSubstring() throws Exception {
        String input = "abcabcbb";

        _003_LongestSubstringWithoutRepeatingCharacters solution = new _003_LongestSubstringWithoutRepeatingCharacters();
        int result = solution.lengthOfLongestSubstring(input);

        assertEquals(3, result);
    }

    @Test
    public void testLengthOfLongestSubstring_RepeatChars() throws Exception {
        String input = "bbbbb";

        _003_LongestSubstringWithoutRepeatingCharacters solution = new _003_LongestSubstringWithoutRepeatingCharacters();
        int result = solution.lengthOfLongestSubstring(input);

        assertEquals(1, result);
    }

    @Test
    public void testLengthOfLongestSubstring_EmptyInput() throws Exception {
        _003_LongestSubstringWithoutRepeatingCharacters solution = new _003_LongestSubstringWithoutRepeatingCharacters();
        int result = solution.lengthOfLongestSubstring("");

        assertEquals(0, result);
    }

    @Test
    public void testLengthOfLongestSubstring_LongString() throws Exception {
        String input = "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz";

        _003_LongestSubstringWithoutRepeatingCharacters solution = new _003_LongestSubstringWithoutRepeatingCharacters();
        int result = solution.lengthOfLongestSubstring(input);

        assertEquals(26, result);
    }

    @Test
    public void testLengthOfLongestSubstring_LongString_HaveShortRepeat() throws Exception {
        String input = "abcdefghijklmnopqrstuvwxyzabcdefghijk  lmnopqrstuvwxyz";

        _003_LongestSubstringWithoutRepeatingCharacters solution = new _003_LongestSubstringWithoutRepeatingCharacters();
        int result = solution.lengthOfLongestSubstring(input);

        assertEquals(27, result);
    }
}
