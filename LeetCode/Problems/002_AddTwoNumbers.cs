namespace LeetCode
{
    // Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public partial class Program
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var node = new ListNode(0);
            var result = node;

            while (node != null)
            {
                node.val += l1.val + l2.val;
                if (node.val >= 10)
                {
                    node.val -= 10;
                    node.next = new ListNode(1);
                }

                if (node.next == null && (l1.next != null || l2.next != null))
                    node.next = new ListNode(0);

                if (l1.next != null)
                    l1 = l1.next;
                else
                    l1.val = 0;

                if (l2.next != null)
                    l2 = l2.next;
                else
                    l2.val = 0;

                node = node.next;
            }

            return result;
        }
    }
}