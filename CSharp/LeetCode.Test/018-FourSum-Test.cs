using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCode.Test
{
    [TestClass]
    public class _018_FourSum_Test
    {
        [TestMethod]
        public void FourSumTest()
        {
            int[] input = { 1, 0, -1, 0, -2, 2 };

            var solution = new _018_4Sum();
            var result = solution.FourSum(input, 0);

            Assert.AreEqual(3, result.Count);
            AssertList(new List<int> { -2, -1, 1, 2 }, result[0]);
            AssertList(new List<int> { -2, 0, 0, 2 }, result[1]);
            AssertList(new List<int> { -1, 0, 0, 1 }, result[2]);
        }

        [TestMethod]
        public void FourSumTest_2()
        {
            int[] input = { 1, 4, -3, 0, 0, 0, 5, 0 };

            var solution = new _018_4Sum();
            var result = solution.FourSum(input, 0);

            Assert.AreEqual(1, result.Count);
            AssertList(new List<int> { 0, 0, 0, 0 }, result[0]);
        }

        [TestMethod]
        public void FourSumTest_Empty()
        {
            int[] input = { };

            var solution = new _018_4Sum();
            var result = solution.FourSum(input, 0);

            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void FourSumTest_NotEnough()
        {
            var solution = new _018_4Sum();

            int[] input1 = { -1 };
            var result = solution.FourSum(input1, 0);
            Assert.AreEqual(0, result.Count);

            int[] input2 = { -1, 0 };
            result = solution.FourSum(input2, 0);
            Assert.AreEqual(0, result.Count);

            int[] input3 = { -1, 0, 1 };
            result = solution.FourSum(input3, 0);
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void FourSumTest_AllTheSame()
        {
            int[] input = { 0, 0, 0, 0, 0, 0 };

            var solution = new _018_4Sum();
            var result = solution.FourSum(input, 0);
            Assert.AreEqual(1, result.Count);
            AssertList(new List<int> { 0, 0, 0, 0 }, result[0]);

            result = solution.FourSum(input, 1);
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void FourSumTest_SomeDuplicate()
        {
            int[] input = { 1, 0, 0, 1, 0, 0, -1, -1, 0, 0 };

            var solution = new _018_4Sum();
            var result = solution.FourSum(input, 0);
            Assert.AreEqual(3, result.Count);
            AssertList(new List<int> { -1, -1, 1, 1 }, result[0]);
            AssertList(new List<int> { -1, 0, 0, 1 }, result[1]);
            AssertList(new List<int> { 0, 0, 0, 0 }, result[2]);

            result = solution.FourSum(input, 1);
            Assert.AreEqual(2, result.Count);
            AssertList(new List<int> { -1, 0, 1, 1 }, result[0]);
            AssertList(new List<int> { 0, 0, 0, 1 }, result[1]);
        }


        private void AssertList(IList<int> expected, IList<int> actual)
        {
            Assert.AreEqual(expected.Count, actual.Count);

            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}
