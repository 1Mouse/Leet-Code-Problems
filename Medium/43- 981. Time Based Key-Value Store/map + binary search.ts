type Entry = {
    value: string;
    timestamp: number;
}
class TimeMap {
    private timeMap: Map<string, Array<Entry>>;
    constructor() {
        this.timeMap = new Map<string, Array<Entry>>()
    }

    set(key: string, value: string, timestamp: number): void {
        if (this.timeMap.has(key)) {
            this.timeMap.get(key)!.push({ value, timestamp })
        } else {
            this.timeMap.set(key, [{ value, timestamp }])
        }
    }

    get(key: string, timestamp: number): string {
        let answer = ""
        if (this.timeMap.has(key)) {
            const arr = this.timeMap.get(key)!

            let l = 0, r = arr.length - 1
            let m = 0

            while (l <= r) {
                m = Math.floor(l + (r - l) / 2)

                if (arr[m].timestamp === timestamp)
                    return arr[m].value
                else if (arr[m].timestamp < timestamp) {
                    answer = arr[m].value
                    l = m + 1
                } else {
                    r = m - 1
                }
            }

        }

        return answer
    }
}

/**
 * Your TimeMap object will be instantiated and called as such:
 * var obj = new TimeMap()
 * obj.set(key,value,timestamp)
 * var param_2 = obj.get(key,timestamp)
 */
