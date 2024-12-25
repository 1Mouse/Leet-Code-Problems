/**
 * Definition for singly-linked list.
 * class ListNode {
 *     val: number
 *     next: ListNode | null
 *     constructor(val?: number, next?: ListNode | null) {
 *         this.val = (val===undefined ? 0 : val)
 *         this.next = (next===undefined ? null : next)
 *     }
 * }
 */

function reverseList(head: ListNode | null): ListNode | null {
    if (!head) return null;

    let current = head
    let prev = null
    let tempNext = new ListNode()
    while (current) {
        tempNext = current.next;
        current.next = prev;
        prev = current
        current = tempNext
    }

    return prev
};
