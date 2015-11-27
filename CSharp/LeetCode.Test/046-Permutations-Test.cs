using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCode.Test
{
    [TestClass]
    public class _046_Permutations_Test
    {
        [TestMethod]
        public void PermuteTest()
        {
            var input = new int[] { 1, 2, 3 };

            var solution = new _046_Permutations();
            var result = solution.Permute(input);

            Assert.AreEqual(6, result.Count);
            AssertList(new List<IList<int>>()
            {
                new List<int> { 1, 2, 3 },
                new List<int> { 2, 1, 3 },
                new List<int> { 3, 2, 1 },
                new List<int> { 1, 3, 2 },
                new List<int> { 2, 3, 1 },
                new List<int> { 3, 1, 2 }
            }, result);
        }

        [TestMethod]
        public void PermuteTest_2()
        {
            var input = new int[] { 1, 2, 3, 4 };

            var solution = new _046_Permutations();
            var result = solution.Permute(input);

            Assert.AreEqual(24, result.Count);
        }

        [TestMethod]
        public void PermuteTest_OneItem()
        {
            var input = new int[] { 1 };

            var solution = new _046_Permutations();
            var result = solution.Permute(input);

            Assert.AreEqual(1, result.Count);
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
