
namespace AdventOfCode2021
{
    public class Day16
    {
        string bits;

        public Day16(string[] lines)
        {
            string hex = lines[0];

            byte[] data = Convert.FromHexString(hex);

            System.Text.StringBuilder builder = new();
            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(Convert.ToString(data[i], 2).PadLeft(8, '0'));
            }
            bits = builder.ToString();
        }

        struct PacketHeader
        {
            public byte Version;
            public byte TypeID;
        }

        public int SolvePart1()
        {
            int index = 0;
            int versionsum = 0;

            ParsePacket(bits, ref index, ref versionsum);

            return versionsum;
        }

        public long ParsePacket(string bits, ref int index, ref int versionsum)
        {
            PacketHeader header = new PacketHeader();

            header.Version = Convert.ToByte(bits.Substring(index, 3), 2);
            index += 3;
            header.TypeID = Convert.ToByte(bits.Substring(index, 3), 2);
            index += 3;
            versionsum += header.Version;
            long val;

            switch (header.TypeID)
            {
                case 4:
                    // literal value
                    val = ParseValue(bits, ref index);
                    break;
                default:
                    // operator
                    val = ParseOperator(bits, ref index, header.TypeID, ref versionsum);
                    break;
            }

            return val;
        }

        public long ParseOperator(string bits, ref int index, byte typeID, ref int versionsum)
        {
            byte mode = Convert.ToByte(bits.Substring(index, 1), 2);
            index++;
            long result = 0;
            switch (typeID)
            {
                case 1: result = 1; break;
                case 2: result = long.MaxValue; break;
                case 3: result = long.MinValue; break;
            }

            switch (mode)
            {
                case 0:
                    // length of sub packets
                    int length = Convert.ToInt32(bits.Substring(index, 15), 2);
                    index += 15;
                    int stop = index + length;
                    while (index < stop)
                    {
                        long v = ParsePacket(bits, ref index, ref versionsum);
                        switch (typeID)
                        {
                            case 0: result += v; break; // sum
                            case 1: result *= v; break; // product
                            case 2: result = Math.Min(result, v); break; // min
                            case 3: result = Math.Max(result, v); break; // max
                            case 5:
                                // greater than
                                result = v;
                                result = result > ParsePacket(bits, ref index, ref versionsum) ? 1 : 0;
                                break;
                            case 6:
                                // less than
                                result = v;
                                result = result < ParsePacket(bits, ref index, ref versionsum) ? 1 : 0;
                                break;
                            case 7:
                                // equal
                                result = v;
                                result = result == ParsePacket(bits, ref index, ref versionsum) ? 1 : 0;
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                case 1:
                    // number of sub packets
                    int packets = Convert.ToInt32(bits.Substring(index, 11), 2);
                    index += 11;

                    for (int i = 0; i < packets; i++)
                    {
                        long v = ParsePacket(bits, ref index, ref versionsum);
                        switch (typeID)
                        {
                            case 0: result += v; break; // sum
                            case 1: result *= v; break; // product
                            case 2: result = Math.Min(result, v); break; // min
                            case 3: result = Math.Max(result, v); break; // max
                            case 5:
                                // greater than
                                result = (i == 0) ? v : ((result > v) ? 1 : 0);
                                break;
                            case 6:
                                // less than
                                result = (i == 0) ? v : ((result < v) ? 1 : 0);
                                break;
                            case 7:
                                // equal
                                result = (i == 0) ? v : ((result == v) ? 1 : 0);
                                break;
                            default:
                                break;
                        }
                    }
                    break;
            }

            return result;
        }

        public long ParseValue(string bits, ref int index)
        {
            string bitvalue = "";

            do
            {
                string group = bits.Substring(index, 5);
                index += 5;
                bitvalue += group.Substring(1);
                if (group.StartsWith('0'))
                {
                    break;
                }
            }
            while (true);

            return Convert.ToInt64(bitvalue, 2);
        }

        public long SolvePart2()
        {
            int index = 0;
            int versionsum = 0;

            long val = ParsePacket(bits, ref index, ref versionsum);

            return val;
        }
    }
}
