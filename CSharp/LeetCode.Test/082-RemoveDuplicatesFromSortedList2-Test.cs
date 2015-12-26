using Microsoft.VisualStudio.TestTools.UnitTesting;
using ListNode = LeetCode._082_RemoveDuplicatesFromSortedList2.ListNode;

namespace LeetCode.Test
{
    [TestClass]
    public class _082_RemoveDuplicatesFromSortedList2_Test
    {
        [TestMethod]
        public void DeleteDuplicatesTest_WithoutDuplicate()
        {
            var input = GenerateList(new int[] { 1, 2, 3, 4, 5 });

            var solution = new _082_RemoveDuplicatesFromSortedList2();
            var result = solution.DeleteDuplicates(input);

            AssertList(new int[] { 1, 2, 3, 4, 5 }, result);
        }

        [TestMethod]
        public void DeleteDuplicatesTest_WithDuplicate()
        {
            var input = GenerateList(new int[] { 1, 2, 3, 3, 4, 5 });

            var solution = new _082_RemoveDuplicatesFromSortedList2();
            var result = solution.DeleteDuplicates(input);

            AssertList(new int[] { 1, 2, 4, 5 }, result);
        }

        [TestMethod]
        public void DeleteDuplicatesTest_WithMultipleDuplicate()
        {
            var input = GenerateList(new int[] { 1, 2, 3, 3, 4, 4, 5 });

            var solution = new _082_RemoveDuplicatesFromSortedList2();
            var result = solution.DeleteDuplicates(input);

            AssertList(new int[] { 1, 2, 5 }, result);
        }

        [TestMethod]
        public void DeleteDuplicatesTest_StartWithDuplicate()
        {
            var input = GenerateList(new int[] { 1, 1, 1, 2, 3, 4, 5 });

            var solution = new _082_RemoveDuplicatesFromSortedList2();
            var result = solution.DeleteDuplicates(input);

            AssertList(new int[] { 2, 3, 4, 5 }, result);
        }

        [TestMethod]
        public void DeleteDuplicatesTest_EndWithDuplicate()
        {
            var input = GenerateList(new int[] { 1, 2, 3, 4, 5, 5, 5 });

            var solution = new _082_RemoveDuplicatesFromSortedList2();
            var result = solution.DeleteDuplicates(input);

            AssertList(new int[] { 1, 2, 3, 4 }, result);
        }

        [TestMethod]
        public void DeleteDuplicatesTest_AllTheSame()
        {
            var input = GenerateList(new int[] { 1, 1, 1, 1, 1 });

            var solution = new _082_RemoveDuplicatesFromSortedList2();
            var result = solution.DeleteDuplicates(input);

            Assert.IsNull(result);
        }


        private ListNode GenerateList(int[] nums)
        {
            if (nums == null || nums.Length == 0) { return null; }

            var i = 0;
            var first = new ListNode(nums[i]);
            var current = first;

            while (++i < nums.Length)
            {
                current.next = new ListNode(nums[i]);
                current = current.next;
            }

            return first;
        }

        private void AssertList(int[] expected, ListNode actual)
        {
            Assert.IsNotNull(actual);
            Assert.IsNotNull(expected);
            Assert.IsTrue(expected.Length > 0);

            var current = actual;
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.IsNotNull(current);
                Assert.AreEqual(expected[i], current.val);
                current = current.next;
            }

            Assert.IsNull(current);
        }
    }
}
