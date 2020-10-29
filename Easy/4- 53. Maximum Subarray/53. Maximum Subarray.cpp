// Tutorial: https://backtobackswe.com/platform/content/max-contiguous-subarray-sum/solutions

// Important link: https://www.geeksforgeeks.org/climits-limits-h-cc/
class Solution {
public:
    int maxSubArray(vector<int>& nums) {
        int maxSoFar=nums[0];
        int maxEndingHere=nums[0];
        
        for(int i=1;i<nums.size();i++)
        {
            maxEndingHere=max(maxEndingHere+nums[i],nums[i]);
            maxSoFar=max(maxSoFar,maxEndingHere);
        }
        
        return maxSoFar;
    }
};