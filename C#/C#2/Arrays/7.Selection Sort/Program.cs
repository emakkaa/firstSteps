using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Selection_Sort
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int flag;
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int minimalPosition;
            for (int i = 0; i < n; i++)
            {
                minimalPosition = i;
                for (int j = i+1; j < n; j++)
                {
                    if (array[j] < array[minimalPosition])
                    {
                        minimalPosition = j;
                    }
                }
                if (minimalPosition != i)
                {
                    flag = array[i];
                    array[i] = array[minimalPosition];
                    array[minimalPosition] = flag;
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
