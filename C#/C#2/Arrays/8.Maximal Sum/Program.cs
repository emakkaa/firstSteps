using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int sum = 0;
            int maximalSum = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    sum += array[j];
                    if (sum > maximalSum)
                    {
                        maximalSum = sum;
                    }
                }
                sum = 0;
            }
            Console.WriteLine(maximalSum);
        }
    }
}
