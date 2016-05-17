using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeralSystems
{
    class Program
    {
        static void decToBinary(ulong decimalNumber)
        {
            ulong flag;
            string result = string.Empty;
            while (decimalNumber > 0)
            {
                flag = decimalNumber % 2;
                decimalNumber /= 2;
                result = flag.ToString() + result;
            }
            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            
            ulong decimalNumber =ulong.Parse(Console.ReadLine());
            
            decToBinary(decimalNumber);
        }
    }
}
