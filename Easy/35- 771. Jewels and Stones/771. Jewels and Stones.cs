public class Solution
{
    public int NumJewelsInStones(string jewels, string stones)
    {
        if (string.IsNullOrEmpty(stones)) //nice method
            return 0;

        HashSet<char> jewelsSet = new HashSet<char>(jewels); //faster than looping on the string

        short countStonesThatAreJewels = 0;

        for (short i = 0; i < stones.Length; i++)
            if (jewelsSet.Contains(stones[i]))
                countStonesThatAreJewels++;

        return countStonesThatAreJewels;
    }
}