using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCode.Test
{
    [TestClass]
    public class _040_CombinationSum2_Test
    {
        [TestMethod]
        public void CombinationSum2Test_WhenCandidiatesOrdered()
        {
            var solution = new _040_CombinationSum2();
            var result = solution.CombinationSum2(new int[] { 1, 1, 2, 5, 6, 7, 10 }, 8);

            AssertList(new List<IList<int>>()
            {
                new List<int>() { 1, 1, 6 },
                new List<int>() { 1, 2, 5 },
                new List<int>() { 1, 7 },
                new List<int>() { 2, 6 }
            }, result);
        }

        [TestMethod]
        public void CombinationSum2Test_WhenCandidiatesWithoutOrdered()
        {
            var solution = new _040_CombinationSum2();
            var result = solution.CombinationSum2(new int[] { 10, 1, 2, 7, 6, 1, 5 }, 8);

            AssertList(new List<IList<int>>()
            {
                new List<int>() { 1, 1, 6 },
                new List<int>() { 1, 2, 5 },
                new List<int>() { 1, 7 },
                new List<int>() { 2, 6 }
            }, result);
        }

        [TestMethod]
        public void CombinationSum2Test_NoMatch()
        {
            var solution = new _040_CombinationSum2();
            var result = solution.CombinationSum2(new int[] { 2, 3, 6, 7 }, 1);

            AssertList(new List<IList<int>>() { }, result);
        }


        void AssertList(IList<IList<int>> expected, IList<IList<int>> actual)
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
