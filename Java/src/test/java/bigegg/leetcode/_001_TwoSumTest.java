package bigegg.leetcode;

import org.junit.Test;

import static org.junit.Assert.*;

public class _001_TwoSumTest {
    private final int[] largeArray;

    public _001_TwoSumTest() {
        largeArray = new int[20000];
        for (int i = 0; i < 20000; i++) {
            largeArray[i] = i * 2;
        }
    }

    @Test
    public void testTwoSum_Ordered() throws Exception {
        int[] nums = {2, 7, 11, 15};
        int target = 9;

        _001_TwoSum solution = new _001_TwoSum();
        int[] result = solution.twoSum(nums, target);

        assertEquals(1, result[0]);
        assertEquals(2, result[1]);
    }

    @Test
    public void testTwoSum_Unordered() throws Exception {
        int[] nums = {5, 75, 25};
        int target = 100;

        _001_TwoSum solution = new _001_TwoSum();
        int[] result = solution.twoSum(nums, target);

        assertEquals(2, result[0]);
        assertEquals(3, result[1]);
    }

    @Test
    public void testTwoSum_Duplicate() throws Exception {
        int[] nums = {5, 5, 15, 30};
        int target = 20;

        _001_TwoSum solution = new _001_TwoSum();
        int[] result = solution.twoSum(nums, target);

        assertEquals(2, result[0]);
        assertEquals(3, result[1]);
    }

    @Test
    public void testTwoSum_AllSame() throws Exception {
        int[] nums = {5, 5, 5, 5};
        int target = 10;

        _001_TwoSum solution = new _001_TwoSum();
        int[] result = solution.twoSum(nums, target);

        assertEquals(1, result[0]);
        assertEquals(2, result[1]);
    }

    @Test
    public void testTwoSum_NoTarget() throws Exception {
        int[] nums = {2, 7, 11, 15};
        int target = 5;

        _001_TwoSum solution = new _001_TwoSum();
        int[] result = solution.twoSum(nums, target);

        assertEquals(0, result[0]);
        assertEquals(0, result[1]);
    }

    @Test
    public void testTwoSum_LargeArray() throws Exception {
        int target = 19082;

        _001_TwoSum solution = new _001_TwoSum();
        int[] result = solution.twoSum(largeArray, target);

        assertEquals(4771, result[0]);
        assertEquals(4772, result[1]);
    }

    @Test
    public void testTwoSum_LargeArray_NoTarget() throws Exception {
        int target = 19081;

        _001_TwoSum solution = new _001_TwoSum();
        int[] result = solution.twoSum(largeArray, target);

        assertEquals(0, result[0]);
        assertEquals(0, result[1]);
    }
}