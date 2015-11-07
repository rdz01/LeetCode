using Microsoft.VisualStudio.TestTools.UnitTesting;
using ListNode = LeetCode._019_RemoveNthNodeFromEndOfList.ListNode;

namespace LeetCode.Test
{
    [TestClass]
    public class _019_RemoveNthNodeFromEndOfList_Test
    {
        [TestMethod]
        public void RemoveNthFromEndTest()
        {
            var input = GenerateList(new int[] { 1, 2, 3, 4, 5 });

            var solution = new _019_RemoveNthNodeFromEndOfList();
            var result = solution.RemoveNthFromEnd(input, 2);

            AssertList(result, new int[] { 1, 2, 3, 5 });
        }

        [TestMethod]
        public void RemoveNthFromEndTest_ListNull()
        {
            var solution = new _019_RemoveNthNodeFromEndOfList();
            var result = solution.RemoveNthFromEnd(null, 2);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void RemoveNthFromEndTest_NEqualZero()
        {
            var input = GenerateList(new int[] { 1, 2, 3, 4, 5 });

            var solution = new _019_RemoveNthNodeFromEndOfList();
            var result = solution.RemoveNthFromEnd(input, 0);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void RemoveNthFromEndTest_NLessThanZero()
        {
            var input = GenerateList(new int[] { 1, 2, 3, 4, 5 });

            var solution = new _019_RemoveNthNodeFromEndOfList();
            var result = solution.RemoveNthFromEnd(input, -1);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void RemoveNthFromEndTest_LargerThanList()
        {
            var input = GenerateList(new int[] { 1, 2, 3, 4, 5 });

            var solution = new _019_RemoveNthNodeFromEndOfList();
            var result = solution.RemoveNthFromEnd(input, 6);

            AssertList(result, new int[] { 1, 2, 3, 4, 5 });
        }

        [TestMethod]
        public void RemoveNthFromEndTest_FirstOne()
        {
            var input = GenerateList(new int[] { 1, 2, 3, 4, 5 });

            var solution = new _019_RemoveNthNodeFromEndOfList();
            var result = solution.RemoveNthFromEnd(input, 5);

            AssertList(result, new int[] { 2, 3, 4, 5 });
        }

        [TestMethod]
        public void RemoveNthFromEndTest_LastOne()
        {
            var input = GenerateList(new int[] { 1, 2, 3, 4, 5 });

            var solution = new _019_RemoveNthNodeFromEndOfList();
            var result = solution.RemoveNthFromEnd(input, 1);

            AssertList(result, new int[] { 1, 2, 3, 4 });
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

        private void AssertList(ListNode first, int[] nums)
        {
            Assert.IsNotNull(first);
            Assert.IsNotNull(nums);
            Assert.IsTrue(nums.Length > 0);

            var current = first;
            for (int i = 0; i < nums.Length; i++)
            {
                Assert.IsNotNull(current);
                Assert.AreEqual(nums[i], current.val);
                current = current.next;
            }

            Assert.IsNull(current);
        }
    }
}
