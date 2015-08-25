package bigegg.leetcode;

public final class _002_AddTwoNumbers {
    int getValue(ListNode node) {
        if (node == null) {
            return 0;
        }
        return node.val;
    }

    ListNode getNextNode(ListNode node) {
        if (node == null) {
            return null;
        }
        return node.next;
    }

    public ListNode addTwoNumbers(ListNode l1, ListNode l2) {
        ListNode first = new ListNode(-1);
        first.next = new ListNode(0);
        ListNode current = first;

        while (l1 != null || l2 != null) {
            int value1 = getValue(l1);
            int value2 = getValue(l2);

            current = current.next;
            int sum = current.val + value1 + value2;
            if (sum >= 10) {
                current.val = sum % 10;
                current.next = new ListNode(1);
            } else {
                current.val = sum;
                current.next = new ListNode(0);
            }

            l1 = getNextNode(l1);
            l2 = getNextNode(l2);
        }

        if (current.next.val == 0) {
            current.next = null;
        }

        return first.next;
    }

    public class ListNode {
        int val;
        ListNode next;

        ListNode(int x) {
            val = x;
        }
    }
}
