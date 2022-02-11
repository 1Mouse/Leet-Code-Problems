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

            for (int i = 0; i < map.Count; i++)
                result = (map[s[i]][1] == 1 && map[s[i]][0] < result) ? map[s[i]][0] : result;

            return (result == int.MaxValue) ? -1 : result;
        }
}