using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.RemoveElementsFromArray
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int copyOfN = N;
            int[] array = new int[N];
            for (int i = 0; i < N; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 1; i < copyOfN-1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    if (array[i-1]>array[i])
                    {
                        for (int j = i; j < N - 1; j++)
                        {
                            array[j] = array[j + 1];
                        }
                        N--;
                    }
                    else if(array[i-1]<array[i])
                    {
                        for (int j = i; j < N - 1; j++)
                        {
                            array[j] = array[j + 1];
                        }
                        N--;
                    }
                }
            }
            int counter = 0;
            for (int i = 0; i < N; i++)
            {
                counter++;
            }
            Console.WriteLine(copyOfN-counter);
        }
    }
}
