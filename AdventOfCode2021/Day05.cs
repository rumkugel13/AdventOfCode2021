using System.Drawing;

namespace AdventOfCode2021
{
    public class Day05
    {
        Line[] lines;

        public struct Line
        {
            public Point Start;
            public Point End;
        }

        public Day05(string[] data)
        {
            lines = new Line[data.Length];

            for (int i = 0; i < data.Length; i++)
            {
                var points = data[i].Split(" -> ");
                lines[i].Start.X = Convert.ToInt32(points[0].Split(',')[0]);
                lines[i].Start.Y = Convert.ToInt32(points[0].Split(',')[1]);
                lines[i].End.X = Convert.ToInt32(points[1].Split(',')[0]);
                lines[i].End.Y = Convert.ToInt32(points[1].Split(',')[1]);
            }
        }

        public int SolvePart1()
        {
            Dictionary<Point, int> points = new Dictionary<Point, int>();
            int sum = 0;

            for (int i = 0; i < lines.Length; i++)
            {
                Point start = lines[i].Start;
                Point end = lines[i].End;

                // only horizontal and vertical for now
                if (start.X == end.X)
                {
                    for (int y = Math.Min(start.Y, end.Y); y <= Math.Max(start.Y, end.Y); y++)
                    {
                        Point p = new Point(start.X, y);
                        if (!points.TryAdd(p, 1))
                        {
                            points[p]++;
                            sum += points[p] == 2 ? 1 : 0;
                        }
                    }
                }
                else if (start.Y == end.Y)
                {
                    for (int x = Math.Min(start.X, end.X); x <= Math.Max(start.X, end.X); x++)
                    {
                        Point p = new Point(x, start.Y);
                        if (!points.TryAdd(p, 1))
                        {
                            points[p]++;
                            sum += points[p] == 2 ? 1 : 0;
                        }
                    }
                }
            }

            return sum;
        }

        public int SolvePart2()
        {
            Dictionary<Point, int> points = new Dictionary<Point, int>();
            int sum = 0;

            for (int i = 0; i < lines.Length; i++)
            {
                Point start = lines[i].Start;
                Point end = lines[i].End;

                Point vector = new Point(end.X - start.X, end.Y - start.Y);
                vector.X = vector.X == 0 ? 0 : (vector.X > 0 ? 1 : -1);
                vector.Y = vector.Y == 0 ? 0 : (vector.Y > 0 ? 1 : -1);

                Point temp = start;
                int loop = Math.Max(Math.Abs(end.X - start.X), Math.Abs(end.Y - start.Y));

                for (int j = 0; j <= loop; j++)
                {
                    if (!points.TryAdd(temp, 1))
                    {
                        points[temp]++;
                        sum += points[temp] == 2 ? 1 : 0;
                    }

                    temp = new Point(temp.X + vector.X, temp.Y + vector.Y);
                }
            }

            return sum;
        }
    }
}
