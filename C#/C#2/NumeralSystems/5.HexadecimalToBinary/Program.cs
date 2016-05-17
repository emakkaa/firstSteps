using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.HexadecimalToBinary
{
    class Program
    {
        public static Dictionary<char, string> HexBinaryTable = new Dictionary<char, string>()
        {
            {'0',"0000" },
            {'1',"0001" },
            {'2',"0010" },
            {'3',"0011" },
            {'4',"0100" },
            {'5',"0101" },
            {'6',"0110" },
            {'7',"0111" },
            {'8',"1000" },
            {'9',"1001" },
            {'A',"1010" },
            {'B',"1011" },
            {'C',"1100" },
            {'D',"1101" },
            {'E',"1110" },
            {'F',"1111" }
        };
        public static string HexadecimalToBinary(string number)
        {
            var builder = new StringBuilder();
            for (int i = 0; i < number.Length; i++)
            {
                var key = number[i];
                var value = HexBinaryTable[key];
                builder.Append(value);
            }
            var result= builder.ToString().TrimStart(new Char[] { '0' }); ;
            
            return result;
        }

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(HexadecimalToBinary(input));

        }
    }
}
