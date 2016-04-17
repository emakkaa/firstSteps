using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Trailing0InN_
{
    class Program
    {
        static void Main()
        {
            int N, temp;
            int numberofZeros = 0;
            BigInteger factorial = 1;
            bool isNInt = int.TryParse(Console.ReadLine(), out N);
            Stopwatch sw = new Stopwatch();
            if (isNInt)
            {
                    sw.Start();
                for (int i = 1; i <= N; i++)
                {
                    factorial *= i;
                }
                    sw.Stop();
                if (N >= 5)
                {
                    do
                    {
                        temp = N / 5;
                        if (temp != 0)
                        {
                            numberofZeros += temp;
                            N = temp;
                        }
                        else
                        {
                            break;
                        }
                    }
                    while (true);
                }
                Console.WriteLine(sw.ElapsedMilliseconds);
                Console.WriteLine(numberofZeros);
            }
            else
            {
                Console.WriteLine("Wrong input");
            }
        }
    }
}
