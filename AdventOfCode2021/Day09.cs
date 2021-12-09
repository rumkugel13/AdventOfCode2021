
using System.Drawing;

namespace AdventOfCode2021
{
    public class Day09
    {
        int[][] heights;

        public Day09(string[] lines)
        {
            heights = new int[lines.Length][];
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    heights[i] = new int[lines[i].Length];
                    for (int j = 0; j < lines[i].Length; j++)
                    {
                        heights[i][j] = (int)char.GetNumericValue(lines[i][j]);
                    }
                }
            }
        }

        public int SolvePart1()
        {
            int sum = 0;
            for (var i = 0; i < heights.Length; i++)
            {
                for (int j = 0; j < heights[i].Length; j++)
                {
                    if (IsSmallerThanAdjacent(j, i))
                    {
                        sum += heights[i][j] + 1;
                    }
                }
            }

            return sum;
        }

        public int SolvePart2()
        {
            List<Point> unexplored = new();
            List<int> basins = new();

            for (int i = 0; i < heights.Length; i++)
            {
                for (int j = 0; j < heights[i].Length; j++)
                {
                    if (heights[i][j] != 9)
                        unexplored.Add(new Point(j, i));
                }
            }

            while (unexplored.Count > 0)
            {
                Point next = unexplored[0];
                HashSet<Point> points = new HashSet<Point>(unexplored);

                basins.Add(GetBasinSize(points, next) - 1);
                unexplored = new List<Point>(points);
            }

            int[] b = basins.ToArray();
            Array.Sort(b);

            int product = 1;
            for (int i = b.Length - 1; i > b.Length - 4; i--)
            {
                product *= b[i];
            }

            return product;
        }

        int GetBasinSize(HashSet<Point> potential, Point start)
        {
            int size = 1;

            Point left = new Point(start.X - 1, start.Y);
            if (potential.Contains(left))
            {
                potential.Remove(left);
                size += GetBasinSize(potential, left);
            }

            Point right = new Point(start.X + 1, start.Y);
            if (potential.Contains(right))
            {
                potential.Remove(right);
                size += GetBasinSize(potential, right);
            }

            Point up = new Point(start.X, start.Y - 1);
            if (potential.Contains(up))
            {
                potential.Remove(up);
                size += GetBasinSize(potential, up);
            }

            Point down = new Point(start.X, start.Y + 1);
            if (potential.Contains(down))
            {
                potential.Remove(down);
                size += GetBasinSize(potential, down);
            }

            return size;
        }

        bool IsSmallerThanAdjacent(int x, int y)
        {
            int val = heights[y][x];
            List<int> test = new();

            if (x - 1 >= 0)
            {
                test.Add(heights[y][x - 1]);
            }

            if (x + 1 < heights[y].Length)
            {
                test.Add(heights[y][x + 1]);
            }

            if (y - 1 >= 0)
            {
                test.Add(heights[y - 1][x]);
            }

            if (y + 1 < heights.Length)
            {
                test.Add(heights[y + 1][x]);
            }

            for (int i = 0;i < test.Count;i++)
            {
                if (val >= test[i])
                    return false;
            }

            return true;
        }
    }
}
