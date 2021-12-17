public class Solution
{
    public string DestCity(IList<IList<string>> paths)
    {
        HashSet<string> possibleDestinations = new HashSet<string>();


        for (int i = 0; i < paths.Count; i++)
        {
            possibleDestinations.Add(paths[i][1]);
        }
        for (int i = 0; i < paths.Count; i++)
        {
            if (possibleDestinations.Contains(paths[i][0]))
                possibleDestinations.Remove(paths[i][0]);
        }
        return possibleDestinations.FirstOrDefault<string>();
    }
}