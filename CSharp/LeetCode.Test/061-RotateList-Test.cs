using Microsoft.VisualStudio.TestTools.UnitTesting;
using ListNode = LeetCode._061_RotateList.ListNode;

namespace LeetCode.Test
{
    [TestClass]
    public class _061_RotateList_Test
    {
        [TestMethod]
        public void RotateRightTest()
        {
            var input = GenerateList(new int[] { 1, 2, 3, 4, 5 });

            var solution = new _061_RotateList();
            var result = solution.RotateRight(input, 3);

            AssertList(new int[] { 3, 4, 5, 1, 2 }, result);
        }

        [TestMethod]
        public void RotateRightTest_EmptyInput()
        {
            var solution = new _061_RotateList();
            var result = solution.RotateRight(null, 3);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void RotateRightTest_KLessThanZero()
        {
            var input = GenerateList(new int[] { 1, 2, 3, 4, 5 });

            var solution = new _061_RotateList();
            var result = solution.RotateRight(input, -1);

            AssertList(new int[] { 1, 2, 3, 4, 5 }, result);
        }

        [TestMethod]
        public void RotateRightTest_KEqualZero()
        {
            var input = GenerateList(new int[] { 1, 2, 3, 4, 5 });

            var solution = new _061_RotateList();
            var result = solution.RotateRight(input, 0);

            AssertList(new int[] { 1, 2, 3, 4, 5 }, result);
        }

        [TestMethod]
        public void RotateRightTest_KLargerThanLenght()
        {
            var input = GenerateList(new int[] { 1, 2, 3, 4, 5 });

            var solution = new _061_RotateList();
            var result = solution.RotateRight(input, 6);

            AssertList(new int[] { 5, 1, 2, 3, 4 }, result);
        }

        [TestMethod]
        public void RotateRightTest_KEqualToLenght()
        {
            var input = GenerateList(new int[] { 1, 2, 3, 4, 5 });

            var solution = new _061_RotateList();
            var result = solution.RotateRight(input, 5);

            AssertList(new int[] { 1, 2, 3, 4, 5 }, result);
        }

        [TestMethod]
        public void RotateRightTest_OneItem()
        {
            var input = GenerateList(new int[] { 1 });

            var solution = new _061_RotateList();
            var result = solution.RotateRight(input, 5);

            AssertList(new int[] { 1 }, result);
        }

        [TestMethod]
        [Timeout(100)]
        public void RotateRightTest_LargeK()
        {
            var input = GenerateList(new int[] { 1, 2, 3 });

            var solution = new _061_RotateList();
            var result = solution.RotateRight(input, 2000000000);

            AssertList(new int[] { 2, 3, 1 }, result);
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
