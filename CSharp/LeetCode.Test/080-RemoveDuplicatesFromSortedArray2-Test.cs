using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _080_RemoveDuplicatesFromSortedArray2_Test
    {
        [TestMethod]
        public void RemoveDuplicatesTest()
        {
            var input = new int[] { 1, 1, 2, 2, 2, 3 };

            var solution = new _080_RemoveDuplicatesFromSortedArray2();
            var result = solution.RemoveDuplicates(input);

            Assert.AreEqual(5, result);
            AssertArray(new int[] { 1, 1, 2, 2, 3 }, input);
        }

        [TestMethod]
        public void RemoveDuplicatesTest_2()
        {
            var input = new int[] { 1, 1, 1, 2, 2, 3 };

            var solution = new _080_RemoveDuplicatesFromSortedArray2();
            var result = solution.RemoveDuplicates(input);

            Assert.AreEqual(5, result);
            AssertArray(new int[] { 1, 1, 2, 2, 3 }, input);
        }

        [TestMethod]
        public void RemoveDuplicatesTest_EmptyInput()
        {
            var solution = new _080_RemoveDuplicatesFromSortedArray2();
            var result = solution.RemoveDuplicates(new int[] { });

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void RemoveDuplicatesTest_OneItem()
        {
            var input = new int[] { 1 };

            var solution = new _080_RemoveDuplicatesFromSortedArray2();
            var result = solution.RemoveDuplicates(input);

            Assert.AreEqual(1, result);
            AssertArray(new int[] { 1 }, input);
        }

        [TestMethod]
        public void RemoveDuplicatesTest_TwoItem()
        {
            var input = new int[] { 1, 1 };

            var solution = new _080_RemoveDuplicatesFromSortedArray2();
            var result = solution.RemoveDuplicates(input);

            Assert.AreEqual(2, result);
            AssertArray(new int[] { 1, 1 }, input);
        }

        private void AssertArray(int[] expected, int[] actual)
        {
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}
