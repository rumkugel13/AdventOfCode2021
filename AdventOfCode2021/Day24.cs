
namespace AdventOfCode2021
{
    public class Day24
    {
        string[] instructions;
        long x, y, z, w;
        Queue<int> queue;

        long[] a, b, c; //constants

        public Day24(string[] lines)
        {
            instructions = lines;
            queue = new Queue<int>();

            a = new long[14];
            b = new long[14];
            c = new long[14];

            for (int i = 0; i < lines.Length; i++)
            {
                if (i % (lines.Length / 14) == 4)
                {
                    a[i / (lines.Length / 14)] = Convert.ToInt32(lines[i].Split(' ')[2]);
                }

                if (i % (lines.Length / 14) == 5)
                {
                    b[i / (lines.Length / 14)] = Convert.ToInt32(lines[i].Split(' ')[2]);
                }

                if (i % (lines.Length / 14) == 11)
                {
                    c[i / (lines.Length / 14)] = Convert.ToInt32(lines[i].Split(' ')[2]);
                }
            }
        }

        void Process(int digit, long a, long b, long c)
        {
            w = digit;
            x = z % 26 + b;
            z = z / a;
            if (x != w)
            {
                z = z * 26 + w + c;
            }
        }

        void ProcesMemo(int index, ref long[] memoz, out long result)
        {
            result = 0;
            for (int k = 9; k > 0; k--)
            {
                z = memoz[index - 1];
                Process(k, a[index], b[index], c[index]);
                memoz[index] = z;
                if (index < 13)
                    ProcesMemo(index + 1, ref memoz, out result);
                else if (z == 0)
                {
                    result = 01;
                    return;
                }
                if (result != 0)
                    return;
            }
        }

        public long SolvePart1()
        {
            string start = "99999999999999";
            long num = Convert.ToInt64(start);

            long[] memoz = new long[14];
            long result = 0;
            //do
            //{
                z = 0;

                for (int i = 9; i > 0; i--)
                {
                    Process(i, a[0], b[0], c[0]);
                    memoz[0] = z;
                    ProcesMemo(1, ref memoz, out result);
                }

            //}
            //while (z != 0);

            return result;

            // brute force
            do
            {
                z = 0;
                string temp = num.ToString();
                foreach (char c in temp)
                {
                    queue.Enqueue((int)char.GetNumericValue(c));
                }

                for (int i = 0; i < 14; i++)
                {
                    Process(queue.Dequeue(), a[i], b[i], c[i]);
                    Console.WriteLine(num.ToString() + $" x{x} y{y} z{z} w{w}");
                }

                //Console.WriteLine(num.ToString() + $" x{x} y{y} z{z} w{w}");
                // decrease 
                do
                {
                    num--;
                    temp = num.ToString();
                }
                while (temp.Contains('0'));
            }
            while (z != 0);

            return num;
        }

        public long SolvePart1Old()
        {
            string start = "99999999999999";
            long num = Convert.ToInt64(start);

            // brute force
            do
            {
                z = 0;
                string temp = num.ToString();
                foreach (char c in temp)
                {
                    queue.Enqueue((int)char.GetNumericValue(c));
                }

                for (int i = 0; i < instructions.Length; i++)
                {
                    Process(instructions[i]);
                }

                Console.WriteLine(num.ToString() + $" x{x} y{y} z{z} w{w}");
                // decrease 
                num = NextNum(num);
            }
            while (z != 0);

            return num;
        }

        // trying to decipher values which reduce z value, not general solution though
        long NextNum(long num)
        {
            string temp;
            do
            {
                num--;
                temp = num.ToString();
            }
            while (temp.Contains('0') 
                    || !(Convert.ToInt32(temp[13]) == Convert.ToInt32(temp[12]) + 2) 
                    //|| temp.EndsWith("179")
                    || !(Convert.ToInt32(temp[9]) == Convert.ToInt32(temp[8]) + 3));
            return num;
        }

        void Process(string instruction)
        {
            var inst = instruction.Split(' ');
            switch(inst[0])
            {
                case "inp":
                    Store(inst[1], queue.Dequeue());
                    break;
                case "add":
                    Store(inst[1], Load(inst[1]) + Load(inst[2]));
                    break;
                case "mul":
                    Store(inst[1], Load(inst[1]) * Load(inst[2]));
                    break;
                case "div":
                    Store(inst[1], Load(inst[1]) / Load(inst[2]));
                    break;
                case "mod":
                    Store(inst[1], Load(inst[1]) % Load(inst[2]));
                    break;
                case "eql":
                    Store(inst[1], Load(inst[1]) == Load(inst[2]) ? 1 : 0);
                    break;
            }
        }

        void Store(string location, long number)
        {
            switch (location)
            {
                case "x":
                    x = number;
                    break;
                case "y":
                    y = number;
                    break;
                case "z":
                    z = number;
                    break;
                case "w":
                    w = number;
                    break;
            }
        }

        long Load(string location)
        {
            switch (location)
            {
                case "x": return x;
                case "y": return y;
                case "z": return z;
                case "w": return w;
                default: return Convert.ToInt64(location);
            }
        }

        public long SolvePart2()
        {
            return 0;
        }
    }
}
