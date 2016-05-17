using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.BinaryToHexadecimal
{
    class Program
    {
        public static Dictionary<string, char> BinaryToHexTable = new Dictionary<string, char>()
        {
            {"0000", '0' },
            {"0001", '1' },
            {"0010", '2' },
            {"0011", '3' },
            {"0100", '4' },
            {"0101", '5' },
            {"0110", '6' },
            {"0111", '7' },
            {"1000", '8' },
            {"1001", '9' },
            {"1010", 'A' },
            {"1011", 'B' },
            {"1100", 'C' },
            {"1101", 'D' },
            {"1110", 'E' },
            {"1111", 'F' }
        };

        public static string BinaryToHexadecimal(string input)
        {
            var builder = new StringBuilder();
            string builder2 = input.ToString().PadLeft(100, '0');
            for (int i = 0; i < builder2.Length; i += 4)
            {
                var key = builder2.Substring(i, 4);
                var value = BinaryToHexTable[key];
                builder.Append(value);
            }
            return builder.ToString().TrimStart(new Char[] { '0' });
        }
        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(BinaryToHexadecimal(input));
        }
    }
}
