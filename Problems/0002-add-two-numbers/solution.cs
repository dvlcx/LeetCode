/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode result = new();

        Iterate(result, l1, l2, 0);

        return result;
    }
    public static void Iterate(ListNode result, ListNode? l1, ListNode? l2, int add)
    {
        var sum = (l1?.val ?? 0) + (l2?.val ?? 0) + add;
        add = sum >= 10 ? 1 : 0;
        result.val = sum - add * 10;
        if (l1?.next is null && l2?.next is null && add == 0)
            return;
        result.next = new();

        Iterate(result.next, l1?.next, l2?.next, add);
    }
}
