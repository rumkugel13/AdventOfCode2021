using System.Drawing;

namespace AdventOfCode2021
{
    public class Day15
    {
        string[] map;

        public Day15(string[] map)
        {
            this.map = map;
        }

        public int SolvePart1()
        {
            Point start = new Point(0, 0);
            Point end = new Point(map[0].Length - 1, map.Length - 1);

            Dictionary<Point, int> visited = new Dictionary<Point, int>() { { start, 0 } };
            Utils.BucketHeap<Point> queue = new Utils.BucketHeap<Point>();
            queue.buckets = new Dictionary<int, List<Point>>();
            queue.Insert(start, 0);

            int result = 0;
            while (queue.HasBuckets())
            {
                Point current = queue.PopMin();
                int currentVal = visited[current];

                if (current == end)
                {
                    result = visited[end];
                    break;
                }

                foreach (Point dir in new Point[4] { new Point(1, 0), new Point(-1, 0), new Point(0, 1), new Point(0, -1) })
                {
                    Point nextPoint = new Point(current.X + dir.X, current.Y + dir.Y);
                    if (nextPoint.X < 0 || nextPoint.Y < 0 || nextPoint.X >= map[0].Length || nextPoint.Y >= map.Length)
                        continue;
                    int nextVal = currentVal + (map[nextPoint.Y][nextPoint.X] - '0');

                    if (!visited.TryGetValue(nextPoint, out int val) || val > nextVal)
                    {
                        visited[nextPoint] = nextVal;
                        queue.Insert(nextPoint, nextVal);
                    }
                }
            }

            return result;
        }

        public int SolvePart2()
        {
            Point start = new Point(0, 0);
            Point end = new Point(map[0].Length * 5 - 1, map.Length * 5 - 1);

            Dictionary<Point, int> visited = new Dictionary<Point, int>() { { start, 0 } };
            Utils.BucketHeap<Point> queue = new Utils.BucketHeap<Point>();
            queue.buckets = new Dictionary<int, List<Point>>();
            queue.Insert(start, 0);

            int result = 0;
            while (queue.HasBuckets())
            {
                Point current = queue.PopMin();
                int currentVal = visited[current];

                if (current == end)
                {
                    result = visited[end];
                    break;
                }

                foreach (Point dir in new Point[4] { new Point(1, 0), new Point(-1, 0), new Point(0, 1), new Point(0, -1) })
                {
                    Point nextPoint = new Point(current.X + dir.X, current.Y + dir.Y);
                    if (nextPoint.X < 0 || nextPoint.Y < 0 || nextPoint.X >= map[0].Length * 5 || nextPoint.Y >= map.Length * 5)
                        continue;

                    int modifier = nextPoint.X / map[0].Length + nextPoint.Y / map.Length;
                    int adjusted = (map[nextPoint.Y % map.Length][nextPoint.X % map[0].Length] - '0') + modifier;
                    if (adjusted > 9)
                        adjusted -= 9;
                    int nextVal = currentVal + adjusted;

                    if (!visited.TryGetValue(nextPoint, out int val) || val > nextVal)
                    {
                        visited[nextPoint] = nextVal;
                        queue.Insert(nextPoint, nextVal);
                    }
                }
            }

            return result;
        }
    }
}