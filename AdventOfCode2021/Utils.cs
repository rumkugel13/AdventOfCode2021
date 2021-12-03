
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

        public static char[][] ToCharArray(string[] input)
        {
            char[][] data = new char[input.Length][];

            for (int i =0; i < input.Length; i++)
            {
                data[i] = input[i].ToCharArray();
            }

            return data;
        }

        public static int ToInt(byte[] bits)
        {
            int result = 0;

            for (int i = bits.Length - 1; i >= 0; i--)
            {
                result += bits[i] * (int)Math.Pow(2, bits.Length - i - 1);
            }

            return result;
        }

        public static int ToInt(char[] bits)
        {
            int result = 0;

            for (int i = bits.Length - 1; i >= 0; i--)
            {
                result += (int)char.GetNumericValue(bits[i]) * (int)Math.Pow(2, bits.Length - i - 1);
            }

            return result;
        }
    }
}
