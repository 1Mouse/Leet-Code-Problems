// time: O(n) n=string length
// space: O(26)~O(1) the alphabet
public class Solution {
    public int FirstUniqChar(string s)
    {
        // a frequency map <char,{index of char in the string, freq}>
        var map = new Dictionary<char, List<int>>();

        for (int i = 0; i < s.Length; i++)
            if (!map.ContainsKey(s[i]))
                map.Add(s[i], new List<int>() { i, 1 });
            else
                map[s[i]][1]++;


        //to find the first unique char
        var result = int.MaxValue;

        foreach (var item in map)
            result = (item.Value[1] == 1 && item.Value[0] < result) ? item.Value[0] : result;

        return (result == int.MaxValue) ? -1 : result;
    }
}