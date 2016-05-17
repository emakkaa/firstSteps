using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Maximal_Sequence
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int counter = 1;
            int biggestLength = 0;
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n-1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    counter++;
                    if (counter > biggestLength)
                    {
                        biggestLength = counter;
                    }
                }
                else
                {
                    counter = 1;
                }
                
            }
            Console.WriteLine(biggestLength);
        }
    }
}
