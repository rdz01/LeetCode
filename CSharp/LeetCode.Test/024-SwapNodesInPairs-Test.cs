using Microsoft.VisualStudio.TestTools.UnitTesting;
using ListNode = LeetCode._024_SwapNodesInPairs.ListNode;

namespace LeetCode.Test
{
    [TestClass]
    public class _024_SwapNodesInPairs_Test
    {
        [TestMethod]
        public void SwapPairsTest()
        {
            var input = GenerateList(new int[] { 1, 2, 3, 4 });

            var solution = new _024_SwapNodesInPairs();
            var result = solution.SwapPairs(input);

            AssertList(result, new int[] { 2, 1, 4, 3 });
        }

        [TestMethod]
        public void SwapPairsTest_EmptyList()
        {
            var solution = new _024_SwapNodesInPairs();
            var result = solution.SwapPairs(null);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void SwapPairsTest_OnlyOneNode()
        {
            var input = GenerateList(new int[] { 1 });

            var solution = new _024_SwapNodesInPairs();
            var result = solution.SwapPairs(input);

            AssertList(result, new int[] { 1 });
        }

        [TestMethod]
        public void SwapPairsTest_NotEnough()
        {
            var input = GenerateList(new int[] { 1, 2, 3 });

            var solution = new _024_SwapNodesInPairs();
            var result = solution.SwapPairs(input);

            AssertList(result, new int[] { 2, 1, 3 });
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
