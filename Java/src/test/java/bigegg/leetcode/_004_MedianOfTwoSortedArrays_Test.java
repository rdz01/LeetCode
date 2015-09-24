package bigegg.leetcode;

import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class _004_MedianOfTwoSortedArrays_Test {

    @Test
    public void testFindMedianSortedArrays_General_Odd() {
        int[] nums1 = {1, 2};
        int[] nums2 = {3, 4, 5};

        _004_MedianOfTwoSortedArrays solution = new _004_MedianOfTwoSortedArrays();
        double result = solution.findMedianSortedArrays(nums1, nums2);

        assertEquals(3, result, 0.01);
    }

    @Test
    public void testFindMedianSortedArrays_General_Even() {
        int[] nums1 = {1, 2, 3, 4};
        int[] nums2 = {5, 6, 7, 8};

        _004_MedianOfTwoSortedArrays solution = new _004_MedianOfTwoSortedArrays();
        double result = solution.findMedianSortedArrays(nums1, nums2);

        assertEquals(4.5, result, 0.01);
    }

    @Test
    public void testFindMedianSortedArrays_Num1Empty() {
        int[] nums1 = {};
        int[] nums2 = {1, 2, 3};

        _004_MedianOfTwoSortedArrays solution = new _004_MedianOfTwoSortedArrays();
        double result = solution.findMedianSortedArrays(nums1, nums2);

        assertEquals(2, result, 0.01);
    }

    @Test
    public void testFindMedianSortedArrays_Num2Empty() {
        int[] nums1 = {1, 2, 3};
        int[] nums2 = {};

        _004_MedianOfTwoSortedArrays solution = new _004_MedianOfTwoSortedArrays();
        double result = solution.findMedianSortedArrays(nums1, nums2);

        assertEquals(2, result, 0.01);
    }

    @Test
    public void testFindMedianSortedArrays_Num1Empty_Nums2SingleItem() {
        int[] nums1 = {};
        int[] nums2 = {1};

        _004_MedianOfTwoSortedArrays solution = new _004_MedianOfTwoSortedArrays();
        double result = solution.findMedianSortedArrays(nums1, nums2);

        assertEquals(1, result, 0.01);
    }

    @Test
    public void testFindMedianSortedArrays_Num2Empty_Nums1SingleItem() {
        int[] nums1 = {1};
        int[] nums2 = {};

        _004_MedianOfTwoSortedArrays solution = new _004_MedianOfTwoSortedArrays();
        double result = solution.findMedianSortedArrays(nums1, nums2);

        assertEquals(1, result, 0.01);
    }

    @Test
    public void testFindMedianSortedArrays_Num1SingleItem_Odd() {
        int[] nums1 = {1};
        int[] nums2 = {2, 3, 4, 5, 6, 7};

        _004_MedianOfTwoSortedArrays solution = new _004_MedianOfTwoSortedArrays();
        double result = solution.findMedianSortedArrays(nums1, nums2);

        assertEquals(4, result, 0.01);
    }

    @Test
    public void testFindMedianSortedArrays_Num1SingleItem_Even() {
        int[] nums1 = {1};
        int[] nums2 = {2, 3, 4, 5, 6};

        _004_MedianOfTwoSortedArrays solution = new _004_MedianOfTwoSortedArrays();
        double result = solution.findMedianSortedArrays(nums1, nums2);

        assertEquals(3.5, result, 0.01);
    }

    @Test
    public void testFindMedianSortedArrays_Num2SingleItem_Odd() {
        int[] nums1 = {2, 3, 4, 5, 6, 7};
        int[] nums2 = {1};

        _004_MedianOfTwoSortedArrays solution = new _004_MedianOfTwoSortedArrays();
        double result = solution.findMedianSortedArrays(nums1, nums2);

        assertEquals(4, result, 0.01);
    }

    @Test
    public void testFindMedianSortedArrays_Num2SingleItem_Even() {
        int[] nums1 = {2, 3, 4, 5, 6};
        int[] nums2 = {1};

        _004_MedianOfTwoSortedArrays solution = new _004_MedianOfTwoSortedArrays();
        double result = solution.findMedianSortedArrays(nums1, nums2);

        assertEquals(3.5, result, 0.01);
    }

    @Test
    public void testFindMedianSortedArrays_MixedArray() {
        int[] nums1 = {2};
        int[] nums2 = {1, 3, 4};

        _004_MedianOfTwoSortedArrays solution = new _004_MedianOfTwoSortedArrays();
        double result = solution.findMedianSortedArrays(nums1, nums2);

        assertEquals(2.5, result, 0.01);
    }

    @Test
    public void testFindMedianSortedArrays_DuplicateItems() {
        int[] nums1 = {1, 1, 3, 3};
        int[] nums2 = {1, 1, 3, 3};

        _004_MedianOfTwoSortedArrays solution = new _004_MedianOfTwoSortedArrays();
        double result = solution.findMedianSortedArrays(nums1, nums2);

        assertEquals(2, result, 0.01);
    }
}
