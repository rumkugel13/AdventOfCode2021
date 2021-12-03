
namespace AdventOfCode2021
{
    public class Day03
    {
        public static int SolvePart1(char[][] data)
        {
            byte[] gamma = new byte[data[0].Length];
            byte[] epsilon = new byte[data[0].Length];

            for (int i = 0; i < data[0].Length; i++)
            {
                int temp = 0;

                for (int j = 0; j < data.Length; j++)
                {
                    temp += (int)char.GetNumericValue(data[j][i]);
                }

                if (temp >= data.Length / 2)
                {
                    gamma[i] = 1;
                    epsilon[i] = 0;
                }
                else
                {
                    gamma[i] = 0;
                    epsilon[i] = 1;
                }
            }

            return Utils.ToInt(gamma) * Utils.ToInt(epsilon);
        }

        public static int SolvePart2(char[][] data)
        {
            byte[] gamma = new byte[data[0].Length];    // most common
            byte[] epsilon = new byte[data[0].Length];  // least common

            List<char[]> onumbers = new List<char[]>(data);
            List<char[]> cnumbers = new List<char[]>(data);

            int oxygen = 0;
            int co2 = 0;

            for (int i = 0; i < data[0].Length; i++)    // right
            {
                int tempo = 0, tempc = 0;

                for (int j = 0; j < onumbers.Count; j++)   // down
                {
                    tempo += (int)char.GetNumericValue(onumbers[j][i]);
                }

                gamma[i] = tempo >= onumbers.Count - tempo ? (byte)1 : (byte)0;

                for (int j = 0; j < cnumbers.Count; j++)   // down
                {
                    tempc += (int)char.GetNumericValue(cnumbers[j][i]);
                }

                epsilon[i] = tempc >= cnumbers.Count - tempc ? (byte)0 : (byte)1;

                List<char[]> temp1 = new List<char[]>();
                List<char[]> temp2 = new List<char[]>();

                for (int j = 0; j < onumbers.Count; j++)   // down
                {
                    if ((int)char.GetNumericValue(onumbers[j][i]) == gamma[i])
                    {
                        // bit matches
                        temp1.Add(onumbers[j]);
                    }
                }

                onumbers = new List<char[]>(temp1);

                if (onumbers.Count == 1)
                {
                    oxygen = Utils.ToInt(temp1[0]);
                }

                for (int j = 0; j < cnumbers.Count; j++)   // down
                {
                    if ((int)char.GetNumericValue(cnumbers[j][i]) == epsilon[i])
                    {
                        // bit matches
                        temp2.Add(cnumbers[j]);
                    }
                }

                cnumbers = new List<char[]>(temp2);

                if (cnumbers.Count == 1)
                {
                    co2 = Utils.ToInt(temp2[0]);
                }
            }

            return oxygen * co2;
        }
    }
}
