using System.Collections.Generic;
using System.Numerics;

namespace AdventOfCode2021
{
    public class Day22
    {
        Step[] steps;

        struct Range
        {
            public int Min;
            public int Max;
        }

        struct Step
        {
            public bool On;
            public Range X;
            public Range Y;
            public Range Z;
        }

        public Day22(string[] lines)
        {
            steps = new Step[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                steps[i] = new Step();
                steps[i].On = lines[i].Split(' ')[0] == "on";

                string ranges = lines[i].Split(' ')[1];
                var coords = ranges.Split(',');
                var x = coords[0].Split('=')[1].Split("..");
                var y = coords[1].Split('=')[1].Split("..");
                var z = coords[2].Split('=')[1].Split("..");
                steps[i].X = new Range();
                steps[i].X.Min = Convert.ToInt32(x[0]);
                steps[i].X.Max = Convert.ToInt32(x[1]);
                steps[i].Y = new Range();
                steps[i].Y.Min = Convert.ToInt32(y[0]);
                steps[i].Y.Max = Convert.ToInt32(y[1]);
                steps[i].Z = new Range();
                steps[i].Z.Min = Convert.ToInt32(z[0]);
                steps[i].Z.Max = Convert.ToInt32(z[1]);
            }
        }

        public int SolvePart1()
        {
            HashSet<Vector3> activated = new();

            for (int i = 0; i < steps.Length; i++)
            {
                Step current = steps[i];
                for (int x = Math.Max(current.X.Min, -50); x <= Math.Min(current.X.Max, 50); x++)
                {
                    for (int y = Math.Max(current.Y.Min, -50); y <= Math.Min(current.Y.Max, 50); y++)
                    {
                        for (int z = Math.Max(current.Z.Min, -50); z <= Math.Min(current.Z.Max, 50); z++)
                        {
                            if (current.On)
                            {
                                activated.Add(new Vector3(x, y, z));
                            }
                            else
                            {
                                activated.Remove(new Vector3(x, y, z));
                            }
                        }
                    }
                }
            }

            return activated.Count;
        }

        public int SolvePart2()
        {
            return 0;
        }
    }
}
