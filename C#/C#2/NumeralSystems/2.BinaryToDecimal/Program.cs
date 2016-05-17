using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BinaryToDecimal
{
    class Program
    {
        static void BinaryToDecimal(string number)
        {
            ulong dec = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[number.Length - i - 1] == '0') continue;
                dec += (ulong)Math.Pow(2, i);
            }
            Console.WriteLine(dec);
        }
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            BinaryToDecimal(number);
        }
    }
}
