//O(N) time, O(1) space
function twoSum(numbers: number[], target: number): number[] {

    let start = 0;
    let end = numbers.length - 1

    // two pointers at the start and end 
    while (start !== end) {
        if (numbers[start] + numbers[end] === target)
            break;
        else if (numbers[start] + numbers[end] < target) {
            start++;
        } else {
            end--;
        }
    }

    // added one as leetcode wants it 1 indexed
    return [start + 1, end + 1]
};
