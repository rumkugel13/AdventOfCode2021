
namespace AdventOfCode2021
{
    public struct Command
    {
        public string command;
        public int value;
    }

    public class Day02
    {
        public static int SolvePart1(Command[] commands)
        {
            int position = 0;
            int depth = 0;

            for (int i = 0; i < commands.Length; i++)
            {
                switch(commands[i].command)
                {
                    case "forward":
                        position += commands[i].value;
                        break;
                    case "up":
                        depth -= commands[i].value;
                        break;
                    case "down":
                        depth += commands[i].value;
                        break;
                }
            }

            return position * depth;
        }

        public static int SolvePart2(Command[] commands)
        {
            int position = 0;
            int depth = 0;
            int aim = 0;

            for (int i = 0; i < commands.Length; i++)
            {
                switch (commands[i].command)
                {
                    case "forward":
                        position += commands[i].value;
                        depth += aim * commands[i].value;
                        break;
                    case "up":
                        aim -= commands[i].value;
                        break;
                    case "down":
                        aim += commands[i].value;
                        break;
                }
            }

            return position * depth;
        }
    }
}
