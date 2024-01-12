namespace AdventOfCode2021
{
    public class Day12
    {
        Dictionary<string, List<string>> paths = new Dictionary<string, List<string>>();

        public Day12(string[] lines)
        {
            for (int i = 0; i < lines.Length; i++)
            {
                var split = lines[i].Split("-");
                if (!paths.ContainsKey(split[0]))
                {
                    paths[split[0]] = new List<string>();
                }
                paths[split[0]].Add(split[1]);
                if (!paths.ContainsKey(split[1]))
                {
                    paths[split[1]] = new List<string>();
                }
                paths[split[1]].Add(split[0]);
            }
        }

        public int SolvePart1()
        {
            return CountPaths(new HashSet<string>() { "start" }, "start", "end");
        }

        int CountPaths(HashSet<string> seen, string next, string end)
        {
            if (next == end)
            {
                return 1;
            }

            int result = 0;
            foreach (var to in paths[next])
            {
                if (!seen.Contains(to))
                {
                    if (!char.IsUpper(to[0]))
                        seen.Add(to);
                    result += CountPaths(seen, to, end);
                    if (!char.IsUpper(to[0]))
                        seen.Remove(to);
                }
            }
            return result;
        }

        public int SolvePart2()
        {
            return CountPaths2(new HashSet<string>() { "start" }, "", "start", "start", "end");
        }

        int CountPaths2(HashSet<string> seen, string seenTwice, string next, string start, string end)
        {
            if (next == end)
            {
                return 1;
            }

            int result = 0;
            foreach (var to in paths[next])
            {
                if (to == start)
                    continue;
                if (!seen.Contains(to) || seenTwice == "")
                {
                    if (!char.IsUpper(to[0]))
                    {
                        if (!seen.Contains(to))
                        {
                            seen.Add(to);
                        }
                        else if ( seenTwice == "")
                        {
                            seenTwice = to;
                        }
                    }
                    result += CountPaths2(seen, seenTwice, to, start, end);
                    if (!char.IsUpper(to[0]))
                    {
                        if (seenTwice == to)
                        {
                            seenTwice = "";
                        }
                        else
                        {
                            seen.Remove(to);
                        }
                    }
                }
            }
            return result;
        }
    }
}