using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCode.Test
{
    [TestClass]
    public class _030_SubstringWithConcatenationOfAllWords_Test
    {
        [TestMethod]
        public void FindSubstringTest()
        {
            var solution = new _030_SubstringWithConcatenationOfAllWords();
            var result = solution.FindSubstring("barfoothefoobarman", new string[] { "foo", "bar" });

            AssertList(new List<int>() { 0, 9 }, result);
        }

        [TestMethod]
        public void FindSubstringTest_NoMatch()
        {
            var solution = new _030_SubstringWithConcatenationOfAllWords();
            var result = solution.FindSubstring("barfoothefoobarman", new string[] { "foo", "bar", "yeh" });

            AssertList(new List<int>(), result);
        }

        [TestMethod]
        public void FindSubstringTest_WordsEmpty()
        {
            var solution = new _030_SubstringWithConcatenationOfAllWords();
            var result = solution.FindSubstring("barfoothefoobarman", new string[] { });

            AssertList(new List<int>(), result);
        }

        [TestMethod]
        public void FindSubstringTest_AllTheSame()
        {
            var solution = new _030_SubstringWithConcatenationOfAllWords();
            var result = solution.FindSubstring("aaaaa", new string[] { "a" });

            AssertList(new List<int>() { 0, 1, 2, 3, 4 }, result);
        }

        [TestMethod]
        public void FindSubstringTest_WordsTooLong()
        {
            var solution = new _030_SubstringWithConcatenationOfAllWords();
            var result = solution.FindSubstring("barfoo", new string[] { "foo", "bar", "the" });

            AssertList(new List<int>(), result);
        }

        [TestMethod]
        public void FindSubstringTest_DuplicateWords()
        {
            var solution = new _030_SubstringWithConcatenationOfAllWords();
            var result = solution.FindSubstring("wordgoodgoodgoodbestword", new string[] { "word", "good", "best", "good" });

            AssertList(new List<int>() { 8 }, result);
        }


        private void AssertList(IList<int> expected, IList<int> actual)
        {
            Assert.IsNotNull(expected);
            Assert.IsNotNull(actual);
            Assert.AreEqual(expected.Count, actual.Count);

            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}
