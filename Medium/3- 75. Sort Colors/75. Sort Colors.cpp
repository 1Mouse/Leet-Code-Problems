// smart solution well written and explained
// https://leetcode.com/problems/sort-colors/discuss/1256365/C%2B%2B-oror-Easy-to-understand-oror-full-explanation

class Solution {
public:
    void sortColors(vector<int>& nums) {
        int zeros=0,ones=0,twos=0;
        for(int i=0;i<nums.size();i++){
                if(nums[i]==0)
                    zeros++;
                else if(nums[i]==1)
                    ones++;
                else
                    twos++;
            }
        
        // I tried to use vector methods but it didn't work out
        
        /*int n=zeros+ones+twos;
        nums.clear();
        nums.resize(n);
        fill(nums.begin(), nums.begin()+zeros, 0);
        fill(nums.begin()+zeros, nums.begin()+zeros+ones, 1);
        fill(nums.begin()+zeros+ones, nums.end(), 2);*/
        
        for(int i=0;i<zeros;i++){
            nums[i]=0;
        }
        for(int i=zeros;i<ones+zeros;i++){
            nums[i]=1;
        }
        for(int i=ones+zeros;i<nums.size();i++){
            nums[i]=2;
        }
    }
};