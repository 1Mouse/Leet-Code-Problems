    // algo: hashSet of seen items
    // Time Complexity: O(n)
    // Space Complexity: O(n)
    
    public class Solution
    {
        public int RepeatedNTimes(int[] nums)
        {
            var seen = new HashSet<int>(); // same as unordered_set in cpp
            // default is its count is zero and the hashSet is null
            foreach(int num in nums)
            {
                if (seen.Contains(num)) // find in O(1)
                    return num;
                seen.Add(num); //O(1)
            }
            
            return -1;
        }
    }