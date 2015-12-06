using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCode.Test
{
    [TestClass]
    public class _056_MergeIntervals_Test
    {
        [TestMethod]
        public void MergeTest()
        {
            var input = new[]
            {
                new _056_MergeIntervals.Interval(1, 3),
                new _056_MergeIntervals.Interval(2, 6),
                new _056_MergeIntervals.Interval(8, 10),
                new _056_MergeIntervals.Interval(15, 18),
            };

            var solution = new _056_MergeIntervals();
            var result = solution.Merge(input);

            Assert.AreEqual(3, result.Count);
            Assert.AreEqual(1, result[0].start);
            Assert.AreEqual(6, result[0].end);
            Assert.AreEqual(8, result[1].start);
            Assert.AreEqual(10, result[1].end);
            Assert.AreEqual(15, result[2].start);
            Assert.AreEqual(18, result[2].end);
        }

        [TestMethod]
        public void MergeTest_NotOrdered()
        {
            var input = new[]
            {
                new _056_MergeIntervals.Interval(1, 3),
                new _056_MergeIntervals.Interval(0, 2)
            };

            var solution = new _056_MergeIntervals();
            var result = solution.Merge(input);

            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(0, result[0].start);
            Assert.AreEqual(3, result[0].end);
        }

        [TestMethod]
        public void MergeTest_Empty()
        {
            var input = new List<_056_MergeIntervals.Interval>();

            var solution = new _056_MergeIntervals();
            var result = solution.Merge(input);

            Assert.AreEqual(0, result.Count);
        }
    }
}
