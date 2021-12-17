public class Solution {
    public string DestCity(IList<IList<string>> paths)         {
            HashSet<string> possibleDestinations = new HashSet<string>();
            HashSet<string> nonPossibleDestinations = new HashSet<string>();


            for (int i = 0; i < paths.Count; i++)
            {
                possibleDestinations.Add(paths[i][1]);
                nonPossibleDestinations.Add(paths[i][0]);
            }

            foreach(var possibleDestination in possibleDestinations)
            {
                if (!nonPossibleDestinations.Contains(possibleDestination))
                    return possibleDestination;
            }
        return "fuck";
        }
}