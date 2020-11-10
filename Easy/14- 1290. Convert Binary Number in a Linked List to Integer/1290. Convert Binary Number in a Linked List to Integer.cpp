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
class Solution
{
public:
    int getDecimalValue(ListNode *head)
    {
        ListNode *cur = head;
        int sum = 0;
        double i = -1; // i refers to the highest power of the base 2 of the binary number.
        while (cur != nullptr)
        {
            i++;
            cur = cur->next;
        }
        cur = head;
        while (cur != nullptr)
        {
            sum += (cur->val) * pow(2.0, i);
            i--;
            cur = cur->next;
        }
        return sum;
    }
};