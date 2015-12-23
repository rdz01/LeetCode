﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCode.Test
{
    [TestClass]
    public class _077_Combinations_Test
    {
        [TestMethod]
        public void CombineTest()
        {
            var solution = new _077_Combinations();
            var result = solution.Combine(4, 2);

            Assert.AreEqual(6, result.Count);
            AssertList(new int[] { 1, 2 }, result[0]);
            AssertList(new int[] { 1, 3 }, result[1]);
            AssertList(new int[] { 2, 3 }, result[2]);
            AssertList(new int[] { 1, 4 }, result[3]);
            AssertList(new int[] { 2, 4 }, result[4]);
            AssertList(new int[] { 3, 4 }, result[5]);
        }

        [TestMethod]
        public void CombineTest_2()
        {
            var solution = new _077_Combinations();
            var result = solution.Combine(5, 2);

            Assert.AreEqual(10, result.Count);
        }

        [TestMethod]
        public void CombineTest_KEqualN()
        {
            var solution = new _077_Combinations();
            var result = solution.Combine(4, 4);

            Assert.AreEqual(1, result.Count);
            AssertList(new int[] { 1, 2, 3, 4 }, result[0]);
        }

        [TestMethod]
        public void CombineTest_NLessThanK()
        {
            var solution = new _077_Combinations();
            var result = solution.Combine(2, 3);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void CombineTest_NEqual0()
        {
            var solution = new _077_Combinations();
            var result = solution.Combine(0, 3);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void CombineTest_KEqual0()
        {
            var solution = new _077_Combinations();
            var result = solution.Combine(4, 0);

            Assert.IsNull(result);
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
