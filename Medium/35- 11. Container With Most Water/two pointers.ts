function maxArea(height: number[]): number {
    let result = 0

    let current = 0;

    let l = 0;
    let r = height.length - 1

    while (l < r) {
        current = (r - l) * (Math.min(height[l], height[r]))
        result = Math.max(result, current)
        if (height[l] <= height[r])
            l++;
        else {
            r--
        }
    }

    return result
};
