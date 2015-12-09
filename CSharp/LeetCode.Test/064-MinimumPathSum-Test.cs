using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _064_MinimumPathSum_Test
    {
        [TestMethod]
        public void MinPathSumTest()
        {
            var input = new int[3, 3]
            {
                { 1, 2, 2 },
                { 0, 1, 1 },
                { 0, 0, 1 }
            };

            var solution = new _064_MinimumPathSum();
            var result = solution.MinPathSum(input);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void MinPathSumTest_OneItem()
        {
            var input = new int[1, 1]
            {
                { 5 }
            };

            var solution = new _064_MinimumPathSum();
            var result = solution.MinPathSum(input);

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void MinPathSumTest_RowLarger()
        {
            var input = new int[4, 3]
            {
                { 1, 2, 2 },
                { 0, 2, 2 },
                { 1, 1, 2 },
                { 0, 1, 1 },
            };

            var solution = new _064_MinimumPathSum();
            var result = solution.MinPathSum(input);

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void MinPathSumTest_ColumnLarger()
        {
            var input = new int[3, 4]
            {
                { 1, 0, 1, 0 },
                { 2, 2, 1, 1 },
                { 2, 2, 2, 1 }
            };

            var solution = new _064_MinimumPathSum();
            var result = solution.MinPathSum(input);

            Assert.AreEqual(4, result);
        }
    }
}
