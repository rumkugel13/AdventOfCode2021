
namespace AdventOfCode2021
{
    public class Day06
    {
        List<int> initial;

        public Day06(string[] lines)
        {
            initial = new List<int>();
            foreach (string part in lines[0].Split(','))
            {
                initial.Add(int.Parse(part));
            }
        }

        public int SolvePart1()
        {
            List<int> result = new List<int>(initial);

            int days = 80;

            for (int i = 0; i < days; i++)
            {
                List<int> temp = new List<int>(result);

                // note: new ones don't get updated in this round
                for (int j = 0; j < result.Count; j++)
                {
                    if (temp[j] == 0)
                    {
                        temp[j] = 6;
                        temp.Add(8);
                    }
                    else
                    {
                        temp[j]--;
                    }
                }

                result = new List<int>(temp);
            }

            return result.Count;
        }

        public long SolvePart2()
        {
            long[] values = new long[9];

            for (int i = 0; i < initial.Count;i++)
            {
                values[initial[i]]++;
            }

            int days = 256;

            for (int i = 0; i < days; i++)
            {
                long[] tempval = new long[9];

                for (int j = 0; j < values.Length; j++)
                {
                    if (j == 0)
                    {
                        tempval[6] = values[j];
                        tempval[8] = values[j];
                    }
                    else
                    {
                        tempval[j - 1] += values[j];
                    }
                }
                values = tempval;
            }

            long sum = 0;
            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }

            return sum;
        }
    }
}
