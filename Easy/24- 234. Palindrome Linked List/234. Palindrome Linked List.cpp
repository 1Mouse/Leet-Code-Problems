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

///Easy solution by converting into vectors but it's slow and uses memory
class Solution
{
public:
    bool isPalindrome(ListNode *head)
    {
        vector<int> v;
        while (head)
        {
            v.push_back(head->val);
            head = head->next;
        }

        int start = 0, end = v.size() - 1;

        while (start < end)
        {
            if (v[start++] != v[end--])
                return false;
        }

        return true;
    }
};