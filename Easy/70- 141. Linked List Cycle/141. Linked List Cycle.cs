/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
//  O(N) time, O(1) space ---->> Floyd's Tortoise and Hare algorithm
public class Solution {
    public bool HasCycle(ListNode head) {
        ListNode slow=head;
        ListNode fast=head;
        
        while(fast!=null&&fast.next!=null){
            slow=slow.next;
            fast=fast.next.next;
            
            if(slow==fast)
                return true;
        }
        
        return false;
    }
}