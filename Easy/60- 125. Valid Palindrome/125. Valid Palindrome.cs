public class Solution
{
    public bool IsPalindrome(string s)
    {
        var clearedString = new StringBuilder();
        foreach (var c in s)
        {
            if ((c > 96 && c < 123) || (c > 47 && c < 58))// append lower case letters and numbers
                clearedString.Append(c);
            else if (c > 64 && c < 91) //append upper case letters
                clearedString.Append((char)(c + ' '));
        }

        int pointer1 = 0, pointer2 = clearedString.Length - 1;

        while (pointer1 < pointer2)
        {
            if (clearedString[pointer1] == clearedString[pointer2])
            {
                pointer1++; pointer2--;
            }
            else
            {
                return false;
            }
        }

        return true;

    }
}