
namespace AdventOfCode2021
{
    public class Day07
    {
        int[] positions;

        public Day07(string[] lines)
        {
            var data = lines[0].Split(',');
            positions = new int[data.Length];

            for (int i = 0; i < data.Length; i++)
            {
                positions[i] = int.Parse(data[i]);
            }
        }

        public int SolvePart1()
        {
            int[] data = positions;

            Array.Sort(data);

            int target = data[data.Length / 2];
            int sum = 0;
            for (int i = 0;i < data.Length;i++)
            {
                sum += Math.Abs(data[i] - target);
            }

            return sum;
        }

        public int SolvePart2()
        {
            int[] data = positions;
            int target = 0;

            for (int i = 0; i < data.Length; i++)
            {
                target += data[i];
            }

            target /= data.Length;

            int sumTarget = 0;
            for (int i = 0; i < data.Length; i++)
            {
                int n = Math.Abs(data[i] - target);
                sumTarget += (n * (n + 1)) / 2;
            }

            // for rounding errors in target, produce output for +1 and -1
            int sumMin = 0;
            for (int i = 0; i < data.Length; i++)
            {
                int n = Math.Abs(data[i] - target - 1);
                sumMin += (n * (n + 1)) / 2;
            }

            int sumMax = 0;
            for (int i = 0; i < data.Length; i++)
            {
                int n = Math.Abs(data[i] - target + 1);
                sumMax += (n * (n + 1)) / 2;
            }

            return Math.Min(sumTarget, Math.Min(sumMin, sumMax));
        }
    }
}
