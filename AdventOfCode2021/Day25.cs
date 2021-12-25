using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AdventOfCode2021
{
    public class Day25
    {
        int width, height;
        Dictionary<Point, char> cucumbers;

        public Day25(string[] lines)
        {
            width = lines[0].Length;
            height = lines.Length;

            cucumbers = new();

            for (int y = 0; y < lines.Length; y++)
            {
                for (int x = 0; x < lines[y].Length; x++)
                {
                    if (lines[y][x] != '.')
                    {
                        cucumbers.Add(new Point(x, y), lines[y][x]);
                    }
                }
            }
        }

        public int SolvePart1()
        {
            int i;
            Dictionary<Point, char> start = new(cucumbers);

            for (i = 1; ; i++)
            {
                Dictionary<Point, char> temp = new(start);
                bool moved = false;

                foreach(Point p in start.Keys)
                {
                    switch (start[p])
                    {
                        case '>':
                            if (!start.ContainsKey(new Point((p.X + 1) % width, p.Y)))
                            {
                                temp.Remove(p);
                                temp.Add(new Point((p.X + 1) % width, p.Y), '>');
                                moved = true;
                            }
                            break;
                    }
                }

                start = new(temp);

                foreach (Point p in start.Keys)
                {
                    switch (start[p])
                    {
                        case 'v':
                            if (!start.ContainsKey(new Point(p.X, (p.Y + 1) % height)))
                            {
                                temp.Remove(p);
                                temp.Add(new Point(p.X, (p.Y + 1) % height), 'v');
                                moved = true;
                            }
                            break;
                    }
                }

                start = new(temp);

                if (!moved)
                    break;
            }

            return i;
        }

        public int SolvePart2()
        {
            return 0;
        }
    }
}
