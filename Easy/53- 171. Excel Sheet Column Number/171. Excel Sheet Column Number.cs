public class Solution {
        public int TitleToNumber(string columnTitle)
        {
            int ans = 0;
            for(int i =0 ; i < columnTitle.Length; i++)
            {
                ans *= 26;
                ans += columnTitle[i] - '@';
            }
            return ans;
        }
}