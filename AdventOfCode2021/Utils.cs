
namespace AdventOfCode2021
{
    public class Utils
    {
        public static int[] ToIntArray(string[] input)
        {
            int[] data = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                data[i] = Convert.ToInt32(input[i]);
            }

            return data;
        }

        public static Command[] ToCommands(string[] input)
        {
            Command[] data = new Command[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                var temp = input[i].Split(' ');
                data[i].command = temp[0];
                data[i].value = Convert.ToInt32(temp[1]);
            }

            return data;
        }
    }
}
