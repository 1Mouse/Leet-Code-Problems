public class Solution {
    public int FindCenter(int[][] edges) {
                {
            return edges[0][0] == edges[1][0] || edges[0][0] == edges[1][1] ? edges[0][0] : edges[0][1];

            //explanation
            // center node must be present at every edge so we find it in the first and the second node without needing a loop
            // let first edge=(a,b) -&- second edge=(c,d)

            //int a = edges[0][0];
            //int b = edges[0][1];
            //int c = edges[1][0];
            //int d = edges[1][1];

            //if (a == c || a == d) return a;
            //return b;
        }
}
}