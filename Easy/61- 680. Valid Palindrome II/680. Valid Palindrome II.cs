public class Solution
{
    public bool ValidPalindrome(string s)
    {
        int pointer1 = 0, pointer2 = s.Length - 1;
        while (pointer1 < pointer2)
        {
            if (s[pointer1] != s[pointer2])
            {
                return validPalindromeHelper(s.Remove(pointer2, 1)) ? true : validPalindromeHelper(s.Remove(pointer1, 1));
            }
            pointer1++; pointer2--;
        }
        return validPalindromeHelper(s);

    }
    
    private bool validPalindromeHelper(string s)
    {
        int pointer1 = 0;
        int pointer2 = s.Length - 1;

        while (pointer1 < pointer2)
        {
            if (s[pointer1] != s[pointer2])
            {
                return false;
            }
            pointer1++; pointer2--;
        }
        return true;
    }
}