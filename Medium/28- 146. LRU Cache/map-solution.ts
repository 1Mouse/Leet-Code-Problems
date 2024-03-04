// links to resources:
// https://leetcode.com/problems/lru-cache/solutions/1770891/typescript-simple-solution-with-o-1-get-and-put/
// https://www.youtube.com/watch?v=3Z9G5qRmI-I

class LRUCache {
    capacity: number;
    map: Map<number, number>;
    constructor(capacity: number) {
        this.capacity = capacity;
        this.map = new Map<number, number>();
    }

    get(key: number): number {
        const value = this.map.get(key);

        if (value === undefined) return -1;

        // trick to put the key at the end of the map
        this.map.delete(key);
        this.map.set(key, value);

        return value;
    }

    put(key: number, value: number): void {
        // must use the class get method which we implemented and not the get method of the map object itself
        // in order to update the order of the keys
        if (this.get(key) === -1 && this.capacity === this.map.size) {
            // keys is iterable so we can use next() to get the first key 
            // value is the value of the key itself not the value corresponding to the key
            // if we have an entry like this {7,2} then this following line will return 7
            const firstKey = this.map.keys().next().value;
            this.map.delete(firstKey);
        }

        // key will be added at the end of the map
        this.map.set(key, value);
    }
}