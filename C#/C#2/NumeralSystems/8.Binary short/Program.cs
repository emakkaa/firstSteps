using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Binary_short
{
    class Program
    {
        private static string ShortToBinaryConvertion(short number)
        {
            string binaryNumber = string.Empty;

            for (int i = 15; i >= 0; i--)
            {
                binaryNumber = ((number % 2) & 1) + binaryNumber;
                number >>= 1;
                //if (i % 4 == 0) binary = " " + binary;    // for better print
            }
            return binaryNumber;
        }

        static void Main(string[] args)
        {
            short a = short.Parse(Console.ReadLine());
            string binaryShort = ShortToBinaryConvertion(a);
            Console.WriteLine(binaryShort);
            
        }
    }
}
