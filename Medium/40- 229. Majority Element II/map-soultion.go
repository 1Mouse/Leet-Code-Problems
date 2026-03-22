func majorityElement(nums []int) []int {
    freq := make(map[int]int)
    result := []int{}
    n := len(nums)

    for _, num := range nums {
        freq[num]++
    }

    for num, count := range freq {
        if count > n/3 {
            result = append(result, num)
        }
    }

    return result
}
