/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode() : val(0), next(nullptr) {}
 *     ListNode(int x) : val(x), next(nullptr) {}
 *     ListNode(int x, ListNode *next) : val(x), next(next) {}
 * };
 */
class Solution {
public:
    ListNode* middleNode(ListNode* head) {
        
        // When traversing the list with a pointer slow, make another pointer             fast that traverses twice as fast. When fast reaches the end of               the list, slow must be in the middle.
        
        ListNode*slow=head;
        ListNode*fast=head;
        
        while (fast!=NULL&&fast->next!=NULL)
        {
            slow=slow->next;
            fast=fast->next->next;
        }

        return slow;
    }
};