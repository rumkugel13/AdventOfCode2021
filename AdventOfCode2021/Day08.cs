
namespace AdventOfCode2021
{
    public class Day08
    {
        string[] patterns;
        string[] outputs;

        public Day08(string[] lines)
        {
            patterns = new string[lines.Length];
            outputs = new string[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                patterns[i] = lines[i].Split(" | ")[0];
                outputs[i] = lines[i].Split(" | ")[1];
            }
        }

        public int SolvePart1()
        {
            HashSet<int> lengths = new HashSet<int> { 2, 3, 4, 7 };
            int sum = 0;
            for (int i = 0; i < outputs.Length; i++)
            {
                var data = outputs[i].Split(' ');
                for (int j = 0; j < data.Length; j++)
                {
                    if (lengths.Contains(data[j].Length))
                    {
                        sum++;
                    }
                }
            }

            return sum;
        }

        public int SolvePart2()
        {
            int sum = 0;
            for (int i = 0; i < patterns.Length; i++)
            {
                // sort by length
                string[] data = patterns[i].Split(' ');
                Array.Sort(data, (a, b) => a.Length - b.Length);

                string[] numbers = MatchNumbers(data);

                // then loop through output and match letters to numbers
                int num = 0;
                var split = outputs[i].Split(' ');
                num += 1000 * GetIndexOfNumber(numbers, split[0]);
                num += 100 * GetIndexOfNumber(numbers, split[1]);
                num += 10 * GetIndexOfNumber(numbers, split[2]);
                num += 1 * GetIndexOfNumber(numbers, split[3]);

                sum += num;
            }

            return sum;
        }

        string[] MatchNumbers(string[] data)
        {
            string[] numbers = new string[data.Length];
            // we know certain lengths correspond to certain numbers
            numbers[1] = data[0]; // length 2 = "1"
            numbers[7] = data[1]; // length 3 = "7"
            numbers[4] = data[2]; // length 4 = "4"
            numbers[8] = data[9]; // length 7 = "8"

            // figure out length 6 first
            List<string> missing6 = new();

            for (int j = 6; j < 9; j++)
            {
                missing6.Add(data[j]);
            }

            foreach (string m in missing6)
            {
                if (m.Contains(numbers[4][0]) &&
                    m.Contains(numbers[4][1]) &&
                    m.Contains(numbers[4][2]) &&
                    m.Contains(numbers[4][3]))
                {
                    // m is 9
                    numbers[9] = m;
                    break;
                }
            }
            missing6.Remove(numbers[9]);

            foreach (string m in missing6)
            {
                if (m.Contains(numbers[1][0]) &&
                    m.Contains(numbers[1][1]))
                {
                    // m is 0
                    numbers[0] = m;
                    break;
                }
            }
            missing6.Remove(numbers[0]);
            numbers[6] = missing6[0];
            missing6.Remove(numbers[6]);

            // figure out length 5 last
            List<string> missing5 = new();

            for (int j = 3; j < data.Length - 4; j++)
            {
                missing5.Add(data[j]);
            }

            foreach (string m in missing5)
            {
                if (m.Contains(numbers[1][0]) &&
                    m.Contains(numbers[1][1]))
                {
                    // m is 3
                    numbers[3] = m;
                    break;
                }
            }
            missing5.Remove(numbers[3]);

            // find 2
            foreach (string m in missing5)
            {
                string eight = numbers[8];
                string nine = numbers[9];

                for (int l = 0; l < nine.Length; l++)
                {
                    eight = eight.Remove(eight.IndexOf(nine[l]), 1);
                }

                if (m.Contains(eight))
                {
                    // m is 2
                    numbers[2] = m;
                    break;
                }
            }
            missing5.Remove(numbers[2]);
            numbers[5] = missing5[0];
            missing5.Remove(numbers[5]);

            return numbers;
        }

        int GetIndexOfNumber(string[] numbers, string target)
        {
            char[] temp = target.ToCharArray();
            Array.Sort(temp);
            string tempStr = new string(temp);

            for (int i = 0; i < numbers.Length; i++)
            {
                char[] number = numbers[i].ToCharArray();
                Array.Sort(number);
                string numberStr = new string(number);

                if (number.Length == temp.Length && numberStr == tempStr)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
