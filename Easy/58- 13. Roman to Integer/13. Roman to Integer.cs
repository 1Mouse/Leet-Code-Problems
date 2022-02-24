public class Solution {
        public int RomanToInt(string s)
        {
            var result = 0;
            var currentValue = 0;
            for (var i = 0; i < s.Length - 1; i++)
            {
                currentValue = RomanNumerals(s[i]);
                result += (RomanNumerals(s[i + 1]) > currentValue ? -1 : 1) * currentValue;
                // we added this condition to handle "IV", "IX" etc...
                // as :
                //I can be placed before V(5) and X(10) to make 4 and 9.
                //X can be placed before L(50) and C(100) to make 40 and 90.
                //C can be placed before D(500) and M(1000) to make 400 and 900.
            }

            return result + RomanNumerals(s[s.Length - 1]);
            //the value will always be summed and it's not included in the loop
        }
        private int RomanNumerals(char c)
        {
            switch (c)
            {
                case 'I': return 1;
                case 'V': return 5;
                case 'X': return 10;
                case 'L': return 50;
                case 'C': return 100;
                case 'D': return 500;
                case 'M': return 1000;
            };
            return 0;
        }
}