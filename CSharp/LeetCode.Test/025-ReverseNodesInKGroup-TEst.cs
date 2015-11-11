using Microsoft.VisualStudio.TestTools.UnitTesting;
using ListNode = LeetCode._025_ReverseNodesInKGroup.ListNode;

namespace LeetCode.Test
{
    [TestClass]
    public class _025_ReverseNodesInKGroup_Test
    {
        [TestMethod]
        public void ReverseKGroupTest()
        {
            var input = GenerateList(new int[] { 1, 2, 3, 4, 5 });
            var solution = new _025_ReverseNodesInKGroup();

            var result = solution.ReverseKGroup(input, 2);
            AssertList(result, new int[] { 2, 1, 4, 3, 5 });

            input = GenerateList(new int[] { 1, 2, 3, 4, 5 });
            result = solution.ReverseKGroup(input, 3);
            AssertList(result, new int[] { 3, 2, 1, 4, 5 });
        }

        [TestMethod]
        public void ReverseKGroupTest_EmptyList()
        {
            var solution = new _025_ReverseNodesInKGroup();
            var result = solution.ReverseKGroup(null, 2);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void ReverseKGroupTest_KEqualZero()
        {
            var input = GenerateList(new int[] { 1, 2, 3, 4, 5 });

            var solution = new _025_ReverseNodesInKGroup();
            var result = solution.ReverseKGroup(input, 0);

            AssertList(result, new int[] { 1, 2, 3, 4, 5 });
        }

        [TestMethod]
        public void ReverseKGroupTest_KEqualOne()
        {
            var input = GenerateList(new int[] { 1, 2, 3, 4, 5 });

            var solution = new _025_ReverseNodesInKGroup();
            var result = solution.ReverseKGroup(input, 1);

            AssertList(result, new int[] { 1, 2, 3, 4, 5 });
        }

        [TestMethod]
        public void ReverseKGroupTest_KEqualLenght()
        {
            var input = GenerateList(new int[] { 1, 2, 3, 4, 5 });
            var solution = new _025_ReverseNodesInKGroup();

            var result = solution.ReverseKGroup(input, 5);
            AssertList(result, new int[] { 5, 4, 3, 2, 1 });
        }

        [TestMethod]
        public void ReverseKGroupTest_KLargerThanLenght()
        {
            var input = GenerateList(new int[] { 1, 2, 3, 4, 5 });
            var solution = new _025_ReverseNodesInKGroup();

            var result = solution.ReverseKGroup(input, 6);
            AssertList(result, new int[] { 1, 2, 3, 4, 5 });
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
