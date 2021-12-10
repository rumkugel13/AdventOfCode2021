
namespace AdventOfCode2021
{
    public class Day10
    {
        string[] lines;
        List<char> opening, closing;
        int[] scores;

        public Day10(string[] lines)
        {
            this.lines = lines;
            opening = new List<char> { '(', '[', '{', '<' };
            closing = new List<char> { ')', ']', '}', '>' };
            scores = new int[4] { 3, 57, 1197, 25137 };
        }

        public int SolvePart1()
        {
            int sum = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                sum += GetSyntaxErrorScore(lines[i], 0, new Stack<char>());
            }

            return sum;
        }

        int GetSyntaxErrorScore(string line, int index, Stack<char> opened)
        {
            if (index == line.Length)
            {
                return 0;
            }

            if (opening.Contains(line[index]))
            {
                opened.Push(line[index]);
                return GetSyntaxErrorScore(line, index + 1, opened);
            }

            if (opening.IndexOf(opened.Peek()) == closing.IndexOf(line[index]))
            {
                opened.Pop();
                return GetSyntaxErrorScore(line, index + 1, opened);
            }
            else
            {
                return scores[closing.IndexOf(line[index])];
            }
        }

        public long SolvePart2()
        {
            List<Stack<char>> stacks = new List<Stack<char>>();

            for (int i = 0; i < lines.Length; i++)
            {
                Stack<char> stack = new Stack<char>();
                if (GetSyntaxErrorScore(lines[i], 0, stack) == 0)
                {
                    stacks.Add(stack);
                }
            }

            long[] results = new long[stacks.Count];
            for (int i = 0; i < stacks.Count;i++)
            {
                Stack<char> current = stacks[i];
                while (current.Count > 0)
                {
                    results[i] *= 5;
                    results[i] += opening.IndexOf(current.Pop()) + 1;
                }
            }

            Array.Sort(results);
            return results[results.Length / 2];            
        }
    }
}
