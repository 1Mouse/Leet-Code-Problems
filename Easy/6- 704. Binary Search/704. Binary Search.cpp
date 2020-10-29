class Solution {
public:
    int search(vector<int>& nums, int target)
    {
       return BinarySearch(nums,target,0,nums.size()-1);
    }
    
    int BinarySearch(vector<int>& nums,int target,int l,int r)
    {
        if(l<=r)
        {
            int mid=l+(r-l)/2;
            if(nums[mid]==target)
                return mid;
            if(nums[mid]>target)
                return BinarySearch(nums,target,l,mid-1);
            else
                return BinarySearch(nums,target,mid+1,r);
        }
        
        return -1;
    }
};