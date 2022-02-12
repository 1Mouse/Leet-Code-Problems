public class Solution
{
    // https://www.youtube.com/watch?v=HbbYPQc-Oo4&ab_channel=TECHDOSE
    // time: O(n)
    // space O(n)
    public int SubarraySum(int[] nums, int k)
    {

        int count = 0, sum = 0;
        //key is prefix sum, value is how many times it occured
        var prefixSumMap = new Dictionary<int, int>() { { 0, 1 } };

        foreach (var value in nums)
        {
            sum += value;

            // TRICKY
            if (prefixSumMap.ContainsKey(sum - k))
                count += prefixSumMap[sum - k];
            

            // calculating occurances of Prefix Sum
            if (prefixSumMap.ContainsKey(sum))
                prefixSumMap[sum]++;
            else
                prefixSumMap.Add(sum, 1);


        }
        return count;
    }
}
/* 
If anyone is confused why the count was increased by myMap[ curr - k ] instead of just count+=1 . It was because prefix sum can be same because of some negative values in the array. so out next occuring k will also pair  with those negative values also . 


consider this case A : [3 4  7    2   -3   1   4   2   1 ]  
                       preSum : [3 7 14 16 13 14 18 20 21]


you can see 14 occured twice  because of the subsequence [2 -3 1] their sum is 0. so When you are at the final index with value 1 . you have curr - k = 21 - 7 = 14 . you check for 14 it has occured twice . so you need to consider subsequences [2 -3 1 4 2 1] and [4 2 1] . Hope this helps
*/

/*  some tricky cases
[1] k=0
[-1,-1,-1] k=0
*/