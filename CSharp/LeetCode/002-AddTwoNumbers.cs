namespace LeetCode
{
    public class _002_AddTwoNumbers
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var current = new ListNode(0);
            ListNode first = current;
            ListNode previous = null;

            while (l1 != null && l2 != null)
            {
                current = CalculateCurrent(current, l1.val, l2.val);
                previous = current;
                current = current.next;
                l1 = l1.next;
                l2 = l2.next;
            }

            while (l1 != null)
            {
                current = CalculateCurrent(current, l1.val, 0);
                previous = current;
                current = current.next;
                l1 = l1.next;
            }

            while (l2 != null)
            {
                current = CalculateCurrent(current, 0, l2.val);
                previous = current;
                current = current.next;
                l2 = l2.next;
            }

            if (current.val == 0)
            {
                previous.next = null;
            }

            return first;
        }

        private ListNode CalculateCurrent(ListNode current, int value1, int value2)
        {
            var sum = value1 + value2 + current.val;

            if (sum >= 10)
            {
                current.val = sum % 10;
                current.next = new ListNode(1);
            }
            else
            {
                current.val = sum;
                current.next = new ListNode(0);
            }

            return current;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
