using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _002_AddTwoNumbers_Test
    {
        [TestMethod]
        public void AddTwoNumbersTest_General()
        {
            var link = GenerateList(new int[] { 2, 4, 3 });

            var solution = new _002_AddTwoNumbers();
            var result = solution.AddTwoNumbers(link, link);

            AssertList(result, new int[] { 4, 8, 6 });
        }

        [TestMethod]
        public void AddTwoNumbersTest_General_2()
        {
            var link = GenerateList(new int[] { 0 });

            var solution = new _002_AddTwoNumbers();
            var result = solution.AddTwoNumbers(link, link);

            AssertList(result, new int[] { 0 });
        }

        [TestMethod]
        public void AddTwoNumbersTest_HasCarry()
        {
            var link1 = GenerateList(new int[] { 2, 4, 3 });
            var link2 = GenerateList(new int[] { 5, 6, 4 });

            var solution = new _002_AddTwoNumbers();
            var result = solution.AddTwoNumbers(link1, link2);

            AssertList(result, new int[] { 7, 0, 8 });
        }

        [TestMethod]
        public void AddTwoNumbersTest_HasMultipleCarry()
        {
            var link1 = GenerateList(new int[] { 1 });
            var link2 = GenerateList(new int[] { 9, 9 });

            var solution = new _002_AddTwoNumbers();
            var result = solution.AddTwoNumbers(link1, link2);

            AssertList(result, new int[] { 0, 0, 1 });
        }

        [TestMethod]
        public void AddTwoNumbersTest_FirstNumCarry()
        {
            var link1 = GenerateList(new int[] { 3, 4, 4 });
            var link2 = GenerateList(new int[] { 3, 4, 6 });

            var solution = new _002_AddTwoNumbers();
            var result = solution.AddTwoNumbers(link1, link2);

            AssertList(result, new int[] { 6, 8, 0, 1 });
        }

        [TestMethod]
        public void AddTwoNumbersTest_L1Longer()
        {
            var link1 = GenerateList(new int[] { 2, 4, 3, 1 });
            var link2 = GenerateList(new int[] { 5, 6, 4 });

            var solution = new _002_AddTwoNumbers();
            var result = solution.AddTwoNumbers(link1, link2);

            AssertList(result, new int[] { 7, 0, 8, 1 });
        }

        [TestMethod]
        public void AddTwoNumbersTest_L1Longer_2()
        {
            var link1 = GenerateList(new int[] { 1, 8 });
            var link2 = GenerateList(new int[] { 0 });

            var solution = new _002_AddTwoNumbers();
            var result = solution.AddTwoNumbers(link1, link2);

            AssertList(result, new int[] { 1, 8 });
        }

        [TestMethod]
        public void AddTwoNumbersTest_L1Empty()
        {
            var link1 = GenerateList(null);
            var link2 = GenerateList(new int[] { 1, 8 });

            var solution = new _002_AddTwoNumbers();
            var result = solution.AddTwoNumbers(link1, link2);

            AssertList(result, new int[] { 1, 8 });
        }

        [TestMethod]
        public void AddTwoNumbersTest_L2Longer()
        {
            var link1 = GenerateList(new int[] { 2, 4, 3 });
            var link2 = GenerateList(new int[] { 5, 6, 4, 3 });

            var solution = new _002_AddTwoNumbers();
            var result = solution.AddTwoNumbers(link1, link2);

            AssertList(result, new int[] { 7, 0, 8, 3 });
        }

        [TestMethod]
        public void AddTwoNumbersTest_L2Longer_2()
        {
            var link1 = GenerateList(new int[] { 0 });
            var link2 = GenerateList(new int[] { 1, 8 });

            var solution = new _002_AddTwoNumbers();
            var result = solution.AddTwoNumbers(link1, link2);

            AssertList(result, new int[] { 1, 8 });
        }

        [TestMethod]
        public void AddTwoNumbersTest_L2Empty()
        {
            var link1 = GenerateList(new int[] { 1, 8 });
            var link2 = GenerateList(null);

            var solution = new _002_AddTwoNumbers();
            var result = solution.AddTwoNumbers(link1, link2);

            AssertList(result, new int[] { 1, 8 });
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
