public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if(nums.Length==0)
        {
            return 0;
        }
        int flag=nums[0];
        int index=0;
        for(int i=0;i<nums.Length;i++)
        {
            if(nums[i]!=flag)
            {
                nums[index+1]=nums[i];
                flag=nums[i];
                index++;
            }
        }
        return index+1;
    }
}