using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _10.Factorial
{
    class Program
    {
        static BigInteger factorial(BigInteger n)
        {
            if (n <= 0)
                return 1;
            else return n * factorial(n - 1);
        }
        static void Main(string[] args)
        {
            BigInteger n = int.Parse(Console.ReadLine());
            Console.WriteLine(factorial(n));
        }
    }
}
