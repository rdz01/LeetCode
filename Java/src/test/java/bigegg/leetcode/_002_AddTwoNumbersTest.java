package bigegg.leetcode;

import org.junit.Test;

import static org.junit.Assert.*;

public class _002_AddTwoNumbersTest {
    @Test
    public void AddTwoNumbersTest_General() throws Exception {
        _002_AddTwoNumbers.ListNode link = GenerateList(new int[]{2, 4, 3});

        _002_AddTwoNumbers solution = new _002_AddTwoNumbers();
        _002_AddTwoNumbers.ListNode result = solution.addTwoNumbers(link, link);

        AssertList(result, new int[]{4, 8, 6});
    }

    @Test
    public void AddTwoNumbersTest_General_2() throws Exception {
        _002_AddTwoNumbers.ListNode link = GenerateList(new int[]{0});

        _002_AddTwoNumbers solution = new _002_AddTwoNumbers();
        _002_AddTwoNumbers.ListNode result = solution.addTwoNumbers(link, link);

        AssertList(result, new int[]{0});
    }

    @Test
    public void AddTwoNumbersTest_HasCarry() throws Exception {
        _002_AddTwoNumbers.ListNode link1 = GenerateList(new int[]{2, 4, 3});
        _002_AddTwoNumbers.ListNode link2 = GenerateList(new int[]{5, 6, 4});

        _002_AddTwoNumbers solution = new _002_AddTwoNumbers();
        _002_AddTwoNumbers.ListNode result = solution.addTwoNumbers(link1, link2);

        AssertList(result, new int[]{7, 0, 8});
    }

    @Test
    public void AddTwoNumbersTest_HasMultipleCarry() throws Exception {
        _002_AddTwoNumbers.ListNode link1 = GenerateList(new int[]{1});
        _002_AddTwoNumbers.ListNode link2 = GenerateList(new int[]{9, 9});

        _002_AddTwoNumbers solution = new _002_AddTwoNumbers();
        _002_AddTwoNumbers.ListNode result = solution.addTwoNumbers(link1, link2);

        AssertList(result, new int[]{0, 0, 1});
    }

    @Test
    public void AddTwoNumbersTest_FirstNumCarry() throws Exception {
        _002_AddTwoNumbers.ListNode link1 = GenerateList(new int[]{3, 4, 4});
        _002_AddTwoNumbers.ListNode link2 = GenerateList(new int[]{3, 4, 6});

        _002_AddTwoNumbers solution = new _002_AddTwoNumbers();
        _002_AddTwoNumbers.ListNode result = solution.addTwoNumbers(link1, link2);

        AssertList(result, new int[]{6, 8, 0, 1});
    }

    @Test
    public void AddTwoNumbersTest_L1Longger() throws Exception {
        _002_AddTwoNumbers.ListNode link1 = GenerateList(new int[]{2, 4, 3, 1});
        _002_AddTwoNumbers.ListNode link2 = GenerateList(new int[]{5, 6, 4});

        _002_AddTwoNumbers solution = new _002_AddTwoNumbers();
        _002_AddTwoNumbers.ListNode result = solution.addTwoNumbers(link1, link2);

        AssertList(result, new int[]{7, 0, 8, 1});
    }

    @Test
    public void AddTwoNumbersTest_L1Longger_2() throws Exception {
        _002_AddTwoNumbers.ListNode link1 = GenerateList(new int[]{1, 8});
        _002_AddTwoNumbers.ListNode link2 = GenerateList(new int[]{0});

        _002_AddTwoNumbers solution = new _002_AddTwoNumbers();
        _002_AddTwoNumbers.ListNode result = solution.addTwoNumbers(link1, link2);

        AssertList(result, new int[]{1, 8});
    }

    @Test
    public void AddTwoNumbersTest_L1Empty() throws Exception {
        _002_AddTwoNumbers.ListNode link1 = GenerateList(null);
        _002_AddTwoNumbers.ListNode link2 = GenerateList(new int[]{1, 8});

        _002_AddTwoNumbers solution = new _002_AddTwoNumbers();
        _002_AddTwoNumbers.ListNode result = solution.addTwoNumbers(link1, link2);

        AssertList(result, new int[]{1, 8});
    }

    @Test
    public void AddTwoNumbersTest_L2Longger() throws Exception {
        _002_AddTwoNumbers.ListNode link1 = GenerateList(new int[]{2, 4, 3});
        _002_AddTwoNumbers.ListNode link2 = GenerateList(new int[]{5, 6, 4, 3});

        _002_AddTwoNumbers solution = new _002_AddTwoNumbers();
        _002_AddTwoNumbers.ListNode result = solution.addTwoNumbers(link1, link2);

        AssertList(result, new int[]{7, 0, 8, 3});
    }

    @Test
    public void AddTwoNumbersTest_L2Longger_2() throws Exception {
        _002_AddTwoNumbers.ListNode link1 = GenerateList(new int[]{0});
        _002_AddTwoNumbers.ListNode link2 = GenerateList(new int[]{1, 8});

        _002_AddTwoNumbers solution = new _002_AddTwoNumbers();
        _002_AddTwoNumbers.ListNode result = solution.addTwoNumbers(link1, link2);

        AssertList(result, new int[]{1, 8});
    }

    @Test
    public void AddTwoNumbersTest_L2Empty() throws Exception {
        _002_AddTwoNumbers.ListNode link1 = GenerateList(new int[]{1, 8});
        _002_AddTwoNumbers.ListNode link2 = GenerateList(null);

        _002_AddTwoNumbers solution = new _002_AddTwoNumbers();
        _002_AddTwoNumbers.ListNode result = solution.addTwoNumbers(link1, link2);

        AssertList(result, new int[]{1, 8});
    }

    private _002_AddTwoNumbers.ListNode GenerateList(int[] nums) {
        if (nums == null || nums.length == 0) {
            return null;
        }

        _002_AddTwoNumbers solution = new _002_AddTwoNumbers();

        int i = 0;
        _002_AddTwoNumbers.ListNode first = solution.new ListNode(nums[i]);
        _002_AddTwoNumbers.ListNode current = first;

        while (++i < nums.length) {
            current.next = solution.new ListNode(nums[i]);
            current = current.next;
        }

        return first;
    }

    private void AssertList(_002_AddTwoNumbers.ListNode first, int[] nums) {
        assertNotNull(first);
        assertNotNull(nums);
        assertTrue(nums.length > 0);

        _002_AddTwoNumbers.ListNode current = first;
        for (int num : nums) {
            assertNotNull(current);
            assertEquals(num, current.val);
            current = current.next;
        }

        assertNull(current);
    }
}
