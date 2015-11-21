using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCode.Test
{
    [TestClass]
    public class _039_CombinationSum_Test
    {
        [TestMethod]
        public void CombinationSumTest_WhenCandidiatesOrdered()
        {
            var solution = new _039_CombinationSum();
            var result = solution.CombinationSum(new int[] { 2, 3, 6, 7 }, 7);

            AssertList(new List<IList<int>>()
            {
                new List<int>() { 2, 2, 3 },
                new List<int>() { 7 }
            }, result);
        }

        [TestMethod]
        public void CombinationSumTest_WhenCandidiatesWithoutOrdered()
        {
            var solution = new _039_CombinationSum();
            var result = solution.CombinationSum(new int[] { 3, 6, 2, 7 }, 7);

            AssertList(new List<IList<int>>()
            {
                new List<int>() { 2, 2, 3 },
                new List<int>() { 7 }
            }, result);
        }

        [TestMethod]
        public void CombinationSumTest_NoMatch()
        {
            var solution = new _039_CombinationSum();
            var result = solution.CombinationSum(new int[] { 2, 3, 6, 7 }, 1);

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
