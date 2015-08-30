using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _005_LongestPalindromicSubstring_Test
    {
        [TestMethod]
        public void GeneralTest_even()
        {
            var input = "abcdefgfedcba";

            var solution = new _005_LongestPalindromicSubstring();
            var result = solution.LongestPalindrome(input);

            Assert.AreEqual("abcdefgfedcba", result);
        }

        [TestMethod]
        public void GeneralTest_odd()
        {
            var input = "abcdefggfedcba";

            var solution = new _005_LongestPalindromicSubstring();
            var result = solution.LongestPalindrome(input);

            Assert.AreEqual("abcdefggfedcba", result);
        }

        [TestMethod]
        public void GeneralTest_AllTheSame()
        {
            var input = "aaaaaaaaaa";

            var solution = new _005_LongestPalindromicSubstring();
            var result = solution.LongestPalindrome(input);

            Assert.AreEqual("aaaaaaaaaa", result);
        }

        [TestMethod]
        public void EmptyStringTest()
        {
            var input = "";

            var solution = new _005_LongestPalindromicSubstring();
            var result = solution.LongestPalindrome(input);

            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void OneCharacterStringTest()
        {
            var input = "a";

            var solution = new _005_LongestPalindromicSubstring();
            var result = solution.LongestPalindrome(input);

            Assert.AreEqual("a", result);
        }

        [TestMethod]
        public void MultiplePalindrome_LongestAtStart()
        {
            var input = "aabccdccbaaeeggee";

            var solution = new _005_LongestPalindromicSubstring();
            var result = solution.LongestPalindrome(input);

            Assert.AreEqual("aabccdccbaa", result);
        }

        [TestMethod]
        public void MultiplePalindrome_LongestAtEnd()
        {
            var input = "eegffgeeaabcdcbaa";

            var solution = new _005_LongestPalindromicSubstring();
            var result = solution.LongestPalindrome(input);

            Assert.AreEqual("aabcdcbaa", result);
        }
    }
}
