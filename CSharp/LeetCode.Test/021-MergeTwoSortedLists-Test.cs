using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _021_MergeTwoSortedLists_Test
    {
        [TestMethod]
        public void MergeTwoListsTest()
        {
            var list1 = GenerateList(new int[] { 1, 3, 5, 7, 9 });
            var list2 = GenerateList(new int[] { 2, 4, 6, 8, 10 });

            var solution = new _021_MergeTwoSortedLists();
            var result = solution.MergeTwoLists(list1, list2);

            AssertList(result, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
        }

        [TestMethod]
        public void MergeTwoListsTest_List1Longer()
        {
            var list1 = GenerateList(new int[] { 1, 3, 5, 7, 9, 11, 13 });
            var list2 = GenerateList(new int[] { 2, 4, 6, 8, 10 });

            var solution = new _021_MergeTwoSortedLists();
            var result = solution.MergeTwoLists(list1, list2);

            AssertList(result, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 13 });
        }

        [TestMethod]
        public void MergeTwoListsTest_List2Longer()
        {
            var list1 = GenerateList(new int[] { 1, 3, 5, 7, 9 });
            var list2 = GenerateList(new int[] { 2, 4, 6, 8, 10, 12, 14 });

            var solution = new _021_MergeTwoSortedLists();
            var result = solution.MergeTwoLists(list1, list2);

            AssertList(result, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 14 });
        }

        [TestMethod]
        public void MergeTwoListsTest_List1Empty()
        {
            var list2 = GenerateList(new int[] { 2, 4, 6, 8, 10 });

            var solution = new _021_MergeTwoSortedLists();
            var result = solution.MergeTwoLists(null, list2);

            AssertList(result, new int[] { 2, 4, 6, 8, 10 });
        }

        [TestMethod]
        public void MergeTwoListsTest_List2Empty()
        {
            var list1 = GenerateList(new int[] { 1, 3, 5, 7, 9 });

            var solution = new _021_MergeTwoSortedLists();
            var result = solution.MergeTwoLists(list1, null);

            AssertList(result, new int[] { 1, 3, 5, 7, 9 });
        }

        [TestMethod]
        public void MergeTwoListsTest_BothListEmpty()
        {
            var solution = new _021_MergeTwoSortedLists();
            var result = solution.MergeTwoLists(null, null);
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
