using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCode.Test
{
    [TestClass]
    public class _078_Subsets_Test
    {
        [TestMethod]
        public void SubsetsTest()
        {
            var solution = new _078_Subsets();
            var result = solution.Subsets(new int[] { 1, 2, 3 });

            Assert.AreEqual(8, result.Count);
            AssertList(new int[] { }, result[0]);
            AssertList(new int[] { 1 }, result[1]);
            AssertList(new int[] { 2 }, result[2]);
            AssertList(new int[] { 1, 2 }, result[3]);
            AssertList(new int[] { 3 }, result[4]);
            AssertList(new int[] { 1, 3 }, result[5]);
            AssertList(new int[] { 2, 3 }, result[6]);
            AssertList(new int[] { 1, 2, 3 }, result[7]);
        }

        [TestMethod]
        public void SubsetsTest_NotOrdered()
        {
            var solution = new _078_Subsets();
            var result = solution.Subsets(new int[] { 3, 2, 1 });

            Assert.AreEqual(8, result.Count);
            AssertList(new int[] { }, result[0]);
            AssertList(new int[] { 1 }, result[1]);
            AssertList(new int[] { 2 }, result[2]);
            AssertList(new int[] { 1, 2 }, result[3]);
            AssertList(new int[] { 3 }, result[4]);
            AssertList(new int[] { 1, 3 }, result[5]);
            AssertList(new int[] { 2, 3 }, result[6]);
            AssertList(new int[] { 1, 2, 3 }, result[7]);
        }

        [TestMethod]
        public void SubsetsTest_EmptyNums()
        {
            var solution = new _078_Subsets();
            var result = solution.Subsets(new int[] { });

            Assert.AreEqual(1, result.Count);
            AssertList(new int[] { }, result[0]);
        }

        [TestMethod]
        public void SubsetsTest_OneItem()
        {
            var solution = new _078_Subsets();
            var result = solution.Subsets(new int[] { 1 });

            Assert.AreEqual(2, result.Count);
            AssertList(new int[] { }, result[0]);
            AssertList(new int[] { 1 }, result[1]);
        }


        private void AssertList(int[] expected, IList<int> actual)
        {
            Assert.AreEqual(expected.Length, actual.Count);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}
