
namespace AdventOfCode2021
{
    public class Day01
    {
        public static int SolvePart1(int[] numbers)
        {
            int increased = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] < numbers[i + 1])
                {
                    increased++;
                }
            }

            return increased;
        }

        public static int SolvePart2(int[] numbers)
        {
            int increased = 0;

            for (int i = 0; i < numbers.Length - 3; i++)
            {
                int sum1 = numbers[i] + numbers[i + 1] + numbers[i + 2];
                int sum2 = numbers[i + 1] + numbers[i + 2] + numbers[i + 3];

                if (sum1 < sum2)
                {
                    increased++;
                }
            }

            return increased;
        }
    }
}
