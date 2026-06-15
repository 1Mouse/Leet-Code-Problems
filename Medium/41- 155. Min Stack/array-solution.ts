class MinStack {
    private arr: Array<{ val: number, min: number }>
    constructor() {
        this.arr = []
    }
    
    push(value: number): void {
        this.arr.push({
            val :value,
            // this works because every inserted number knows it's the min or not
            // and if we poped the smallest number, the last one before it would 
            // still have the second smallest min
            min: this.isEmpty()? value: Math.min(value, this.getMin())
        })
    }

    pop(): void {
        this.arr.pop()
    }

    top(): number {
        return this.arr[this.arr.length - 1].val
    }

    getMin(): number {
        return this.arr[this.arr.length - 1].min
    }

    isEmpty(): boolean {
        return this.arr.length === 0
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * var obj = new MinStack()
 * obj.push(value)
 * obj.pop()
 * var param_3 = obj.top()
 * var param_4 = obj.getMin()
 */
