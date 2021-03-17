class Solution {
    public int maxScore(String s) {
        int onesCount = 0, zerosCount = 0, maxScore = 0;

        // you cant use for each on a string so we convert it to an array of characters
        // to enable that even though it is not mandatory.. this is just for practicing
        // the language
        for (char c : s.toCharArray()) {
            if (c == '1')
                onesCount++;
        }

        // notice that converting into charArray takes time and memory so not using for
        // each would be more efficient

        // here i can't use for each because i don't want to iterate on the last
        // character
        for (int i = 0; i < s.length() - 1; i++) {
            if (s.charAt(i) == '0')
                zerosCount++;
            else
                onesCount--;

            maxScore = Math.max(maxScore, zerosCount + onesCount);
        }

        return maxScore;
    }
}