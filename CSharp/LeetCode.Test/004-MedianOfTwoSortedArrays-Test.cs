using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _004_MedianOfTwoSortedArrays_Test
    {
        [TestMethod]
        public void FindMedianSortedArraysTest_General_Odd()
        {
            int[] nums1 = { 1, 2, 3 };
            int[] nums2 = { 3, 4, 5 };

            var solution = new _004_MedianOfTwoSortedArrays();
            var result = solution.FindMedianSortedArrays(nums1, nums2);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void FindMedianSortedArraysTest_General_Even()
        {
            int[] nums1 = { 1, 2, 3, 4 };
            int[] nums2 = { 5, 6, 7, 8 };

            var solution = new _004_MedianOfTwoSortedArrays();
            var result = solution.FindMedianSortedArrays(nums1, nums2);

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void FindMedianSortedArraysTest_Num1Empty()
        {
            int[] nums1 = { };
            int[] nums2 = { 1, 2, 3 };

            var solution = new _004_MedianOfTwoSortedArrays();
            var result = solution.FindMedianSortedArrays(nums1, nums2);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void FindMedianSortedArraysTest_Num2Empty()
        {
            int[] nums1 = { 1, 2, 3 };
            int[] nums2 = { };

            var solution = new _004_MedianOfTwoSortedArrays();
            var result = solution.FindMedianSortedArrays(nums1, nums2);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void FindMedianSortedArraysTest_Num1Empty_Nums2SingleItem()
        {
            int[] nums1 = { };
            int[] nums2 = { 1 };

            var solution = new _004_MedianOfTwoSortedArrays();
            var result = solution.FindMedianSortedArrays(nums1, nums2);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void FindMedianSortedArraysTest_Num2Empty_Nums1SingleItem()
        {
            int[] nums1 = { 1 };
            int[] nums2 = { };

            var solution = new _004_MedianOfTwoSortedArrays();
            var result = solution.FindMedianSortedArrays(nums1, nums2);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void FindMedianSortedArraysTest_MixedArray()
        {
            int[] nums1 = { 1, 2, 3, 4 };
            int[] nums2 = { 3, 4, 5, 5, 6 };

            var solution = new _004_MedianOfTwoSortedArrays();
            var result = solution.FindMedianSortedArrays(nums1, nums2);

            Assert.AreEqual(3, result);
        }
    }
}
