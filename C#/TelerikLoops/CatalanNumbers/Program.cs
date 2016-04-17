using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalanNumbers
{
    class Program
    {
        static BigInteger Fact(BigInteger n)
        {
            if (n <= 1)
                return 1;
            return n * Fact(n - 1);
        }

            static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger catalanNumber = Fact(2*n) / (Fact(n + 1) * Fact(n));
            Console.WriteLine(catalanNumber);
        }
    }
}
