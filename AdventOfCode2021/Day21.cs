
namespace AdventOfCode2021
{
    public class Day21
    {
        int[] starts;

        public Day21(string[] lines)
        {
            starts = new int[2];
            starts[0] = Convert.ToInt32(lines[0].Split(' ').Last());
            starts[1] = Convert.ToInt32(lines[1].Split(' ').Last());
        }

        public int SolvePart1()
        {
            int dice = 0;
            int[] scores = new int[2];
            int[] positions = new int[2];
            positions[0] = starts[0];
            positions[1] = starts[1];

            while (scores[0] < 1000 && scores[1] < 1000)
            {
                int sum1 = (dice % 100) + 1 + (dice + 1 % 100) + 1 + (dice + 2 % 100) + 1;
                dice += 3;

                positions[0] = ((positions[0] + sum1) % 10);
                positions[0] = positions[0] == 0 ? 10 : positions[0];

                scores[0] += positions[0];

                if (scores[0] >= 1000)
                    break;

                int sum2 = (dice % 100) + 1 + (dice + 1 % 100) + 1 + (dice + 2 % 100) + 1;
                dice += 3;

                positions[1] = ((positions[1] + sum2) % 10);
                positions[1] = positions[1] == 0 ? 10 : positions[1];

                scores[1] += positions[1];

                if (scores[1] >= 1000)
                    break;
            }

            return dice * Math.Min(scores[0], scores[1]);
        }

        public int SolvePart2()
        {
            return 0;
        }
    }
}
