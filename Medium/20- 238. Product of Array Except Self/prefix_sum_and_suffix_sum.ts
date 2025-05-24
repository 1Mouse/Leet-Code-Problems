function productExceptSelf(nums: number[]): number[] {
    const len = nums.length - 1
    const result: number[] = []
    const prefix = []
    const suffix = []
    prefix[0] = nums[0] * 1
    suffix[len] = nums[len] * 1

    for (let i = 1; i < nums.length; i++) {
        prefix[i] = prefix[i - 1] * nums[i]
    }

    for (let i = len - 1; i >= 0; i--) {
        suffix[i] = suffix[i + 1] * nums[i]
    }


    result[0]=suffix[1]
    result[len]=prefix[len-1]

    for(let i=1;i<len;i++){
        result[i]=prefix[i-1]*suffix[i+1]
    }

    return result;
};

