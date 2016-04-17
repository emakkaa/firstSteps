using System;
using System.Numerics;

namespace Calculate_again_
{
    class Program
    {
        
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            BigInteger factN = 1;
            BigInteger factK = 1;
            for (int i = 1; i <= N; i++)
            {
                factN *= i;
            }
            for (int j = 1; j <=K ; j++)
            {
                factK *= j;
            }
            BigInteger result =factN / factK;
            Console.WriteLine(result);
        }
    }
}
