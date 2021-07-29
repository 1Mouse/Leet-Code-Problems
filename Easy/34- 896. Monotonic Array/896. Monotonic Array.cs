public class Solution {
    public bool IsMonotonic(int[] nums) {
        bool inc=true,dec=true;
        for(int i=1;i<nums?.Length;i++){
            inc=inc&(nums[i]>=nums[i-1]);
            dec=dec&(nums[i]<=nums[i-1]);
        }
        return inc||dec;
    }
}