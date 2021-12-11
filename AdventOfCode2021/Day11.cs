
namespace AdventOfCode2021
{
    public class Day11
    {
        readonly int[][] energies1, energies2;

        public Day11(string[] lines)
        {
            energies1 = new int[lines.Length][];
            energies2 = new int[lines.Length][];

            for (int i = 0; i < lines.Length; i++)
            {
                energies1[i] = new int[lines[i].Length];
                energies2[i] = new int[lines[i].Length];
                for (int j = 0; j < lines[i].Length; j++)
                {
                    energies1[i][j] = (int)char.GetNumericValue(lines[i][j]);
                    energies2[i][j] = (int)char.GetNumericValue(lines[i][j]);
                }
            }
        }

        public int SolvePart1()
        {
            int sum = 0;
            int[][] data = (int[][])energies1.Clone();

            for (int i = 0; i < 100; i++)
            {
                sum += Step(data);
            }

            return sum;
        }

        public int Step(int[][] octopuses)
        {
            int flashes = 0;
            for (int i = 0; i < octopuses.Length; i++)
            {
                for (int j = 0; j < octopuses[i].Length;j++)
                {
                    octopuses[i][j]++;
                    if (octopuses[i][j] == 10)
                    {
                        // increase surrounding
                        Increase(octopuses, i, j);
                    }
                }
            }

            for (int i = 0; i < octopuses.Length; i++)
            {
                for (int j = 0; j < octopuses[i].Length; j++)
                {
                    if (octopuses[i][j] > 9)
                    {
                        flashes++;
                        octopuses[i][j] = 0;
                    }
                }
            }

            return flashes;
        }

        void Increase(int[][] data, int i, int j)
        {
            for (int y = i - 1; y <= i + 1; y++)
            {
                for (int x = j - 1; x <= j + 1; x++)
                {
                    if (!(y == i && x == j) && y >= 0 && x >= 0 && y <= 9 && x <= 9)
                    {
                        data[y][x]++;
                        if (data[y][x] == 10)
                        {
                            Increase(data, y, x);
                        }
                    }
                }
            }
        }

        public int SolvePart2()
        {
            int step = 0;
            int flashes;

            // note: doing this does not copy the data but the links/pointers to the secondary arrays
            int[][] data = (int[][])energies2.Clone();

            do
            {
                flashes = Step(data);
                step++;
            }
            while (flashes < 100);

            return step;
        }
    }
}
