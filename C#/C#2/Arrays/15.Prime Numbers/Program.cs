using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Prime_Numbers
{
    class Program
    {
        static void Main()
        {
            // Това е по дадения метод, става адски бавно и не мога да измисля нещо по рационално..
            //int N = int.Parse(Console.ReadLine());
            //int[] array = new int[N];
            //for (int i =1; i <= N; i++)
            //{
            //    array[i-1] = i;
            //}
            //int copy = N;
            //int maxPrime = array[0];
            //for (int i = 2; i <=(int)Math.Sqrt(copy); i++)
            //{
            //    for (int j = 0; j <= N; j++)
            //    {
            //        if (array[j] % i == 0)
            //        {
            //            for (int k = j; k < N-1; k++)
            //            {
            //                array[k] = array[k + 1];
            //            }
            //            N--;
            //        }
            //    }
            //}
            //for (int i = 0; i < N; i++)
            //{
            //    if (array[i] > maxPrime)
            //    {
            //        maxPrime = array[i];
            //    }
            //}
            //Console.WriteLine(maxPrime);
            //Console.WriteLine(array[N-1]);
            int n = int.Parse(Console.ReadLine());
            for (int i = n; i > 0; i--)
            {
                int number = i;
                bool flag = true;
                for (int k = 2; k <= Math.Sqrt(number); k++)
                {
                    if (number % k == 0)
                    {
                        flag = false;
                        continue;
                    }
                }
                if (flag)
                {
                    Console.WriteLine(number);
                    break;
                }
            }
        }
    }
}
