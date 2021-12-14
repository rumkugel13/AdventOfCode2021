using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021
{
    public class Day14
    {
        string template;
        Dictionary<string, string> formulas;

        public Day14(string[] lines)
        {
            template = lines[0];

            formulas = new Dictionary<string, string>();

            for (int i = 2; i < lines.Length; i++)
            {
                var split = lines[i].Split(" -> ");
                formulas.Add(split[0], split[1]);
            }
        }

        public int SolvePart1()
        {
            string start = new string(template);

            for (int i = 0; i < 10; i++)
            {
                start = Process(start);
            }

            char[] chars = start.ToCharArray();
            Array.Sort(chars);

            Dictionary<char, int> count = new Dictionary<char, int>();

            foreach (char c in chars)
            {
                if (!count.TryAdd(c, 1))
                    count[c]++;
            }

            return count.Values.Max() - count.Values.Min();
        }

        string Process(string template)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < template.Length - 1; i++)
            {
                sb.Append(template[i]);
                if (formulas.ContainsKey(template.Substring(i, 2)))
                {
                    sb.Append(formulas[template.Substring(i, 2)]);
                }
            }
            sb.Append(template[template.Length - 1]);

            return sb.ToString();
        }

        public long SolvePart2()
        {
            Dictionary<string, long> countFormulas = new();
            Dictionary<char, long> countChar = new();

            for (int i = 0; i < template.Length - 1; i++)
            {
                if (!countFormulas.TryAdd(template.Substring(i, 2), 1))
                {
                    countFormulas[template.Substring(i, 2)]++;
                }

                if (!countChar.TryAdd(template[i], 1))
                {
                    countChar[template[i]]++;
                }
            }

            if (!countChar.TryAdd(template[template.Length - 1], 1))
            {
                countChar[template[template.Length - 1]]++;
            }

            for (int i = 0; i < 40; i++)
            {
                OneStep(countFormulas, countChar);
            }

            return countChar.Values.Max() - countChar.Values.Min();
        }

        public void OneStep(Dictionary<string, long> count, Dictionary<char, long> countChar)
        {
            Dictionary<string, long> temp = new(count);
            foreach (string key in temp.Keys)
            {
                string left = key[0] + formulas[key];
                string right = formulas[key] + key[1];

                if (!count.TryAdd(left, temp[key]))
                {
                    count[left] += temp[key];
                }

                if (!count.TryAdd(right, temp[key]))
                {
                    count[right] += temp[key];
                }

                // note: the original formula gets replaced by the left and right ones
                count[key] -= temp[key];

                if (!countChar.TryAdd(formulas[key][0], temp[key]))
                {
                    countChar[formulas[key][0]] += temp[key];
                }
            }
        }

        public long SolvePart2NOT()
        {
            string start = new string(template);

            for (int i = 0; i < 10; i++)
            {
                start = Process(start);
            }

            char[] chars = start.ToCharArray();
            Array.Sort(chars);

            Dictionary<char, int> count = new Dictionary<char, int>();

            foreach (char c in chars)
            {
                if (!count.TryAdd(c, 1))
                    count[c]++;
            }

            // 11th time
            start = Process(start);

            char[] chars2 = start.ToCharArray();
            Array.Sort(chars2);

            Dictionary<char, int> count2 = new Dictionary<char, int>();

            foreach (char c in chars2)
            {
                if (!count2.TryAdd(c, 1))
                    count2[c]++;
            }

            int most = count[count.Keys.Where(k => count[k] == count.Values.Max()).First()];
            int least = count[count.Keys.Where(k => count[k] == count.Values.Min()).First()];

            int most2 = count2[count2.Keys.Where(k => count2[k] == count2.Values.Max()).First()];
            int least2 = count2[count2.Keys.Where(k => count2[k] == count2.Values.Min()).First()];

            double factormost = (double)most2 / most;
            double factorleast = (double)least2 / least;

            long min11 = count2.Values.Min();
            long max11 = count2.Values.Max();

            for (int i = 11; i < 40; i++)
            {
                min11 = (long)(min11 * factorleast);
                max11 = (long)(max11 * factormost);
            }

            return max11 - min11;
        }
    }
}
