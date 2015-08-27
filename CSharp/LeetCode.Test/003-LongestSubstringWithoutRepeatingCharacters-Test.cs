using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _003_LongestSubstringWithoutRepeatingCharacters_Test
    {
        [TestMethod]
        public void GeneralTest()
        {
            var input = "abcabcbb";

            var solution = new _003_LongestSubstringWithoutRepeatingCharacters();
            var result = solution.LengthOfLongestSubstring(input);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void RepeatCharsTest()
        {
            var input = "bbbbb";

            var solution = new _003_LongestSubstringWithoutRepeatingCharacters();
            var result = solution.LengthOfLongestSubstring(input);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void EmptyInputTest()
        {
            var solution = new _003_LongestSubstringWithoutRepeatingCharacters();
            var result = solution.LengthOfLongestSubstring("");

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void LongStringTest()
        {
            var input = "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz";

            var solution = new _003_LongestSubstringWithoutRepeatingCharacters();
            var result = solution.LengthOfLongestSubstring(input);

            Assert.AreEqual(26, result);
        }

        [TestMethod]
        public void LongStringTest_HaveShortRepeat()
        {
            var input = "abcdefghijklmnopqrstuvwxyzabcdefghijk  lmnopqrstuvwxyz";

            var solution = new _003_LongestSubstringWithoutRepeatingCharacters();
            var result = solution.LengthOfLongestSubstring(input);

            Assert.AreEqual(27, result);
        }
    }
}
