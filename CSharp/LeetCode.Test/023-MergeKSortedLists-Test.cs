using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _023_MergeKSortedLists_Test
    {
        [TestMethod]
        public void MergeKListsTest()
        {
            var input = new ListNode[] {
                GenerateList(new int[] { 1, 3, 5, 7, 9 }),
                GenerateList(new int[] { 2, 4, 6, 8, 10 })
            };

            var solution = new _023_MergeKSortedLists();
            var result = solution.MergeKLists(input);

            AssertList(result, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
        }

        [TestMethod]
        public void MergeKListsTest_2()
        {
            var input = new ListNode[] {
                GenerateList(new int[] { 1, 3, 7 }),
                GenerateList(new int[] { 2, 10 }),
                GenerateList(new int[] { 5, 9 }),
                GenerateList(new int[] { 4, 6, 8})
            };

            var solution = new _023_MergeKSortedLists();
            var result = solution.MergeKLists(input);

            AssertList(result, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
        }

        [TestMethod]
        public void MergeKListsTest_OneList()
        {
            var input = new ListNode[] {
                GenerateList(new int[] { 1, 2, 3 })
            };

            var solution = new _023_MergeKSortedLists();
            var result = solution.MergeKLists(input);

            AssertList(result, new int[] { 1, 2, 3 });
        }

        [TestMethod]
        public void MergeKListsTest_EmptyList()
        {
            var input = new ListNode[] { };

            var solution = new _023_MergeKSortedLists();
            var result = solution.MergeKLists(input);

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
