using System.Drawing;

namespace AdventOfCode2021
{
    public class Day20
    {
        readonly string algorithm;
        Dictionary<Point, char> input;

        public Day20(string[] lines)
        {
            algorithm = lines[0];

            input = new();

            for (int i = 2; i < lines.Length; i++)
            {
                for (int j = 0; j < lines[i].Length; j++)
                {
                    if (lines[i][j] == '#')
                    {
                        input.Add(new Point(j, i - 2), lines[i][j]);
                    }
                }
            }
        }

        public char Scan(Dictionary<Point, char> input, Point pos, bool flip)
        {
            char c;
            string binary = "";

            for (int y = pos.Y - 1; y <= pos.Y + 1; y++)
            {
                for (int x = pos.X - 1; x <= pos.X + 1; x++)
                {
                    Point point = new Point(x, y);
                    if (input.ContainsKey(point))
                    {
                        binary += input[point];
                    }
                    else
                    {
                        binary += flip ? '#' : '.';
                    }
                }
            }

            int num = Convert.ToInt32(binary.Replace('#', '1').Replace('.', '0'), 2);

            c = algorithm[num];

            return c;
        }

        public int SolvePart1()
        {
            Dictionary<Point, char> data = new(input);

            for (int i = 0; i < 2; i++)
            {
                Dictionary<Point, char> temp = new();

                Point min = new Point(data.Select(x => x.Key.X).Min(), data.Select(x => x.Key.Y).Min());
                Point max = new Point(data.Select(x => x.Key.X).Max(), data.Select(x => x.Key.Y).Max());

                for (int y =  min.Y - 2; y <= max.Y + 2; y++)
                {
                    for (int x = min.X - 2; x <= max.X + 2; x++)
                    {
                        Point p = new Point(x, y);
                        //if (Scan(data, p, i%2 != 0) == '#')
                        {
                            temp.Add(p, Scan(data, p, i % 2 != 0 && algorithm[0] == '#'));
                        }
                    }
                }

                data = new(temp);
            }

            return data.Count(x => x.Value == '#');
        }

        public int SolvePart2()
        {
            Dictionary<Point, char> data = new(input);

            for (int i = 0; i < 50; i++)
            {
                Dictionary<Point, char> temp = new();

                Point min = new Point(data.Select(x => x.Key.X).Min(), data.Select(x => x.Key.Y).Min());
                Point max = new Point(data.Select(x => x.Key.X).Max(), data.Select(x => x.Key.Y).Max());

                for (int y = min.Y - 1; y <= max.Y + 1; y++)
                {
                    for (int x = min.X - 1; x <= max.X + 1; x++)
                    {
                        Point p = new Point(x, y);
                        //if (Scan(data, p, i%2 != 0) == '#')
                        {
                            temp.Add(p, Scan(data, p, i % 2 != 0 && algorithm[0] == '#'));
                        }
                    }
                }

                data = new(temp);
            }

            return data.Count(x => x.Value == '#');
        }
    }
}
