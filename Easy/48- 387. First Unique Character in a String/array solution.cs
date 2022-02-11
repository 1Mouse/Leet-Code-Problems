public class Solution
{

    public int FirstUniqChar(string s)
    {
        var arr = new int[26];

        foreach (var c in s)
            arr[c - 'a']++;

        for (var i = 0; i < s.Length; i++)
            if (arr[s[i] - 'a'] == 1)
                return i;

        return -1;
    }
}