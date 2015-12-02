using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCode.Test
{
    [TestClass]
    public class _049_GroupAnagrams_Test
    {
        [TestMethod]
        public void GroupAnagramsTest()
        {
            var input = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };

            var solution = new _049_GroupAnagrams();
            var result = solution.GroupAnagrams(input);

            AssertList(
                new List<IList<string>>()
                {
                    new List<string> () { "ate", "eat", "tea" },
                    new List<string> () { "nat","tan" },
                    new List<string> () { "bat" }
                }, result);
        }

        [TestMethod]
        public void GroupAnagramsTest_Empty()
        {
            var input = new string[] { };

            var solution = new _049_GroupAnagrams();
            var result = solution.GroupAnagrams(input);

            Assert.AreEqual(0, result.Count);
        }

        void AssertList(IList<IList<string>> expected, IList<IList<string>> actual)
        {
            Assert.AreEqual(expected.Count, actual.Count);

            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i].Count, actual[i].Count);
                for (int j = 0; j < expected[i].Count; j++)
                {
                    Assert.AreEqual(expected[i][j], actual[i][j]);
                }
            }
        }
    }
}
