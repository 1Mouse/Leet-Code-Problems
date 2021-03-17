class Solution {
    public int countMatches(List<List<String>> items, String ruleKey, String ruleValue) {
        int comp = 0;
        int count = 0;
        switch (ruleKey) {
        case "type":
            comp = 0;
            break;
        case "color":
            comp = 1;
            break;
        case "name":
            comp = 2;
            break;
        }

        for (List item : items) {
            if (item.get(comp).equals(ruleValue)) {
                count++;
            }

        }

        return count;
    }
}