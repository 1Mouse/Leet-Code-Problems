
class Solution {
    public int nearestValidPoint(int x, int y, int[][] points) {
        int distance = Integer.MAX_VALUE;
        int temp = 0, index = 0;
        for (int i = 0; i < points.length; i++) {
            if (points[i][0] == x && points[i][1] == y)
                return i;
            else if (points[i][0] == x) {
                temp = Math.abs(points[i][1] - y);
                if (temp < distance) {
                    distance = temp;
                    index = i;
                }
            } else if (points[i][1] == y) {
                temp = Math.abs(points[i][0] - x);
                if (temp < distance) {
                    distance = temp;
                    index = i;
                }
            }

        }

        if (distance == Integer.MAX_VALUE)
            return -1;

        return index;
    }
}
