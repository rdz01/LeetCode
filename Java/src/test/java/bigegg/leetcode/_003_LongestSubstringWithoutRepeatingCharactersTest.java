package bigegg.leetcode;

import junit.framework.Assert;
import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class _003_LongestSubstringWithoutRepeatingCharactersTest {
    @Test
    public void GeneralTest() throws  Exception
    {
        String input = "abcabcbb";

        _003_LongestSubstringWithoutRepeatingCharacters solution = new _003_LongestSubstringWithoutRepeatingCharacters();
        int result = solution.lengthOfLongestSubstring(input);

        assertEquals(3, result);
    }

    @Test
    public void RepeatCharsTest()throws  Exception
    {
        String input = "bbbbb";

        _003_LongestSubstringWithoutRepeatingCharacters solution = new _003_LongestSubstringWithoutRepeatingCharacters();
        int result = solution.lengthOfLongestSubstring(input);

        assertEquals(1, result);
    }

    @Test
    public void EmptyInputTest()throws  Exception
    {
        _003_LongestSubstringWithoutRepeatingCharacters solution = new _003_LongestSubstringWithoutRepeatingCharacters();
        int result = solution.lengthOfLongestSubstring("");

        assertEquals(0, result);
    }

    @Test
    public void LongStringTest()throws  Exception
    {
        String input = "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz";

        _003_LongestSubstringWithoutRepeatingCharacters solution = new _003_LongestSubstringWithoutRepeatingCharacters();
        int result = solution.lengthOfLongestSubstring(input);

        assertEquals(26, result);
    }

    @Test
    public void LongStringTest_HaveShortRepeat()throws  Exception
    {
        String input = "abcdefghijklmnopqrstuvwxyzabcdefghijk  lmnopqrstuvwxyz";

        _003_LongestSubstringWithoutRepeatingCharacters solution = new _003_LongestSubstringWithoutRepeatingCharacters();
        int result = solution.lengthOfLongestSubstring(input);

        assertEquals(27, result);
    }
}
