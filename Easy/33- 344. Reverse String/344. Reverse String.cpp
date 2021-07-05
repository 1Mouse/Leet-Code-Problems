class Solution
{
public:
    void reverseString(vector<char> &s)
    {
        int l = 0, r = s.size() - 1;
        int temp;
        while (l < r)
        {
            temp = s[l];
            s[l++] = s[r];
            s[r--] = temp;
        }
    }
};