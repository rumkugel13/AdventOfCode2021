using System.Drawing;

namespace AdventOfCode2021
{
    public class Day13
    {
        List<Point> points;
        List<Point> folds;

        public Day13(string[] lines)
        {
            points = new List<Point>();
            int i;
            for (i = 0; i < lines.Length; i++)
            {
                if (!string.IsNullOrEmpty(lines[i]))
                {
                    var split = lines[i].Split(',');
                    points.Add(new Point(Convert.ToInt32(split[0]), Convert.ToInt32(split[1])));
                }
                else
                {
                    i++;
                    break;
                }
            }

            folds = new List<Point>();
            for (;i< lines.Length; i++)
            {
                var s = lines[i].Split(' ');
                var p = s[2].Split('=');
                folds.Add(new Point(p[0] == "x" ? Convert.ToInt32(p[1]) : 0, p[0] == "y" ? Convert.ToInt32(p[1]) : 0));
            }

        }

        public int SolvePart1()
        {
            var list = Fold(points, folds[0]);

            return list.Count;
        }

        List<Point> Fold(List<Point> points, Point fold)
        {
            List<Point> data = new List<Point>(points);

            for (int i = 0; i < data.Count;i++)
            {
                if (data[i].X > fold.X && fold.X != 0)
                {
                    data[i] = new Point(data[i].X - 2 * (data[i].X - fold.X), data[i].Y);
                }
                else if (data[i].Y > fold.Y && fold.Y != 0)
                {
                    data[i] = new Point(data[i].X, data[i].Y - 2 * (data[i].Y - fold.Y));
                }
            }

            data = data.ToHashSet<Point>().ToList<Point>();

            return data;
        }

        public int SolvePart2()
        {
            List<Point> data = new List<Point>(points);
            for (int i = 0; i < folds.Count;i++)
            {
                data = Fold(data, folds[i]);
            }

            Console.WriteLine("Day 13 part 2 done, check letters:");
            PrintLetters(data);

            return -1;
        }

        public void PrintLetters(List<Point> points)
        {
            int maxY = points.MaxBy(p => p.Y).Y;
            int maxX = points.MaxBy(p => p.X).X;
            for (int y = 0; y <= maxY; y++)
            {
                System.Text.StringBuilder builder = new();

                for (int x = 0; x <= maxX; x++)
                {
                    if (points.Contains(new Point(x, y)))
                    {
                        builder.Append('#');
                    }
                    else
                    {
                        builder.Append(' ');
                    }
                }

                Console.WriteLine(builder.ToString());
            }
        }
    }
}
