using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _026_RemoveDuplicatesFromSortedArray_Test
    {
        [TestMethod]
        public void RemoveDuplicatesTest()
        {
            var input = new int[] { 1, 1, 2 };

            var solution = new _026_RemoveDuplicatesFromSortedArray();
            var result = solution.RemoveDuplicates(input);

            Assert.AreEqual(2, result);
            AssertArray(new int[] { 1, 2 }, input);
        }

        [TestMethod]
        public void RemoveDuplicatesTest_EmptyInput()
        {
            var solution = new _026_RemoveDuplicatesFromSortedArray();
            var result = solution.RemoveDuplicates(new int[] { });

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void RemoveDuplicatesTest_OneItem()
        {
            var input = new int[] { 1 };

            var solution = new _026_RemoveDuplicatesFromSortedArray();
            var result = solution.RemoveDuplicates(input);

            Assert.AreEqual(1, result);
            AssertArray(new int[] { 1 }, input);
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
