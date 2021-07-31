public class Solution
{
    public int[] SmallerNumbersThanCurrent(int[] nums)
    {

        Dictionary<int, int> map = new Dictionary<int, int>();
        int[] result = new int[nums.Length];
        Array.Copy(nums, result, nums.Length);

        Array.Sort(result);

        // using a for with map to get the count of the numbers smaller than the current number 
        // key: the number ||| value: the count of numbers smaller than the number
        // this technique is possible only because we sorted the result array
        for (int i = 0; i < nums.Length; i++)
        {
            map.TryAdd(result[i], i);  //try to add == add if the key is unique
        }

        // use this while debugging 
        /*foreach (var n in map)
        {
            Console.WriteLine(n.ToString());
        }*/

        // here we bind the answer to the result array by mapping it to the number before sorting by "the main nums array"
        for (int i = 0; i < nums.Length; i++)
        {
            result[i] = map[nums[i]]; // result[0]= map[nums[0]==8] == 4 //ignore this comment if you don't understand it
        }

        return result;
    }
}