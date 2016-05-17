using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Binary_Search
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            for (int i = 0; i < N; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int X = int.Parse(Console.ReadLine());
            int counter = 0;
            int print = 0;
            for (int i = 0; i < N; i++)
            {
                if (array[i] == X)
                {
                    print = i;
                    counter++;
                    break;
                }
            }
            if (counter == 1)
            {
                Console.WriteLine(print);
            }
            else
            {
                Console.WriteLine(-1);
            }
        }
    }
}
