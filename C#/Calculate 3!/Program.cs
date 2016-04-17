using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_3_
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
            
           int N = int.Parse(Console.ReadLine());
           int K = int.Parse(Console.ReadLine());
            
            BigInteger number = Fact(N) / (Fact(K)*Fact(N-K));
            Console.WriteLine(number);
        }
    }
}
