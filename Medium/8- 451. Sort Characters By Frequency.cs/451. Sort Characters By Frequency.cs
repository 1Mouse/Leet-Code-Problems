    public class Solution
    {

        public string FrequencySort(string s)
        {
            var freq = new Dictionary<char, int>();
            foreach (var c in s)
            {
                if (freq.ContainsKey(c))
                    freq[c]++;
                else
                    freq.Add(c, 1);
            }

            var keys = freq.ToArray();// array of KeyValuePairs
            Array.Sort(keys, (x, y) => {//the thing I want to be first is the first parameter
                if (x.Value > y.Value)// the condition for it to be first
                    return -1;  // -1
                return 1;  // 1
            });

            var sb = new StringBuilder();
            foreach (var item in keys)
            {
                sb.Append(item.Key,item.Value);//(value,repeat)
            }
            return sb.ToString();
        }
    }