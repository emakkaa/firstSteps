using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class Program
    {
        static void Main()
        {
            int flag;
            int decimalNumber = int.Parse(Console.ReadLine());
            string result = string.Empty;
            while (decimalNumber > 0)
            {
                flag = decimalNumber % 2;
                decimalNumber /= 2;
                result = flag.ToString() + result;
            }
            Console.WriteLine(result);
        }
    }
}
